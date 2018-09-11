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
    /// 电梯日志数据访问类
    /// </summary>
    internal class ElevatorLogRepository : AbstractDALMongo<ElevatorLog>, IElevatorLogRepository
    {
        #region Constructor
        /// <summary>
        /// 电梯日志数据访问类
        /// </summary>
        public ElevatorLogRepository()
        {
            base.Init("infrastructure_elevatorLog");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override ElevatorLog DocToEntity(BsonDocument doc)
        {
            ElevatorLog entity = new ElevatorLog();
            entity.Id = doc["_id"].ToString();
            entity.ElevatorId = doc["elevatorId"].ToString();
            entity.Subject = doc["subject"].ToString();
            entity.StartDate = doc["startDate"].ToLocalTime();
            entity.EndDate = doc["endDate"].ToLocalTime();
            entity.LogType = doc["logType"].ToInt32();
            entity.Info = doc["info"].ToString();
            entity.LogStatus = doc["logStatus"].ToInt32();

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
        protected override BsonDocument EntityToDoc(ElevatorLog entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "elevatorId", entity.ElevatorId },
                { "subject", entity.Subject },
                { "startDate", entity.StartDate },
                { "endDate", entity.EndDate },
                { "logType", entity.LogType },
                { "info", entity.Info },
                { "logStatus", entity.LogStatus },
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
