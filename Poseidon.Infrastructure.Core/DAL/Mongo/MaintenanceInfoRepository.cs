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
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override MaintenanceInfo DocToEntity(BsonDocument doc)
        {
            MaintenanceInfo entity = new MaintenanceInfo();
            entity.Id = doc["_id"].ToString();
            entity.FacilityId = doc["facilityId"].ToString();
            entity.FacilityName = doc["facilityName"].ToString();
            entity.MaintenanceCompanyId = doc["maintenanceCompanyId"].ToString();
            entity.MaintenanceCompanyName = doc["maintenanceCompanyName"].ToString();
            entity.StartDate = doc["startDate"].ToLocalTime();
            entity.EndDate = doc["endDate"].ToLocalTime();
            entity.MaintenanceFee = doc["maintenanceFee"].ToDecimal();
            entity.IsFree = doc["isFree"].ToBoolean();

            var createBy = doc["createBy"].ToBsonDocument();
            entity.CreateBy = new UpdateStamp
            {
                UserId = createBy["userId"].ToString(),
                Name = createBy["name"].ToString(),
                Time = createBy["time"].ToLocalTime()
            };

            var updateBy = doc["updateBy"].ToBsonDocument();
            entity.UpdateBy = new UpdateStamp
            {
                UserId = updateBy["userId"].ToString(),
                Name = updateBy["name"].ToString(),
                Time = updateBy["time"].ToLocalTime()
            };

            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(MaintenanceInfo entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "facilityId", entity.FacilityId },
                { "facilityName", entity.FacilityName },
                { "maintenanceCompanyId", entity.MaintenanceCompanyId },
                { "maintenanceCompanyName", entity.MaintenanceCompanyName },
                { "startDate", entity.StartDate },
                { "endDate", entity.EndDate },
                { "maintenanceFee", entity.MaintenanceFee },
                { "isFree", entity.IsFree },
                { "createBy", new BsonDocument {
                    { "userId", entity.CreateBy.UserId },
                    { "name", entity.CreateBy.Name },
                    { "time", entity.CreateBy.Time }
                }},
                { "updateBy", new BsonDocument {
                    { "userId", entity.UpdateBy.UserId },
                    { "name", entity.UpdateBy.Name },
                    { "time", entity.UpdateBy.Time }
                }},
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            return doc;
        }
        #endregion //Function
    }
}
