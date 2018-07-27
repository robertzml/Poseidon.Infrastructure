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
    /// 维修改造记录业务类
    /// </summary>
    public class RepairRecordBusiness : AbstractBusiness<RepairRecord>, IBaseBL<RepairRecord>
    {
        #region Constructor
        /// <summary>
        /// 维修改造记录业务类
        /// </summary>
        public RepairRecordBusiness()
        {
            this.baseDal = RepositoryFactory<IRepairRecordRepository>.Instance;
        }
        #endregion //Constructor
    }
}
