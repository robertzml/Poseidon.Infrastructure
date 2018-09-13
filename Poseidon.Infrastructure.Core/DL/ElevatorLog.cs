using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Core.DL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.Utility;

    /// <summary>
    /// 电梯运行日志类
    /// </summary>
    public class ElevatorLog : BusinessEntity
    {
        #region Property
        /// <summary>
        /// 电梯ID
        /// </summary>
        [Display(Name = "电梯ID")]
        public string ElevatorId { get; set; }

        /// <summary>
        /// 主题
        /// </summary>
        [Display(Name = "主题")]
        public string Subject { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        [Display(Name = "开始日期")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        [Display(Name = "结束日期")]
        public DateTime EndDate { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [Dict("Infrastructure.ElevatorLogType")]
        [Display(Name = "事件类型")]
        public int LogType { get; set; }

        /// <summary>
        /// 事件内容
        /// </summary>
        [Display(Name = "事件内容")]
        public string Info { get; set; }

        /// <summary>
        /// 事件状态
        /// </summary>
        [Dict("Infrastructure.ElevatorLogStatus")]
        [Display(Name = "事件状态")]
        public int LogStatus { get; set; }
        #endregion //Property
    }
}
