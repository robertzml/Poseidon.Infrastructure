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
    /// 添加管理员窗体
    /// </summary>
    public partial class FrmElevatorManagerAdd : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 关联电梯ID
        /// </summary>
        private Elevator currentElevator;
        #endregion //Field

        #region Constructor
        public FrmElevatorManagerAdd(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentElevator = BusinessFactory<ElevatorBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.txtElevatorName.Text = this.currentElevator.Name;
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
                ElevatorManager entity = new ElevatorManager();
                SetEntity(entity);

                var managers = this.currentElevator.Managers;
                managers.Add(entity);

                managers = managers.OrderByDescending(r => r.StartDate).ToList();

                BusinessFactory<ElevatorBusiness>.Instance.SetManagers(this.currentElevator.Id, managers);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("新增电梯管理员失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
