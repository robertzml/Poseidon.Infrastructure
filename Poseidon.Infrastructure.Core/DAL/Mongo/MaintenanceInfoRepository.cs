using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Core.DAL.Mongo
{
    using MongoDB.Bson;
    using MongoDB.Driver;
    using Poseidon.Base.Framework;
    using Poseidon.Data;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.IDAL;

    /// <summary>
    /// 维保信息数据访问类
    /// </summary>
    internal class MaintenanceInfoRepository : AbstractDALMongo<MaintenanceInfo>, IMaintenanceInfoRepository
    {
        #region Constructor
        /// <summary>
        /// 维保信息数据访问类
        /// </summary>
        public MaintenanceInfoRepository()
        {
            base.Init("infrastructure_maintenanceInfo");
        }
        #endregion //Constructor

        #region Function
        protected override MaintenanceInfo DocToEntity(BsonDocument doc)
        {
            throw new NotImplementedException();
        }

        protected override BsonDocument EntityToDoc(MaintenanceInfo entity)
        {
            throw new NotImplementedException();
        }
        #endregion //Function
    }
}
