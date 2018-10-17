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

    /// <summary>
    /// 维保信息业务类
    /// </summary>
    public class MaintenanceInfoBusiness : AbstractBusiness<MaintenanceInfo>, IBaseBL<MaintenanceInfo>
    {
        #region Constructor
        /// <summary>
        /// 维保信息业务类
        /// </summary>
        public MaintenanceInfoBusiness()
        {
            this.baseDal = RepositoryFactory<IMaintenanceInfoRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 按设施查找维保信息
        /// </summary>
        /// <param name="facilityId">设施ID</param>
        /// <returns></returns>
        public IEnumerable<MaintenanceInfo> FindByFacility(string facilityId)
        {
            return this.baseDal.FindListByField("facilityId", facilityId);
        }

        /// <summary>
        /// 按维保公司查找维保信息
        /// </summary>
        /// <param name="maintenanceCompanyId">维保公司ID</param>
        /// <returns></returns>
        public IEnumerable<MaintenanceInfo> FindByCompany(string maintenanceCompanyId)
        {
            return this.baseDal.FindListByField("maintenanceCompanyId", maintenanceCompanyId);
        }

        /// <summary>
        /// 添加维保信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(MaintenanceInfo entity, ILoginUser user)
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
        /// 编辑维保信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public (bool success, string errorMessage) Update(MaintenanceInfo entity, ILoginUser user)
        {
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            return base.Update(entity);
        }
        #endregion //Method
    }
}
