using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Core.BL
{
    using Poseidon.Base.Framework;
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
    }
}
