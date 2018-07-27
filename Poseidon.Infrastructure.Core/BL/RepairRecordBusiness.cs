using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.IDAL;
    using Poseidon.Finance.Core.BL;
    using Poseidon.Finance.Core.Utility;

    /// <summary>
    /// 维修改造记录业务类
    /// </summary>
    public class RepairRecordBusiness : AbstractBusiness<RepairRecord>, IBaseBL<RepairRecord>
    {
        #region Constructor
        /// <summary>
        /// 维修改造记录业务类
        /// </summary>
        public RepairRecordBusiness()
        {
            this.baseDal = RepositoryFactory<IRepairRecordRepository>.Instance;
        }
        #endregion //Constructor

        #region CRUD
        /// <summary>
        /// 添加一组维修改造记录
        /// </summary>
        /// <param name="repair">维修改造对象</param>
        /// <param name="records">维修改造记录</param>
        public void CreateMany(Repair repair, List<RepairRecord> records)
        {
            foreach (var item in records)
            {
                item.RepairId = repair.Id;
                item.Status = 0;

                base.Create(item);
            }
        }
        #endregion //CRUD
    }
}
