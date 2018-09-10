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
    /// 电梯日志业务类
    /// </summary>
    public class ElevatorLogBusiness : AbstractBusiness<ElevatorLog>, IBaseBL<ElevatorLog>
    {
        #region Constructor
        /// <summary>
        /// 电梯日志业务类
        /// </summary>
        public ElevatorLogBusiness()
        {
            this.baseDal = RepositoryFactory<IElevatorLogRepository>.Instance;
        }
        #endregion //Constructor
    }
}
