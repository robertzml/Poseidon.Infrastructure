using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Core.IDAL
{
    using Poseidon.Base.Framework;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 维保信息数据访问接口
    /// </summary>
    internal interface IMaintenanceInfoRepository : IBaseDAL<MaintenanceInfo>
    {
    }
}
