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
    using Poseidon.Winform.Base;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.Utility;

    /// <summary>
    /// 电梯列表
    /// </summary>
    public partial class FrmElevatorList : BaseMdiForm
    {
        #region Constructor
        public FrmElevatorList()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadData();

            base.InitForm();
        }

        /// <summary>
        /// 载入电梯数据
        /// </summary>
        private void LoadData()
        {
            this.elevatorGrid.DataSource = BusinessFactory<ElevatorBusiness>.Instance.FindAll().ToList();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 添加电梯
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmElevatorAdd));
            LoadData();
        }

        /// <summary>
        /// 编辑电梯
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            var elevator = this.elevatorGrid.GetCurrentSelect();
            if (elevator == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmElevatorEdit), new object[] { elevator.Id });
            LoadData();
        }
        #endregion //Event
    }
}
