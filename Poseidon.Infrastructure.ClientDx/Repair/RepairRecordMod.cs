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
    using DevExpress.XtraBars.Navigation;
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
        /// 控件初始化
        /// </summary>
        private void InitControls()
        {
            int nowYear = DateTime.Now.Year;
            for (int i = nowYear; i >= InfrastructureConstant.StartYear; i--)
            {
                AccordionControlElement ele = new AccordionControlElement();
                ele.Style = ElementStyle.Item;
                ele.Text = i.ToString() + "年";
                ele.Tag = i;

                this.accGroupYear.Elements.Add(ele);
            }

            this.repairRecordGrid.Init();
        }

        /// <summary>
        /// 汇总统计
        /// </summary>
        private void LoadRepairRecordSummary()
        {
            this.recordSummaryMod.Init(ModelTypeCode.Elevator);
        }

        /// <summary>
        /// 按模型类型载入维修改造记录
        /// </summary>
        /// <param name="modelType"></param>
        private void LoadRecordsByModelType(string modelType = "")
        {
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

        /// <summary>
        /// 按年度载入改造记录
        /// </summary>
        /// <param name="year">年度</param>
        private void LoadRecordByYear(int year)
        {
            var data = BusinessFactory<RepairRecordBusiness>.Instance.FindByYear(year).ToList();
            this.repairRecordGrid.DataSource = data;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            InitControls();

            LoadRepairRecordSummary();
            LoadRecordsByModelType();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.repairRecordGrid.Clear();
            this.repairInfoView.Clear();
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

            var owner = e.Element.OwnerElement;
            if (owner.Equals(this.accGroupModelType))
            {
                var tag = e.Element.Tag.ToString();
                LoadRecordsByModelType(tag);
            }
            else if (owner.Equals(this.accGroupYear))
            {
                var tag = Convert.ToInt32(e.Element.Tag);
                LoadRecordByYear(tag);
            }
        }
        
        /// <summary>
        /// 维修改造记录选择
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void repairRecordGrid_RowSelected(object arg1, EventArgs arg2)
        {
            var record = this.repairRecordGrid.GetCurrentSelect();
            if (record == null)
            {
                this.repairInfoView.Clear();
                return;
            }

            this.repairInfoView.Init(record.RepairId);
        }
        #endregion //Event
    }
}
