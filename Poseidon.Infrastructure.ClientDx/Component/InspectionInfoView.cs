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
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 检验信息控件
    /// </summary>
    public partial class InspectionInfoView : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 关联电梯
        /// </summary>
        private Inspection currentInspection;
        #endregion //Field

        #region Constructor
        public InspectionInfoView()
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
            this.txtFacilityName.Text = this.currentInspection.FacilityName;
            //this.txtType.Text = 
            this.txtPlanDate.Text = this.currentInspection.PlanDate.ToDateString();
            this.txtInspectionDate.Text = this.currentInspection.InspectionDate.ToDateString();
            this.txtInspectionCompany.Text = this.currentInspection.InspectionCompany;
            this.txtInspectionFee.Text = this.currentInspection.InspectionFee.ToString();
            this.chkIsDone.Checked = this.currentInspection.IsDone;
            this.txtInspectionResult.Text = this.currentInspection.InspectionResult;
            this.txtRemark.Text = this.currentInspection.Remark;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="elevator">电梯</param>
        public void Init(Inspection inspection)
        {
            this.currentInspection = inspection;
            if (inspection != null)
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
            this.txtType.Text = "";
            this.txtPlanDate.Text = "";
            this.txtInspectionDate.Text = "";
            this.txtInspectionCompany.Text = "";
            this.txtInspectionFee.Text = "";
            this.chkIsDone.Checked = false;
            this.txtInspectionResult.Text = "";
            this.txtRemark.Text = "";
        }
        #endregion //Method
    }
}
