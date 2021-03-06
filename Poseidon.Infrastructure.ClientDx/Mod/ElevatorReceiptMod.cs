﻿using System;
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
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 电梯管理模块
    /// </summary>
    public partial class ElevatorReceiptMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联电梯
        /// </summary>
        private Elevator currentElevator;
        #endregion //Field

        #region Constructor
        public ElevatorReceiptMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入电梯对象
        /// </summary>
        /// <param name="id">电梯ID</param>
        private void LoadElevator(string id)
        {
            this.currentElevator = BusinessFactory<ElevatorBusiness>.Instance.FindById(id);
        }

        /// <summary>
        /// 显示电梯基本信息
        /// </summary>
        private void DisplayInfo()
        {
            this.elevatorInfoView.SetElevator(currentElevator);
            this.elevatorManagerMod.SetElevator(currentElevator);
            this.maintenanceInfoMod.SetElevator(currentElevator);
        }

        /// <summary>
        /// 显示电梯运行日志
        /// </summary>
        private void DisplayBusiness()
        {
            this.elevatorLogMod.SetElevator(currentElevator.Id);
            this.insMod.SetFacility(currentElevator.Id);
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置电梯
        /// </summary>
        /// <param name="id">电梯ID</param>
        public void SetElevator(string id)
        {
            LoadElevator(id);

            DisplayInfo();
            DisplayBusiness();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.elevatorInfoView.Clear();
            this.elevatorManagerMod.Clear();
            this.maintenanceInfoMod.Clear();

            this.elevatorLogMod.Clear();
            this.insMod.Clear();
        }
        #endregion //Method

        #region Event
        #endregion //Event
    }
}
