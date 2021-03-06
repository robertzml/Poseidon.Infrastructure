﻿using System;
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
    /// 电梯数据访问类
    /// </summary>
    internal class ElevatorRepository : AbstractDALMongo<Elevator>, IElevatorRepository
    {
        #region Field
        /// <summary>
        /// 模型类型
        /// </summary>
        private readonly string modelType = Utility.ModelTypeCode.Elevator;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 电梯数据访问类
        /// </summary>
        public ElevatorRepository()
        {
            base.Init("core_facility");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Elevator DocToEntity(BsonDocument doc)
        {
            Elevator entity = new Elevator();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.Model = doc["model"].ToString();
            entity.InstallDate = doc["installDate"].ToLocalTime();
            entity.RegistrationNumber = doc["registrationNumber"].ToString();
            entity.RescueNumber = doc["rescueNumber"].ToString();
            entity.Capacity = doc["capacity"].ToInt32();
            entity.Speed = doc["speed"].ToDouble();
            entity.Station = doc["station"].ToString();
            entity.Vendor = doc["vendor"].ToString();
            entity.Position = doc["position"].ToString();
            entity.RecordBag = doc["recordBag"].ToString();
            entity.RecordNumber = doc["recordNumber"].ToString();
            entity.ModelType = doc["modelType"].ToString();
            entity.DatasetCode = doc["datasetCode"].ToString();
            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            entity.Managers = new List<ElevatorManager>();
            if (doc.Contains("managers"))
            {
                BsonArray array = doc["managers"].AsBsonArray;
                foreach (BsonDocument item in array)
                {
                    ElevatorManager manager = new ElevatorManager();
                    manager.Id = item["_id"].ToString();
                    manager.ElevatorId = item["elevatorId"].ToString();
                    manager.Name = item["name"].ToString();
                    manager.Telephone = item["telephone"].ToString();
                    if (item.Contains("startDate"))
                        manager.StartDate = item["startDate"].ToLocalTime();
                    if (item.Contains("endDate"))
                        manager.EndDate = item["endDate"].ToLocalTime();

                    manager.Remark = item["remark"].ToString();

                    entity.Managers.Add(manager);
                }
            }

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(Elevator entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "model", entity.Model },
                { "installDate", entity.InstallDate },
                { "registrationNumber", entity.RegistrationNumber },
                { "rescueNumber", entity.RescueNumber },
                { "capacity", entity.Capacity },
                { "speed", entity.Speed },
                { "station", entity.Station },
                { "vendor", entity.Vendor },
                { "position", entity.Position },
                { "recordBag", entity.RecordBag },
                { "recordNumber", entity.RecordNumber },
                { "modelType", entity.ModelType },
                { "datasetCode", entity.DatasetCode },
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            if (entity.Managers != null && entity.Managers.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.Managers)
                {
                    BsonDocument record = new BsonDocument
                    {
                        { "_id", ObjectId.GenerateNewId() },
                        { "elevatorId", item.ElevatorId },
                        { "name", item.Name },
                        { "telephone", item.Telephone },
                        { "startDate", item.StartDate },
                        { "remark", item.Remark }
                    };

                    if (item.EndDate != null)
                        record.Add("endDate", item.EndDate.Value);

                    array.Add(record);
                }

                doc.Add("managers", array);
            }

            return doc;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 查找所有对象
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<Elevator> FindAll()
        {
            return base.FindListByField<string>("modelType", this.modelType);
        }

        /// <summary>
        /// 添加电梯
        /// </summary>
        /// <param name="entity">电梯对象</param>
        /// <returns></returns>
        public override Elevator Create(Elevator entity)
        {
            entity.ModelType = this.modelType;
            entity.Status = 0;
            return base.Create(entity);
        }
        #endregion //Method
    }
}
