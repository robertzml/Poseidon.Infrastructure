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
    using Poseidon.Finance.Core.Utility;

    /// <summary>
    /// 维修改造记录类
    /// </summary>
    public class RepairRecord : BaseEntity
    {
        #region Property
        /// <summary>
        /// 维修改造ID
        /// </summary>
        [Display(Name = "维修改造ID")]
        public string RepairId { get; set; }

        /// <summary>
        /// 设施模型类型
        /// </summary>
        [Display(Name = "设施模型类型")]
        public string ModelType { get; set; }

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
        /// 项目名称
        /// </summary>
        [Display(Name = "项目名称")]
        public string ItemName { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [Display(Name = "数量")]
        public decimal Count { get; set; }

        /// <summary>
        /// 单位
        /// </summary>
        [Display(Name = "单位")]
        public string Unit { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [Display(Name = "单价")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        [Display(Name = "总价")]
        public decimal TotalPrice { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态")]
        public int Status { get; set; }
        #endregion //Property
    }
}
