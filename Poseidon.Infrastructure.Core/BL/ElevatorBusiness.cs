using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.IDAL;

    /// <summary>
    /// 电梯业务类
    /// </summary>
    public class ElevatorBusiness : AbstractBusiness<Elevator>
    {
        #region Constructor
        /// <summary>
        /// 电梯业务类
        /// </summary>
        public ElevatorBusiness()
        {
            this.baseDal = RepositoryFactory<IElevatorRepository>.Instance;
        }
        #endregion //Constructor
    }
}
