using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Core.Utility
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 维修改造年度汇总模型
    /// </summary>
    public class RepairYearSummaryModel : BaseEntity
    {
        #region Property
        /// <summary>
        /// 年度
        /// </summary>
        [Display(Name = "年度")]
        public int Year { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [Display(Name = "数量")]
        public int Count { get; set; }

        /// <summary>
        /// 费用(元)
        /// </summary>
        [Display(Name = "费用")]
        public decimal TotalFee { get; set; }
        #endregion //Property
    }
}
