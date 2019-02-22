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
    /// 批量设置维保公司
    /// </summary>
    public partial class FrmMaintenanceInfoBatch : BaseSingleForm
    {
        #region Constructor
        public FrmMaintenanceInfoBatch()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.maintenanceInfoGrid.DataSource = new List<MaintenanceInfo>();
            this.maintenanceInfoGrid.Init();

            this.bsMaintenanceCompany.DataSource = BusinessFactory<MaintenanceCompanyBusiness>.Instance.FindAll();

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private (bool success, string errorMessage) CheckInput()
        {
            foreach (var item in this.maintenanceInfoGrid.DataSource)
            {
                if (string.IsNullOrEmpty(item.FacilityId))
                {
                    return (false, "请选择设施");
                }
                if (string.IsNullOrEmpty(item.MaintenanceCompanyId))
                {
                    return (false, "请选择维保公司");
                }
                if (item.StartDate == null || item.StartDate == DateTime.MinValue)
                {
                    return (false, "请选择开始日期");
                }
                if (item.EndDate == null || item.StartDate == DateTime.MinValue)
                {
                    return (false, "请选择结束日期");
                }
            }

            return (true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(List<MaintenanceInfo> data)
        {
            var companys = this.bsMaintenanceCompany.DataSource as List<MaintenanceCompany>;

            foreach (var item in data)
            {
                var com = companys.Find(r => r.Id == item.MaintenanceCompanyId);
                item.MaintenanceCompanyName = com.Name;
                item.Remark = item.Remark ?? "";
            }
        }
        #endregion //Funtion

        #region Event
        /// <summary>
        /// 设置维保公司
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luMaintenanceCompany_EditValueChanged(object sender, EventArgs e)
        {
            this.maintenanceInfoGrid.DataSource.ForEach(r =>
            {
                if (this.luMaintenanceCompany.EditValue == null)
                    r.MaintenanceCompanyId = null;
                else
                    r.MaintenanceCompanyId = this.luMaintenanceCompany.EditValue.ToString();
            });

            this.maintenanceInfoGrid.UpdateBindingData();
        }

        /// <summary>
        /// 设置维保费用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void spMaintenanceFee_EditValueChanged(object sender, EventArgs e)
        {
            this.maintenanceInfoGrid.DataSource.ForEach(r =>
            {
                r.MaintenanceFee = this.spMaintenanceFee.Value;
            });

            this.maintenanceInfoGrid.UpdateBindingData();
        }

        /// <summary>
        /// 设置开始日期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpStart_EditValueChanged(object sender, EventArgs e)
        {
            this.maintenanceInfoGrid.DataSource.ForEach(r =>
            {
                r.StartDate = this.dpStart.DateTime;
            });

            this.maintenanceInfoGrid.UpdateBindingData();
        }

        /// <summary>
        /// 设置结束日期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpEnd_EditValueChanged(object sender, EventArgs e)
        {
            this.maintenanceInfoGrid.DataSource.ForEach(r =>
            {
                r.EndDate = this.dpEnd.DateTime;
            });

            this.maintenanceInfoGrid.UpdateBindingData();
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.maintenanceInfoGrid.CloseEditor();
            var result = CheckInput();
            if (!result.success)
            {
                MessageUtil.ShowError(result.errorMessage);
                return;
            }

            try
            {
                var data = this.maintenanceInfoGrid.DataSource;
                SetEntity(data);

                foreach (var item in data)
                {
                    BusinessFactory<MaintenanceInfoBusiness>.Instance.Create(item, this.currentUser);
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
        #endregion //Event
    }
}
