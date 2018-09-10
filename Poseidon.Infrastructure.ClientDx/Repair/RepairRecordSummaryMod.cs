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

    /// <summary>
    /// 维修改造记录年度汇总控件
    /// </summary>
    public partial class RepairRecordSummaryMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前年度
        /// </summary>
        private int nowYear;

        /// <summary>
        /// 模型类型
        /// </summary>
        private string modelType;
        #endregion //Field

        #region Constructor
        public RepairRecordSummaryMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化控件
        /// </summary>
        private void InitControls()
        {
            this.cmbYear.Properties.Items.Clear();

            for (int i = nowYear; i >= InfrastructureConstant.StartYear; i--)
            {
                this.cmbYear.Properties.Items.Add(i.ToString() + "年");
            }

            this.cmbYear.SelectedIndex = 0;
        }

        private async void LoadSummaryData(int year)
        {
            var task = Task.Run(() =>
            {
                var data = BusinessFactory<RepairRecordBusiness>.Instance.FindBySummary(this.modelType, year);
                return data.ToList();
            });

            var result = await task;
            this.summaryGrid.DataSource = result;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="modelType">模型类型</param>
        public void Init(string modelType)
        {
            this.modelType = modelType;
            this.nowYear = DateTime.Now.Year;

            InitControls();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 年度选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbYear.SelectedIndex == -1)
                return;

            int year = Convert.ToInt32(this.cmbYear.SelectedItem.ToString().Substring(0, 4));

            LoadSummaryData(year);
        }
        #endregion //Event
    }
}
