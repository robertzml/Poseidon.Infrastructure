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
    /// 维修改造数据访问类
    /// </summary>
    internal class RepairRepository : AbstractDALMongo<Repair>, IRepairRepository
    {
        #region Constructor
        /// <summary>
        /// 维修改造数据访问类
        /// </summary>
        public RepairRepository()
        {
            base.Init("infrastructure_repair");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Repair DocToEntity(BsonDocument doc)
        {
            Repair entity = new Repair();
            entity.Id = doc["_id"].ToString();
            entity.FacilityId = doc["facilityId"].ToString();
            entity.FacilityName = doc["facilityName"].ToString();
            entity.ModelType = doc["modelType"].ToString();
            entity.Type = doc["type"].ToInt32();
            entity.IsProject = doc["isProject"].ToBoolean();
            entity.ConstructionCompany = doc["constructionCompany"].ToString();
            entity.RepairFee = doc["repairFee"].ToDecimal();
            entity.StartDate = doc["startDate"].ToLocalTime();

            if (doc.Contains("endDate"))
                entity.EndDate = doc["endDate"].ToLocalTime();

            entity.ExpenseIds = new List<string>();
            if (doc.Contains("expenseIds"))
            {
                BsonArray array = doc["expenseIds"].AsBsonArray;
                foreach (string item in array)
                {
                    entity.ExpenseIds.Add(item);
                }
            }

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
        protected override BsonDocument EntityToDoc(Repair entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "facilityId", entity.FacilityId },
                { "facilityName", entity.FacilityName },
                { "modelType", entity.ModelType },
                { "type", entity.Type },
                { "isProject", entity.IsProject },
                { "constructionCompany", entity.ConstructionCompany },
                { "repairFee", entity.RepairFee },
                { "startDate", entity.StartDate },
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

            if (entity.EndDate != null)
                doc.Add("endDate", entity.EndDate.Value);

            if (entity.ExpenseIds != null && entity.ExpenseIds.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.ExpenseIds)
                {
                    array.Add(item);
                }

                doc.Add("expenseIds", array);
            }

            return doc;
        }
        #endregion //Function
    }
}
