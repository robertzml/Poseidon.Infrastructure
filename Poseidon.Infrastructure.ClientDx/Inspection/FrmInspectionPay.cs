using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Infrastructure.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;
    using Poseidon.Winform.Core.Utility;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 检验付款窗体
    /// </summary>
    public partial class FrmInspectionPay : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联设施
        /// </summary>
        private Facility currentFacility;

        /// <summary>
        /// 当前关联检验
        /// </summary>
        private Inspection currentInspection;
        #endregion //Field

        #region Constructor
        public FrmInspectionPay(string id)
        {
            InitializeComponent();

            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentInspection = BusinessFactory<InspectionBusiness>.Instance.FindById(id);

            this.currentFacility = BusinessFactory<FacilityBusiness>.Instance.FindById(currentInspection.FacilityId);
        }

        protected override void InitForm()
        {
            this.inspectionView.Init(this.currentInspection);

            string moduleName = typeof(InspectionInfoView).FullName;
            string assemblyName = typeof(InspectionInfoView).Assembly.GetName().Name;
            string collectionName = "infrastructure_inspection";
            string documentId = this.currentInspection.Id;

            this.expenseMod.Init(moduleName, assemblyName, collectionName, documentId, this.currentUser);
            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var input = this.expenseMod.CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                bool result = this.expenseMod.SaveData();

                if (result)
                {
                    MessageUtil.ShowInfo("保存成功");
                    this.Close();
                }
                else
                {
                    MessageUtil.ShowInfo("保存失败");
                }
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("新增检验用款信息失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
