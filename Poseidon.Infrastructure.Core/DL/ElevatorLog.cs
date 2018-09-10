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
        /// 日期
        /// </summary>
        [Display(Name = "日期")]
        public DateTime LogDate { get; set; }

        /// <summary>
        /// 事件类型
        /// </summary>
        [Display(Name = "事件类型")]
        public int LogType { get; set; }

        /// <summary>
        /// 事件内容
        /// </summary>
        [Display(Name = "事件内容")]
        public string Info { get; set; }
        #endregion //Property
    }
}
