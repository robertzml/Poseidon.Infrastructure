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
        /// 名称
        /// </summary>
        [Display(Name = "名称")]
        public string Name { get; set; }
             
        /// <summary>
        /// 维修改造类型
        /// </summary>
        [Dict("Infrastructure.Repair")]
        [Display(Name = "维修改造类型")]
        public int Type { get; set; }

        /// <summary>
        /// 设施模型类型
        /// </summary>
        [Display(Name = "设施模型类型")]
        public string ModelType { get; set; }

        /// <summary>
        /// 施工单位
        /// </summary>
        [Display(Name = "施工单位")]
        public string ConstructionCompany { get; set; }

        /// <summary>
        /// 开始日期
        /// </summary>
        [Display(Name = "开始日期")]
        public DateTime StartDate { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        [Display(Name = "结束日期")]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// 维修改造费用
        /// </summary>
        [Display(Name = "维修改造费用")]
        public decimal RepairFee { get; set; }

        /// <summary>
        /// 是否工程项目
        /// </summary>
        [Display(Name = "是否工程项目")]
        public bool IsProject { get; set; }

        /// <summary>
        /// 工程项目ID
        /// </summary>
        [Display(Name = "工程项目ID")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 费用ID
        /// </summary>
        [Display(Name = "费用ID")]
        public List<string> ExpenseIds { get; set; }
        #endregion //Property
    }
}
