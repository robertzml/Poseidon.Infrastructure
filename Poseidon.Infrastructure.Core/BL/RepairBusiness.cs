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
    }
}
