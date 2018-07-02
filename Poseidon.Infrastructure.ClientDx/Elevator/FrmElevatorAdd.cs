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
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 添加电梯
    /// </summary>
    public partial class FrmElevatorAdd : BaseSingleForm
    {
        #region Constructor
        public FrmElevatorAdd()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorMessage = "名称不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpInstallDate.EditValue == null)
            {
                errorMessage = "请选择安装日期";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Elevator entity)
        {
            entity.Name = this.txtName.Text;
            entity.Model = this.txtModel.Text;
            entity.InstallDate = this.dpInstallDate.DateTime;
            entity.RegistrationNumber = this.txtRegistrationNumber.Text;
            entity.RescueNumber = this.txtRescueNumber.Text;
            entity.Capacity = Convert.ToInt32(this.spCapacity.Value);
            entity.Speed = Convert.ToDouble(this.spSpeed.Value);
            entity.Station = this.txtStation.Text;
            entity.Vendor = this.txtVendor.Text;
            entity.Position = this.txtPosition.Text;
            entity.RecordBag = this.txtRecordBag.Text;
            entity.RecordNumber = this.txtRecordNumber.Text;
            entity.DatasetCode = this.txtDatasetCode.Text;
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
                Elevator entity = new Elevator();
                SetEntity(entity);

                BusinessFactory<ElevatorBusiness>.Instance.Create(entity);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("新增电梯失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
