﻿using System;
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
        /// 根据维修改造查找记录
        /// </summary>
        /// <param name="repairId">维修改造ID</param>
        /// <returns></returns>
        public IEnumerable<RepairRecord> FindByRepair(string repairId)
        {
            return this.baseDal.FindListByField("repairId", repairId);
        }

        /// <summary>
        /// 添加一组维修改造记录
        /// </summary>
        /// <param name="repair">维修改造对象</param>
        /// <param name="records">维修改造记录</param>
        /// <param name="user">操作用户</param>
        public void CreateMany(Repair repair, List<RepairRecord> records, ILoginUser user)
        {
            var now = DateTime.Now;
            foreach (var item in records)
            {
                item.RepairId = repair.Id;
                item.Status = 0;

                item.CreateBy = new UpdateStamp
                {
                    UserId = user.Id,
                    Name = user.Name,
                    Time = now
                };
                item.UpdateBy = new UpdateStamp
                {
                    UserId = user.Id,
                    Name = user.Name,
                    Time = now
                };

                this.baseDal.Create(item);
            }
        }

        /// <summary>
        /// 更新维修改造记录
        /// </summary>
        /// <param name="repair">维修改造对象</param>
        /// <param name="records">维修改造记录</param>
        public void Update(Repair repair, List<RepairRecord> records, ILoginUser user)
        {
            this.baseDal.DeleteMany("repairId", repair.Id);

            foreach (var item in records)
            {
                item.RepairId = repair.Id;
                item.Status = 0;
                this.baseDal.Create(item);
            }
        }

        /// <summary>
        /// 删除维修改造相关记录
        /// </summary>
        /// <param name="repairId">维修改造ID</param>
        public void DeleteByRepair(string repairId)
        {
            this.baseDal.DeleteMany("repairId", repairId);
        }
        #endregion //CRUD
    }
}
