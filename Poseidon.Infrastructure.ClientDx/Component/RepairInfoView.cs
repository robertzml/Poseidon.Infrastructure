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
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Finance.Utility;
    using Poseidon.Core.Utility;

    /// <summary>
    /// 维修改造信息控件
    /// </summary>
    public partial class RepairInfoView : BaseExpenseControl
    {
        #region Field
        /// <summary>
        /// 关联维修改造
        /// </summary>
        private Repair currentRepair;
        #endregion //Field

        #region Constructor
        public RepairInfoView()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 显示信息
        /// </summary>
        private void Display()
        {
            //this.txtFacilityName.Text = this.currentRepair.FacilityName;
            this.txtConstructionCompany.Text = this.currentRepair.ConstructionCompany;
            this.txtRepairFee.Text = this.currentRepair.RepairFee.ToString();
            this.txtStartDate.Text = this.currentRepair.StartDate.ToDateString();

            if (this.currentRepair.EndDate != null)
                this.txtEndDate.Text = this.currentRepair.EndDate.Value.ToDateString();

            this.txtRemark.Text = this.currentRepair.Remark;

            //var type = RepairBusiness.GetRepairType(this.currentRepair.ModelType);
            //this.txtType.Text = DictUtility.GetDictValue(type, "Type", currentRepair.Type);

            var repairRecords = BusinessFactory<RepairRecordBusiness>.Instance.FindByRepair(currentRepair.Id).ToList();
            this.recordGrid.DataSource = repairRecords;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="repair">维修改造信息</param>
        public void Init(Repair repair)
        {
            this.currentRepair = repair;
            if (repair != null)
                this.Display();
            else
                this.Clear();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="documentId">维修改造ID</param>
        public override void Init(string documentId)
        {
            this.currentRepair = BusinessFactory<RepairBusiness>.Instance.FindById(documentId);
            if (currentRepair != null)
                this.Display();
            else
                this.Clear();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.txtFacilityName.Text = "";
            this.txtConstructionCompany.Text = "";
            this.txtRepairFee.Text = "";
            this.txtStartDate.Text = "";
            this.txtEndDate.Text = "";
            this.txtType.Text = "";
            this.txtRemark.Text = "";

            this.recordGrid.Clear();
        }
        #endregion //Method
    }
}
