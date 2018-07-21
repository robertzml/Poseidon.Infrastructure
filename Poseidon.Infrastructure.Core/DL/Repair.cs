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
    /// 设施维修改造类
    /// </summary>
    public class Repair : BusinessEntity, IExpenseEntity
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
        /// 类型
        /// </summary>
        [Display(Name = "类型")]
        public virtual int Type { get; set; }

        /// <summary>
        /// 施工单位
        /// </summary>
        [Display(Name = "施工单位")]
        public string ConstructionCompany { get; set; }        

        /// <summary>
        /// 是否执行
        /// </summary>
        [Display(Name = "是否执行")]
        public bool IsDone { get; set; }

        /// <summary>
        /// 费用ID
        /// </summary>
        [Display(Name = "费用ID")]
        public List<string> ExpenseIds { get; set; }
        #endregion //Property
    }
}
