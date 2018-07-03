using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 维保信息类
    /// </summary>
    public class MaintenanceInfo : BusinessEntity
    {
        #region Property
        /// <summary>
        /// 设施ID
        /// </summary>
        [Display(Name = "设施ID")]
        public string FacilityId { get; set; }

        /// <summary>
        /// 设施名称
        /// </summary>
        [Display(Name = "设施名称")]
        public string FacilityName { get; set; }

        /// <summary>
        /// 维保公司ID
        /// </summary>
        [Display(Name = "维保公司ID")]
        public string MaintenanceCompanyId { get; set; }

        /// <summary>
        /// 维保公司名称
        /// </summary>
        [Display(Name = "维保公司名称")]
        public string MaintenanceCompanyName { get; set; }

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
        /// 维保费用
        /// </summary>
        [Display(Name = "维保费用")]
        public decimal MaintenanceFee { get; set; }

        /// <summary>
        /// 是否免保
        /// </summary>
        [Display(Name = "是否免保")]
        public bool IsFree { get; set; }
        #endregion //Property
    }
}
