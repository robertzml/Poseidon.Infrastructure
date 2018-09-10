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
    /// 维修改造记录模块
    /// </summary>
    public partial class RepairRecordMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public RepairRecordMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 汇总统计
        /// </summary>
        private void LoadRepairRecordSummary()
        {
            this.recordSummaryMod.Init(ModelTypeCode.Elevator);
        }


        private void LoadRepairRecords(string modelType = "")
        {
            this.repairRecordGrid.Init();

            List<RepairRecord> data;

            if (string.IsNullOrEmpty(modelType))
            {
                data = BusinessFactory<RepairRecordBusiness>.Instance.FindAll().ToList();
            }
            else
            {
                data = BusinessFactory<RepairRecordBusiness>.Instance.FindByModelType(modelType).ToList();
            }
            this.repairRecordGrid.DataSource = data;
        }
        #endregion //Function

        #region Method
        public void Init()
        {
            LoadRepairRecords();
            LoadRepairRecordSummary();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 菜单选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accordionControl1_ElementClick(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            if (e.Element.Tag == null)
                return;
            
            var tag = e.Element.Tag.ToString();

            LoadRepairRecords(tag);
        }
        #endregion //Event
    }
}
