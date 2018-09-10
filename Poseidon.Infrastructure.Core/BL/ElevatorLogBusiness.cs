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

    /// <summary>
    /// 电梯日志业务类
    /// </summary>
    public class ElevatorLogBusiness : AbstractBusiness<ElevatorLog>, IBaseBL<ElevatorLog>
    {
        #region Constructor
        /// <summary>
        /// 电梯日志业务类
        /// </summary>
        public ElevatorLogBusiness()
        {
            this.baseDal = RepositoryFactory<IElevatorLogRepository>.Instance;
        }
        #endregion //Constructor

        #region CRUD
        /// <summary>
        /// 添加电梯日志
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(ElevatorLog entity, ILoginUser user)
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
        #endregion //CRUD
    }
}
