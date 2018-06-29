using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Core.DL
{
    using Poseidon.Base.Framework;
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
        /// 速度(m/s)
        /// </summary>
        [Display(Name = "速度(m/s)")]
        public double Speed { get; set; }

        /// <summary>
        /// 层站
        /// </summary>
        [Display(Name = "层站")]
        public string Station { get; set; }

        /// <summary>
        /// 生产厂商
        /// </summary>
        [Display(Name = "生产厂商")]
        public string Vendor { get; set; }

        /// <summary>
        /// 安装地点
        /// </summary>
        [Display(Name = "安装地点")]
        public string Position { get; set; }

        /// <summary>
        /// 档案袋
        /// </summary>
        [Display(Name = "档案袋")]
        public string RecordBag { get; set; }

        /// <summary>
        /// 档案号
        /// </summary>
        [Display(Name = "档案号")]
        public string RecordNumber { get; set; }
        #endregion //Property
    }

    /// <summary>
    /// 电梯管理员类
    /// </summary>
    public class ElevatorManager : BaseEntity
    {

    }
}
