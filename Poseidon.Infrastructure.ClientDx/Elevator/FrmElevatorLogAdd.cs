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
    using Poseidon.Winform.Core.Utility;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 添加电梯运行日志窗体
    /// </summary>
    public partial class FrmElevatorLogAdd : BaseSingleForm
    {
        #region Constructor
        public FrmElevatorLogAdd()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            ControlUtil.BindDictToComboBox(this.cmbLogType, typeof(ElevatorLog), "LogType");

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (this.cmbLogType.EditValue == null)
            {
                errorMessage = "请选择事件类型";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpLogDate.EditValue == null)
            {
                errorMessage = "请选择日期";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity">实体对象</param>
        private void SetEntity(ElevatorLog entity)
        {
            // entity.Number = this.txtNumber.Text;
            //entity.LogDate = this.dpLogDate.DateTime;
            entity.LogType = Convert.ToInt32(this.cmbLogType.EditValue);
            entity.Info = this.txtInfo.Text;
            entity.Remark = "";
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
                ElevatorLog entity = new ElevatorLog();
                SetEntity(entity);

                BusinessFactory<ElevatorLogBusiness>.Instance.Create(entity, this.currentUser);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                Logger.Instance.Exception("新增日志失败", pe);
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
