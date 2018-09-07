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
    using Poseidon.Infrastructure.Core.BL;
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
        /// 是否显示维修改造序号列
        /// </summary>
        private bool showColRepairNumber = false;

        /// <summary>
        /// 模型类型代码
        /// </summary>
        private string modelType;

        /// <summary>
        /// 缓存维修改造项目
        /// </summary>
        private List<Repair> repairs = new List<Repair>();
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
        /// <remarks>
        /// 编辑状态下必须调用该初始化方法
        /// </remarks>
        public void Init(string modelType)
        {
            this.modelType = modelType;
            var facilities = BusinessFactory<FacilityBusiness>.Instance.FindByModelType(modelType);

            this.bsFacility.DataSource = facilities;
        }

        /// <summary>
        /// 初始化
        /// </summary>
        /// <remarks>
        /// 显示维修改造项目调用该初始化方法
        /// </remarks>
        public void Init()
        {
            this.repairs = BusinessFactory<RepairBusiness>.Instance.FindAll().ToList();
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
            this.colRepairNumber.Visible = this.showColRepairNumber;
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

        /// <summary>
        /// 自定义数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsEntity.Count)
                return;

            var record = this.bsEntity[rowIndex] as RepairRecord;
            if (this.showColRepairNumber && e.Column.FieldName == "colRepairNumber" && e.IsGetData)
            {
                var repair = this.repairs.SingleOrDefault(r => r.Id == record.RepairId);
                if (repair != null)
                {
                    e.Value = repair.Number;
                }
                else
                {
                    repair = BusinessFactory<RepairBusiness>.Instance.FindById(record.RepairId);
                    e.Value = repair.Number;
                }
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

        /// <summary>
        /// 是否显示维修改造序号列
        /// </summary>
        [Description("是否显示维修改造序号列"), Category("界面")]
        public bool ShowColRepairNumber
        {
            get
            {
                return showColRepairNumber;
            }

            set
            {
                showColRepairNumber = value;
            }
        }
        #endregion //Property
    }
}