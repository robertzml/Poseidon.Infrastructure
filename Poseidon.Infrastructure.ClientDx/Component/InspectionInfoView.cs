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

    /// <summary>
    /// 检验信息控件
    /// </summary>
    public partial class InspectionInfoView : BaseExpenseControl
    {
        #region Field
        /// <summary>
        /// 关联检验
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
            this.txtCreator.Text = this.currentInspection.CreateBy.Name;
            this.txtCreateTime.Text = this.currentInspection.CreateBy.Time.ToDateTimeString();
            this.txtEditor.Text = this.currentInspection.UpdateBy.Name;
            this.txtEditTime.Text = this.currentInspection.UpdateBy.Time.ToDateTimeString();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="inspection">检验信息</param>
        public void Init(Inspection inspection)
        {
            this.currentInspection = inspection;
            if (inspection != null)
                this.Display();
            else
                this.Clear();
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="documentId">检验ID</param>
        public override void Init(string documentId)
        {
            this.currentInspection = BusinessFactory<InspectionBusiness>.Instance.FindById(documentId);
            if (currentInspection != null)
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
            this.txtCreator.Text = "";
            this.txtCreateTime.Text = "";
            this.txtEditor.Text = "";
            this.txtEditTime.Text = "";
            this.txtRemark.Text = "";
        }
        #endregion //Method
    }
}
