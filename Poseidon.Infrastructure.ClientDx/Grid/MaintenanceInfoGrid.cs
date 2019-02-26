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
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;
    using Poseidon.Infrastructure.Core.BL;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 维保信息表格控件
    /// </summary>
    public partial class MaintenanceInfoGrid : WinEntityGrid<MaintenanceInfo>
    {
        #region Constructor
        public MaintenanceInfoGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 初始化
        /// 在需要编辑时调用
        /// </summary>
        public void Init()
        {
            this.bsElevator.DataSource = BusinessFactory<ElevatorBusiness>.Instance.FindAll();
            this.bsMaintenanceCompany.DataSource = BusinessFactory<MaintenanceCompanyBusiness>.Instance.FindAll();
        }
        #endregion //Method

        #region Event
        private void MaintenanceInfoGrid_Load(object sender, EventArgs e)
        {
            this.colFacilityId.Visible = this.editable;
            this.colFacilityName.Visible = !this.editable;

            this.colMaintenanceCompanyId.Visible = this.editable;
            this.colMaintenanceCompanyName.Visible = !this.editable;
        }

        /// <summary>
        /// 单元格选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int bsIndex = this.dgvEntity.GetDataSourceRowIndex(e.RowHandle);
            if (bsIndex < 0 || bsIndex >= this.bsEntity.Count)
                return;

            var record = this.bsEntity[bsIndex] as MaintenanceInfo;

            if (e.Column.FieldName == "FacilityId" && e.Value != null)
            {
                var id = e.Value.ToString();

                var list = this.bsElevator.DataSource as List<Elevator>;
                var elevator = list.Find(r => r.Id == id);

                record.FacilityName = elevator.Name;
            }
        }
        #endregion //Event
    }
}
