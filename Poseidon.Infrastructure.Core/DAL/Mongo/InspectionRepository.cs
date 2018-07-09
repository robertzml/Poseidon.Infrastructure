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
    /// 设施检验数据访问类
    /// </summary>
    internal class InspectionRepository : AbstractDALMongo<Inspection>, IInspectionRepository
    {
        #region Constructor
        /// <summary>
        /// 设施检验数据访问类
        /// </summary>
        public InspectionRepository()
        {
            base.Init("infrastructure_inspection");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Inspection DocToEntity(BsonDocument doc)
        {
            Inspection entity = new Inspection();
            entity.Id = doc["_id"].ToString();
            entity.FacilityId = doc["facilityId"].ToString();
            entity.FacilityName = doc["facilityName"].ToString();
            entity.ModelType = doc["modelType"].ToString();
            entity.Type = doc["type"].ToInt32();
            entity.PlanDate = doc["planDate"].ToLocalTime();
            if (doc.Contains("inspectionDate"))
                entity.InspectionDate = doc["inspectionDate"].ToLocalTime();

            entity.InspectionFee = doc["inspectionFee"].ToDecimal();
            entity.InspectionCompany = doc["inspectionCompany"].ToString();
            entity.InspectionResult = doc["inspectionResult"].ToString();
            entity.IsDone = doc["isDone"].ToBoolean();

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
        protected override BsonDocument EntityToDoc(Inspection entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "facilityId", entity.FacilityId },
                { "facilityName", entity.FacilityName },
                { "modelType", entity.ModelType },
                { "type", entity.Type },
                { "planDate", entity.PlanDate },
                { "inspectionFee", entity.InspectionFee },
                { "inspectionCompany", entity.InspectionCompany },
                { "inspectionResult", entity.InspectionResult },
                { "isDone", entity.IsDone },
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

            if (entity.InspectionDate != null)
                doc.Add("inspectionDate", entity.InspectionDate.Value);

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
