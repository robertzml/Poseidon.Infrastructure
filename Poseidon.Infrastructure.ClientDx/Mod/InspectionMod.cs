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
    using Poseidon.Base.Framework;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;

    /// <summary>
    /// 设施检验模块
    /// </summary>
    public partial class InspectionMod : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联设施
        /// </summary>
        private Facility currentFacility;
        #endregion //Field

        #region Constructor
        public InspectionMod()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入设施对象
        /// </summary>
        /// <param name="id">设施ID</param>
        private void LoadFacility(string id)
        {
            this.currentFacility = BusinessFactory<FacilityBusiness>.Instance.FindById(id);
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置设施
        /// </summary>
        /// <param name="id">设施ID</param>
        public void SetFacility(string id)
        {
            LoadFacility(id);
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 添加检验信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
        #endregion //Event
    }
}
