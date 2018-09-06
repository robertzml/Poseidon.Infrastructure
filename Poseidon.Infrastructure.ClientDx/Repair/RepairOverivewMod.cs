using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Infrastructure.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.Utility;
    using Poseidon.Winform.Base;
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Utility;

    /// <summary>
    /// 维修改造总览模块
    /// </summary>
    public partial class RepairOverivewMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public RepairOverivewMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 显示维修改造年度汇总
        /// </summary>
        private async void DisplayYearSummary()
        {
            var task = Task.Run(() =>
            {
                var data = BusinessFactory<RepairBusiness>.Instance.GetYearSummary();
                return data.ToList();
            });

            var result = await task;

            this.repairYearSumGrid.DataSource = result;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            DisplayYearSummary();
        }
        #endregion //Method
    }
}
