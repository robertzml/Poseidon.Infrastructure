﻿using System;
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
    /// 添加检验记录
    /// </summary>
    public partial class FrmInspectionAdd : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联设施
        /// </summary>
        private Facility currentFacility;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 添加检验记录
        /// </summary>
        /// <param name="facilityId">设施ID</param>
        public FrmInspectionAdd(string facilityId)
        {
            InitializeComponent();

            InitData(facilityId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string facilityId)
        {
            this.currentFacility = BusinessFactory<FacilityBusiness>.Instance.FindById(facilityId);
        }

        protected override void InitForm()
        {
            this.txtFacilityName.Text = this.currentFacility.Name;

            var type = InspectionBusiness.GetInspectionType(this.currentFacility.ModelType);
            ControlUtil.BindDictToComboBox(this.cmbType, type, "Type");
            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (this.cmbType.EditValue == null)
            {
                errorMessage = "请选择检验类型";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpPlanDate.EditValue == null)
            {
                errorMessage = "请选择计划日期";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        private void SetEntity(Inspection entity)
        {
            entity.FacilityId = this.currentFacility.Id;
            entity.FacilityName = this.currentFacility.Name;
            entity.ModelType = this.currentFacility.ModelType;
            entity.Type = Convert.ToInt32(this.cmbType.EditValue);
            entity.PlanDate = this.dpPlanDate.DateTime;

            if (this.dpInspectionDate.EditValue != null)
            {
                entity.InspectionDate = this.dpInspectionDate.DateTime;
            }

            entity.InspectionFee = this.spInspectionFee.Value;
            entity.InspectionCompany = this.txtInspectionCompany.Text;
            entity.InspectionResult = this.txtInspectionResult.Text;
            entity.IsDone = this.chkIsDone.Checked;
            
            entity.Remark = this.txtRemark.Text;
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
            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                Inspection entity = new Inspection();
                SetEntity(entity);

                BusinessFactory<InspectionBusiness>.Instance.Create(entity, this.currentUser);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("新增检验信息失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
