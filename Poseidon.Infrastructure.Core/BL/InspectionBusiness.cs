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
    /// 设施检验业务类
    /// </summary>
    public class InspectionBusiness : AbstractBusiness<Inspection>, IBaseBL<Inspection>, IExpenseBusiness
    {
        #region Constructor
        /// <summary>
        /// 设施检验业务类
        /// </summary>
        public InspectionBusiness()
        {
            this.baseDal = RepositoryFactory<IInspectionRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 按设施查找检验信息
        /// </summary>
        /// <param name="facilityId">设施ID</param>
        /// <returns></returns>
        public IEnumerable<Inspection> FindByFacility(string facilityId)
        {
            return this.baseDal.FindListByField("facilityId", facilityId);
        }

        /// <summary>
        /// 检查检验信息是否能删除
        /// </summary>
        /// <param name="id">检验信息ID</param>
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

        #region Override
        /// <summary>
        /// 新增费用记录后操作
        /// </summary>
        /// <param name="expenseId">新费用ID</param>
        /// <param name="documentId">检验记录ID</param>
        public void AfterCreate(string expenseId, string documentId)
        {
            var entity = this.baseDal.FindById(documentId);
            entity.ExpenseIds.Add(expenseId);

            this.baseDal.Update(entity);
        }
        #endregion //Override

        #region CRUD
        /// <summary>
        /// 添加检验信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Inspection entity, ILoginUser user)
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
            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑检验信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public (bool success, string errorMessage) Update(Inspection entity, ILoginUser user)
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
        /// 返回检验类
        /// </summary>
        /// <param name="modelType">模型类型</param>
        /// <returns></returns>
        public static Type GetInspectionType(string modelType)
        {
            if (modelType == Utility.ModelTypeCode.Elevator)
            {
                return typeof(ElevatorInspection);
            }
            else
            {
                return null;
            }
        }
        #endregion //Static
    }
}
