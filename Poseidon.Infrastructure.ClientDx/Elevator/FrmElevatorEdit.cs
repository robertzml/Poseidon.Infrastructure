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
    /// 编辑电梯
    /// </summary>
    public partial class FrmElevatorEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联电梯
        /// </summary>
        private Elevator currentElevator;
        #endregion //Field

        #region Constructor
        public FrmElevatorEdit(string id)
        {
            InitializeComponent();

            InitData(id);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="id"></param>
        private void InitData(string id)
        {
            this.currentElevator = BusinessFactory<ElevatorBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.txtName.Text = this.currentElevator.Name;
            this.txtModel.Text = this.currentElevator.Model;
            this.dpInstallDate.DateTime = this.currentElevator.InstallDate;
            this.txtRegistrationNumber.Text = this.currentElevator.RegistrationNumber;
            this.txtRescueNumber.Text = this.currentElevator.RescueNumber;
            this.txtPosition.Text = this.currentElevator.Position;
            this.spSpeed.Value = Convert.ToDecimal(this.currentElevator.Speed);
            this.txtStation.Text = this.currentElevator.Station;
            this.spCapacity.Value = this.currentElevator.Capacity;
            this.txtVendor.Text = this.currentElevator.Vendor;
            this.txtRecordBag.Text = this.currentElevator.RecordBag;
            this.txtRecordNumber.Text = this.currentElevator.RecordNumber;
            this.txtDatasetCode.Text = this.currentElevator.DatasetCode;
            this.txtRemark.Text = this.currentElevator.Remark;

            base.InitForm();
        }

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
                Elevator entity = BusinessFactory<ElevatorBusiness>.Instance.FindById(this.currentElevator.Id);
                SetEntity(entity);

                var result = BusinessFactory<ElevatorBusiness>.Instance.Update(entity);

                if (result.success)
                {
                    MessageUtil.ShowInfo("保存成功");
                    this.Close();
                }
                else
                {
                    MessageUtil.ShowClaim("保存失败: " + result.errorMessage);
                }
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("更新电梯失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
