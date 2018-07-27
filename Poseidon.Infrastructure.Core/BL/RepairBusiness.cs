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
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Core.Utility;

    /// <summary>
    /// 维修改造业务类
    /// </summary>
    public class RepairBusiness : AbstractBusiness<Repair>, IBaseBL<Repair>, IExpenseBusiness
    {
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
        /// 按设施查找维修改造信息
        /// </summary>
        /// <param name="facilityId">设施ID</param>
        /// <returns></returns>
        public IEnumerable<Repair> FindByFacility(string facilityId)
        {
            return this.baseDal.FindListByField("facilityId", facilityId);
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

        #region CRUD
        /// <summary>
        /// 添加维修改造
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Repair entity, LoginUser user)
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
            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑维修改造
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(Repair entity, LoginUser user)
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

        #region Static
        /// <summary>
        /// 返回维修改造类
        /// </summary>
        /// <param name="modelType">模型类型</param>
        /// <returns></returns>
        public static Type GetRepairType(string modelType)
        {
            if (modelType == Utility.ModelTypeCode.Elevator)
            {
                return typeof(ElevatorRepair);
            }
            else
            {
                return null;
            }
        }
        #endregion //Static
    }
}
