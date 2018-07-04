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
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 添加检修记录
    /// </summary>
    public partial class FrmInspectionAdd : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联设施
        /// </summary>
        private Facility currentFacility;

        /// <summary>
        /// 设施类型
        /// </summary>
        private string modelType;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 添加检修记录
        /// </summary>
        /// <param name="facilityId">设施ID</param>
        /// <param name="modelType">设施类型</param>
        public FrmInspectionAdd(string facilityId, string modelType)
        {
            InitializeComponent();

            InitData(facilityId, modelType);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string facilityId, string modelType)
        {
            this.currentFacility = BusinessFactory<FacilityBusiness>.Instance.FindById(facilityId);
            this.modelType = modelType;
        }

        protected override void InitForm()
        {
            this.txtFacilityName.Text = this.currentFacility.Name;
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

        }
        #endregion //Event
    }
}
