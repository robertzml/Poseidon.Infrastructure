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
    /// 维保单位业务类
    /// </summary>
    public class MaintenanceCompanyBusiness : AbstractBusiness<MaintenanceCompany>, IBaseBL<MaintenanceCompany>
    {
        #region Constructor
        /// <summary>
        /// 维保单位业务类
        /// </summary>
        public MaintenanceCompanyBusiness()
        {
            this.baseDal = RepositoryFactory<IMaintenanceCompanyRepository>.Instance;
        }
        #endregion //Constructor
    }
}
