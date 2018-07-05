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

    /// <summary>
    /// 设施检验业务类
    /// </summary>
    public class InspectionBusiness : AbstractBusiness<Inspection>, IBaseBL<Inspection>
    {
        #region Constructor
        /// <summary>
        /// 设施检验业务类
        /// </summary>
        public InspectionBusiness()
        {
            this.baseDal = RepositoryFactory<IInspectionRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 按设施查找检验信息
        /// </summary>
        /// <param name="facilityId">设施ID</param>
        /// <returns></returns>
        public IEnumerable<Inspection> FindByFacility(string facilityId)
        {
            return this.baseDal.FindListByField("facilityId", facilityId);
        }

        /// <summary>
        /// 添加检验信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Inspection entity, LoginUser user)
        {
            entity.CreateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑检验信息
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(Inspection entity, LoginUser user)
        {
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            return base.Update(entity);
        }

        /// <summary>
        /// 返回检验类
        /// </summary>
        /// <param name="modelType">模型类型</param>
        /// <returns></returns>
        public static Type GetInspectionType(string modelType)
        {
            if (modelType == Utility.ModelTypeCode.Elevator)
            {
                return typeof(ElevatorInspection);
            }
            else
            {
                return null;
            }
        }
        #endregion //Method
    }
}
