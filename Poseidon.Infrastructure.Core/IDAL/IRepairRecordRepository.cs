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
    /// 维修改造记录数据访问接口
    /// </summary>
    internal interface IRepairRecordRepository : IBaseDAL<RepairRecord>
    {
        /// <summary>
        /// 按维修改造项目ID列表查找记录
        /// </summary>
        /// <param name="repairIds">维修改造项目ID列表</param>
        /// <returns></returns>
        IEnumerable<RepairRecord> FindListInRepairIds(List<string> repairIds);
    }
}
