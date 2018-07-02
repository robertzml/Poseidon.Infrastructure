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
    /// 电梯基本信息组件
    /// </summary>
    public partial class ElevatorInfoView : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 关联电梯
        /// </summary>
        private Elevator currentElevator;
        #endregion //Field

        #region Constructor
        public ElevatorInfoView()
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
            this.txtName.Text = this.currentElevator.Name;
            this.txtModel.Text = this.currentElevator.Model;
            this.txtInstallDate.Text = this.currentElevator.InstallDate.ToString("yyyy-MM");
            this.txtRegistrationNumber.Text = this.currentElevator.RegistrationNumber;
            this.txtRescueNumber.Text = this.currentElevator.RescueNumber;
            this.txtPosition.Text = this.currentElevator.Position;
            this.txtSpeed.Text = this.currentElevator.Speed.ToString();
            this.txtStation.Text = this.currentElevator.Station;
            this.txtCapacity.Text = this.currentElevator.Capacity.ToString();
            this.txtVendor.Text = this.currentElevator.Vendor;
            this.txtRecordBag.Text = this.currentElevator.RecordBag;
            this.txtRecordNumber.Text = this.currentElevator.RecordNumber;
            this.txtDatasetCode.Text = this.currentElevator.DatasetCode;
            this.txtStatus.Text = ((EntityStatus)currentElevator.Status).DisplayName();
            this.txtRemark.Text = this.currentElevator.Remark;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置电梯
        /// </summary>
        /// <param name="elevator">电梯</param>
        public void SetElevator(Elevator elevator)
        {
            this.currentElevator = elevator;
            if (elevator != null)
                this.Display();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.txtName.Text = "";
            this.txtModel.Text = "";
            this.txtInstallDate.Text = "";
            this.txtRegistrationNumber.Text = "";
            this.txtRescueNumber.Text = "";
            this.txtPosition.Text = "";
            this.txtSpeed.Text = "";
            this.txtStation.Text = "";
            this.txtCapacity.Text = "";
            this.txtVendor.Text = "";
            this.txtRecordBag.Text = "";
            this.txtRecordNumber.Text = "";
            this.txtDatasetCode.Text = "";
            this.txtStatus.Text = "";
            this.txtRemark.Text = "";
        }
        #endregion //Method
    }
}
