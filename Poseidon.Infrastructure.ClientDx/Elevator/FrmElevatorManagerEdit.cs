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
    /// 编辑电梯管理员窗体
    /// </summary>
    public partial class FrmElevatorManagerEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 关联电梯管理员
        /// </summary>
        private ElevatorManager currentManager;

        /// <summary>
        /// 关联电梯
        /// </summary>
        private Elevator currentElevator;
        #endregion //Field

        #region Constructor
        public FrmElevatorManagerEdit(ElevatorManager manager)
        {
            InitializeComponent();

            InitData(manager);
        }
        #endregion //Constructor

        #region Function
        protected void InitData(ElevatorManager manager)
        {
            this.currentManager = manager;
            this.currentElevator = BusinessFactory<ElevatorBusiness>.Instance.FindById(this.currentManager.ElevatorId);
        }

        protected override void InitForm()
        {
            this.txtElevatorName.Text = currentElevator.Name;
            this.txtName.Text = this.currentManager.Name;
            this.txtTelephone.Text = this.currentManager.Telephone;
            this.dpStartDate.DateTime = this.currentManager.StartDate;

            if (this.currentManager.EndDate != null)
                this.dpEndDate.DateTime = this.currentManager.EndDate.Value;

            this.txtRemark.Text = this.currentManager.Remark;

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
                errorMessage = "姓名不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpStartDate.EditValue == null)
            {
                errorMessage = "请选择开始日期";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(ElevatorManager entity)
        {
            entity.ElevatorId = this.currentElevator.Id;
            entity.Name = this.txtName.Text;
            entity.Telephone = this.txtTelephone.Text;
            entity.StartDate = this.dpStartDate.DateTime;

            if (this.dpEndDate.EditValue == null)
                entity.EndDate = null;
            else
                entity.EndDate = this.dpEndDate.DateTime;

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
                SetEntity(this.currentManager);

                BusinessFactory<ElevatorBusiness>.Instance.EditManager(this.currentElevator.Id, currentManager);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("编辑电梯管理员失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
