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
    /// 设施检修业务类
    /// </summary>
    public class InspectionBusiness : AbstractBusiness<Inspection>, IBaseBL<Inspection>
    {
        #region Constructor
        /// <summary>
        /// 设施检修业务类
        /// </summary>
        public InspectionBusiness()
        {
            this.baseDal = RepositoryFactory<IInspectionRepository>.Instance;
        }
        #endregion //Constructor
    }
}
