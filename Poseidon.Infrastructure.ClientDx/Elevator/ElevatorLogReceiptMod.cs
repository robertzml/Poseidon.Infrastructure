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
    /// 电梯日志查看模块
    /// </summary>
    public partial class ElevatorLogReceiptMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联电梯
        /// </summary>
        private Elevator currentElevator;
        #endregion //Field

        #region Constructor
        public ElevatorLogReceiptMod()
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

            var data = BusinessFactory<ElevatorLogBusiness>.Instance.FindByElevator(id);
            this.logGrid.DataSource = data.ToList();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置电梯
        /// </summary>
        /// <param name="id">电梯ID</param>
        public void SetElevator(string id)
        {
            this.logGrid.Init();

            LoadElevator(id);
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.logGrid.Clear();
        }
        #endregion //Method
    }
}
