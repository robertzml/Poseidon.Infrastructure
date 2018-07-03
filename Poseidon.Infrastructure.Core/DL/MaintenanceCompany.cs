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
    /// 维保单位类
    /// </summary>
    public class MaintenanceCompany : Organization
    {
        #region Property
        /// <summary>
        /// 地址
        /// </summary>
        [Display(Name = "地址")]
        public string Address { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        [Display(Name = "联系人")]
        public string Contact { get; set; }
        #endregion //Propery
    }
}
