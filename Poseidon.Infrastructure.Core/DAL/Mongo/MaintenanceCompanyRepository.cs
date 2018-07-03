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
    /// 维保单位数据访问类
    /// </summary>
    internal class MaintenanceCompanyRepository : AbstractDALMongo<MaintenanceCompany>, IMaintenanceCompanyRepository
    {
        #region Field
        /// <summary>
        /// 模型类型
        /// </summary>
        private readonly string modelType = Utility.ModelTypeCode.MaintenanceCompany;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 电梯数据访问类
        /// </summary>
        public MaintenanceCompanyRepository()
        {
            base.Init("core_organization");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override MaintenanceCompany DocToEntity(BsonDocument doc)
        {
            MaintenanceCompany entity = new MaintenanceCompany();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.ShortName = doc["shortName"].ToString();
            entity.Address = doc["address"].ToString();
            entity.Contact = doc["contact"].ToString();
            entity.ModelType = doc["modelType"].ToString();
            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(MaintenanceCompany entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "shortName", entity.ShortName },
                { "address", entity.Address },
                { "contact", entity.Contact },
                { "modelType", entity.ModelType },
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            return doc;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 查找所有对象
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<MaintenanceCompany> FindAll()
        {
            return base.FindListByField<string>("modelType", this.modelType);
        }

        /// <summary>
        /// 添加维保单位
        /// </summary>
        /// <param name="entity">电梯对象</param>
        /// <returns></returns>
        public override MaintenanceCompany Create(MaintenanceCompany entity)
        {
            entity.ModelType = this.modelType;
            entity.Status = 0;
            return base.Create(entity);
        }
        #endregion //Method
    }
}
