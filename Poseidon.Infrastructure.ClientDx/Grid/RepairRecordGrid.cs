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
    using Poseidon.Winform.Base;
    using Poseidon.Infrastructure.Core.DL;

    /// <summary>
    /// 维修改造记录表格控件
    /// </summary>
    public partial class RepairRecordGrid : WinEntityGrid<RepairRecord>
    {
        #region Field
        /// <summary>
        /// 使用计算总价列
        /// </summary>
        private bool useCalculatePrice = false;

        /// <summary>
        /// 使用设施名称列
        /// </summary>
        private bool useFacilityName = false;

        /// <summary>
        /// 模型类型代码
        /// </summary>
        private string modelType;
        #endregion //Field

        #region Constructor
        public RepairRecordGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="modelType">模型类型</param>
        public void Init(string modelType)
        {
            this.modelType = modelType;
            var facilities = BusinessFactory<FacilityBusiness>.Instance.FindByModelType(modelType);

            this.bsFacility.DataSource = facilities;
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RepairRecordGrid_Load(object sender, EventArgs e)
        {
            this.colCalculatePrice.Visible = this.useCalculatePrice;
            this.colTotalPrice.Visible = !this.useCalculatePrice;

            this.colFacilityId.Visible = !this.useFacilityName;
            this.colFacilityName.Visible = this.useFacilityName;
        }

        /// <summary>
        /// 设施选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            int bsIndex = this.dgvEntity.GetDataSourceRowIndex(e.RowHandle);
            if (bsIndex < 0 || bsIndex >= this.bsEntity.Count)
                return;

            var record = this.bsEntity[bsIndex] as RepairRecord;

            if (e.Column.FieldName == "FacilityId")
            {
                var id = e.Value.ToString();

                var list = this.bsFacility.DataSource as List<Facility>;
                var fac = list.Find(r => r.Id == id);

                record.FacilityName = fac.Name;
            }
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 使用计算总价列
        /// </summary>
        [Description("使用计算总价列"), Category("界面")]
        public bool UseCalculatePrice
        {
            get
            {
                return useCalculatePrice;
            }

            set
            {
                useCalculatePrice = value;
            }
        }

        /// <summary>
        /// 使用设施名称列
        /// </summary>
        [Description("使用设施名称列"), Category("界面")]
        public bool UseFacilityName
        {
            get
            {
                return useFacilityName;
            }

            set
            {
                useFacilityName = value;
            }
        }
        #endregion //Property
    }
}