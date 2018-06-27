using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Core.DL
{
    using Poseidon.Core.DL;

    /// <summary>
    /// 电梯类
    /// </summary>
    public class Elevator : Facility
    {
        #region Property
        /// <summary>
        /// 型号
        /// </summary>
        [Display(Name = "型号")]
        public string Model { get; set; }

        /// <summary>
        /// 注册号
        /// </summary>
        [Display(Name = "注册号")]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// 救援识别码
        /// </summary>
        [Display(Name = "救援识别码")]
        public string RescueNumber { get; set; }

        /// <summary>
        /// 载重(kg)
        /// </summary>
        [Display(Name = "载重(kg)")]
        public int Capacity { get; set; }

        /// <summary>
        /// 安装地点
        /// </summary>
        [Display(Name = "安装地点")]
        public string Position { get; set; }
        #endregion //Property
    }
}
