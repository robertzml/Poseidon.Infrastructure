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
    using Poseidon.Core.BL;
    using Poseidon.Winform.Base;
    using Poseidon.Infrastructure.Core.Utility;

    /// <summary>
    /// 电梯管理窗体
    /// </summary>
    public partial class FrmElevatorManage : BaseMdiForm
    {
        #region Constructor
        public FrmElevatorManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            var groups = BusinessFactory<GroupBusiness>.Instance.FindByModelType(ModelTypeCode.Elevator);
            var codes = groups.Where(r => string.IsNullOrEmpty(r.ParentId)).Select(s => s.Code);

            this.elevatorTree.SetGroupCodes(codes.ToArray(), true);

            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 分组选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void elevatorTree_GroupSelected(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.navFrame.SelectedPageIndex = 1;
            this.elevatorBatchMod.Init();

           this.ResumeLayout();
        }

        /// <summary>
        /// 电梯选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void elevatorTree_EntitySelected(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.navFrame.SelectedPageIndex = 0;
           
            var id = this.elevatorTree.GetCurrentSelectId();
            this.elevatorReceiptMod.SetElevator(id);

            this.ResumeLayout();
        }
        #endregion //Event
    }
}
