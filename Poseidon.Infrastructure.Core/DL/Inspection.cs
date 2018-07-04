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
    /// 设施检验信息类
    /// </summary>
    public class Inspection : BusinessEntity
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
        /// 设施模型类型
        /// </summary>
        [Display(Name = "设施模型类型")]
        public string ModelType { get; set; }

        /// <summary>
        /// 检验类型
        /// </summary>
        [Display(Name = "检验类型")]
        public int Type { get; set; }

        /// <summary>
        /// 计划时间
        /// </summary>
        [Display(Name = "计划时间")]
        public DateTime PlanDate { get; set; }

        /// <summary>
        /// 检验时间
        /// </summary>
        [Display(Name = "检验时间")]
        public DateTime? InspectionDate { get; set; }

        /// <summary>
        /// 检验费用
        /// </summary>
        [Display(Name = "检验费用")]
        public decimal InspectionFee { get; set; }

        /// <summary>
        /// 检验单位
        /// </summary>
        [Display(Name = "检验单位")]
        public string InspectionCompany { get; set; }

        /// <summary>
        /// 检验结果
        /// </summary>
        [Display(Name = "检验结果")]
        public string InspectionResult { get; set; }

        /// <summary>
        /// 是否执行
        /// </summary>
        [Display(Name = "是否执行")]
        public bool IsDone { get; set; }
        #endregion //Property
    }
}
