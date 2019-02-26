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
    using Poseidon.Winform.Base;
    using Poseidon.Winform.Core.Utility;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.Utility;

    /// <summary>
    /// 批量添加检验计划
    /// </summary>
    public partial class FrmInspectionBatch : BaseSingleForm
    {
        #region Constructor
        public FrmInspectionBatch()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            var type = InspectionBusiness.GetInspectionType(ModelTypeCode.Elevator);
            ControlUtil.BindDictToComboBox(this.cmbInspectionType, type, "Type");

            this.inspectionGrid.DataSource = new List<Inspection>();
            this.inspectionGrid.Init(ModelTypeCode.Elevator);

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private (bool success, string errorMessage) CheckInput()
        {
            foreach (var item in this.inspectionGrid.DataSource)
            {
                if (string.IsNullOrEmpty(item.FacilityId))
                {
                    return (false, "请选择设施");
                }
                if (item.Type == 0)
                {
                    return (false, "请选择检验类型");
                }
                if (item.PlanDate == null || item.PlanDate == DateTime.MinValue)
                {
                    return (false, "请选择计划日期");
                }
            }

            return (true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(List<Inspection> data)
        {
            foreach (var item in data)
            {
                item.ModelType = ModelTypeCode.Elevator;
                item.IsDone = false;
                item.InspectionResult = "";
                item.Remark = item.Remark ?? "";
            }
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 设置检验类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbInspectionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.inspectionGrid.DataSource.ForEach(r =>
            {
                var type = Convert.ToInt32(this.cmbInspectionType.EditValue);
                r.Type = type;
            });

            this.inspectionGrid.UpdateBindingData();
        }

        /// <summary>
        /// 设置计划时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpPlanDate_EditValueChanged(object sender, EventArgs e)
        {
            this.inspectionGrid.DataSource.ForEach(r =>
            {
                r.PlanDate = this.dpPlanDate.DateTime;
            });

            this.inspectionGrid.UpdateBindingData();
        }

        /// <summary>
        /// 设置检验费用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spInspectionFee_EditValueChanged(object sender, EventArgs e)
        {
            this.inspectionGrid.DataSource.ForEach(r =>
            {
                r.InspectionFee = this.spInspectionFee.Value;
            });

            this.inspectionGrid.UpdateBindingData();
        }

        /// <summary>
        /// 设置检验单位
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInspectionCompany_EditValueChanged(object sender, EventArgs e)
        {
            this.inspectionGrid.DataSource.ForEach(r =>
            {
                r.InspectionCompany = this.txtInspectionCompany.Text;
            });

            this.inspectionGrid.UpdateBindingData();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.inspectionGrid.CloseEditor();
            var result = CheckInput();
            if (!result.success)
            {
                MessageUtil.ShowError(result.errorMessage);
                return;
            }

            try
            {
                var data = this.inspectionGrid.DataSource;
                SetEntity(data);

                foreach (var item in data)
                {
                    BusinessFactory<InspectionBusiness>.Instance.Create(item, this.currentUser);
                }

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("新增维保信息失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }

        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion //Event
    }
}
