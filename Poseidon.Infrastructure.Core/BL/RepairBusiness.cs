using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.IDAL;
    using Poseidon.Infrastructure.Core.Utility;
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Core.Utility;

    /// <summary>
    /// 维修改造业务类
    /// </summary>
    public class RepairBusiness : AbstractBusiness<Repair>, IBaseBL<Repair>, IExpenseBusiness
    {
        #region Field
        /// <summary>
        /// 起始年份
        /// </summary>
        private readonly int startYear = 2017;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 维修改造业务类
        /// </summary>
        public RepairBusiness()
        {
            this.baseDal = RepositoryFactory<IRepairRepository>.Instance;
        }
        #endregion //Constructor

        #region Override
        /// <summary>
        /// 新增费用记录后操作
        /// </summary>
        /// <param name="expenseId">新费用ID</param>
        /// <param name="documentId">维修改造ID</param>
        public void AfterCreate(string expenseId, string documentId)
        {
            var entity = this.baseDal.FindById(documentId);
            entity.ExpenseIds.Add(expenseId);

            this.baseDal.Update(entity);
        }
        #endregion //Override

        #region Method
        /// <summary>
        /// 按设施类型查找维修改造信息
        /// </summary>
        /// <param name="modelType">设施类型</param>
        /// <returns></returns>
        public IEnumerable<Repair> FindByModelType(string modelType)
        {
            return this.baseDal.FindListByField("modelType", modelType);
        }

        /// <summary>
        /// 查找包含相关设施的维修改造项目
        /// </summary>
        /// <param name="facilityId">设施ID</param>
        /// <returns></returns>
        public IEnumerable<Repair> FindByFacility(string facilityId)
        {
            RepairRecordBusiness recordBusiness = new RepairRecordBusiness();
            var records = recordBusiness.FindListByField("facilityId", facilityId);

            var repairIds = records.Select(r => r.RepairId).Distinct().ToList();

            var data = this.baseDal.FindListInIds(repairIds);
            return data;
        }

        /// <summary>
        /// 按年份查找维修改造信息
        /// </summary>
        /// <param name="year">年份</param>
        /// <returns></returns>
        public IEnumerable<Repair> FindByYear(int year)
        {
            var dal = this.baseDal as IRepairRepository;
            return dal.FindByYear(year);
        }

        /// <summary>
        /// 按设施类型和年份查找维修改造项目
        /// </summary>
        /// <param name="modelType">设施类型</param>
        /// <param name="year">年份</param>
        /// <returns></returns>
        public IEnumerable<Repair> FindByModelTypeAndYear(string modelType, int year)
        {
            var dal = this.baseDal as IRepairRepository;
            return dal.FindByModelTypeAndYear(modelType, year);
        }

        /// <summary>
        /// 检查维修改造信息是否能删除
        /// </summary>
        /// <param name="id">维修改造信息ID</param>
        /// <returns></returns>
        /// <remarks>
        /// 有费用记录的不能删除
        /// </remarks>
        public bool CheckDelete(string id)
        {
            var entity = this.baseDal.FindById(id);

            if (entity.ExpenseIds.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion //Method

        #region Statistic
        /// <summary>
        /// 获取维修改造年度汇总
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RepairYearSummaryModel> GetYearSummary()
        {
            var dal = this.baseDal as IRepairRepository;
            var data = new List<RepairYearSummaryModel>();

            int nowYear = DateTime.Now.Year;
            for (int i = nowYear; i >= startYear; i--)
            {
                var repairs = dal.FindByYear(i).ToList();

                RepairYearSummaryModel item = new RepairYearSummaryModel
                {
                    Year = i,
                    Count = repairs.Count,
                    TotalFee = repairs.Sum(r => r.RepairFee)
                };

                data.Add(item);
            }

            return data;
        }
        #endregion //Statistic

        #region CRUD
        /// <summary>
        /// 添加维修改造
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Repair entity, ILoginUser user)
        {
            entity.CreateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };

            entity.IsProject = false;
            entity.ProjectId = "";
            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑维修改造
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(Repair entity, ILoginUser user)
        {
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            return base.Update(entity);
        }
        #endregion //CRUD
    }
}
