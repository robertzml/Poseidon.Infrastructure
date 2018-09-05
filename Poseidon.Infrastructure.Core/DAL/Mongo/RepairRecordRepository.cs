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
    /// 维修改造记录数据访问类
    /// </summary>
    internal class RepairRecordRepository : AbstractDALMongo<RepairRecord>, IRepairRecordRepository
    {
        #region Constructor
        /// <summary>
        /// 维修改造记录数据访问类
        /// </summary>
        public RepairRecordRepository()
        {
            base.Init("infrastructure_repairRecord");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override RepairRecord DocToEntity(BsonDocument doc)
        {
            RepairRecord entity = new RepairRecord();
            entity.Id = doc["_id"].ToString();
            entity.RepairId = doc["repairId"].ToString();
            entity.ModelType = doc["modelType"].ToString();
            entity.FacilityId = doc["facilityId"].ToString();
            entity.FacilityName = doc["facilityName"].ToString();
            entity.ItemName = doc["itemName"].ToString();
            entity.Specification = doc["specification"].ToString();
            entity.Count = doc["count"].ToDecimal();
            entity.Unit = doc["unit"].ToString();
            entity.UnitPrice = doc["unitPrice"].ToDecimal();
            entity.TotalPrice = doc["totalPrice"].ToDecimal();
            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(RepairRecord entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "repairId", entity.RepairId },
                { "modelType", entity.ModelType },
                { "facilityId", entity.FacilityId },
                { "facilityName", entity.FacilityName },
                { "itemName", entity.ItemName },
                { "specification", entity.Specification },
                { "count", entity.Count },
                { "unit", entity.Unit },
                { "unitPrice", entity.UnitPrice },
                { "totalPrice", entity.TotalPrice },
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            return doc;
        }
        #endregion //Function
    }
}
