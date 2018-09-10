using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Core.Utility
{
    /// <summary>
    /// 常量类
    /// </summary>
    public static class InfrastructureConstant
    {
        #region Field
        /// <summary>
        /// 模块名称 Infrastructure
        /// </summary>
        public static readonly string ModuleName = "Infrastructure";

        /// <summary>
        /// 电梯分组代码
        /// </summary>
        public static readonly string ElevatorGroupCode = "Elevator";

        /// <summary>
        /// 检验类集合名称
        /// </summary>
        public static readonly string InspectionCollectionName = "infrastructure_inspection";

        /// <summary>
        /// 维修改造类集合名称
        /// </summary>
        public static readonly string RepairCollectionName = "infrastructure_repair";

        /// <summary>
        /// 记录起始年份
        /// </summary>
        public static readonly int StartYear = 2016;
        #endregion //Field
    }
}
