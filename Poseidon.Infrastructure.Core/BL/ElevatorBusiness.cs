using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Infrastructure.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Infrastructure.Core.DL;
    using Poseidon.Infrastructure.Core.IDAL;

    /// <summary>
    /// 电梯业务类
    /// </summary>
    public class ElevatorBusiness : AbstractBusiness<Elevator>
    {
        #region Constructor
        /// <summary>
        /// 电梯业务类
        /// </summary>
        public ElevatorBusiness()
        {
            this.baseDal = RepositoryFactory<IElevatorRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置管理员
        /// </summary>
        /// <param name="id">电梯ID</param>
        /// <param name="managers">管理员信息</param>
        public void SetManagers(string id, List<ElevatorManager> managers)
        {
            var elevator = this.baseDal.FindById(id);
            foreach (var item in managers)
            {
                item.ElevatorId = id;
            }
            elevator.Managers = managers;

            base.Update(elevator);
            return;
        }

        /// <summary>
        /// 编辑管理员
        /// </summary>
        /// <param name="id">电梯ID</param>
        /// <param name="manager">管理员信息</param>
        public void EditManager(string id, ElevatorManager manager)
        {
            var elevator = this.baseDal.FindById(id);

            var old = elevator.Managers.Find(r => r.Id == manager.Id);
            elevator.Managers.Remove(old);

            elevator.Managers.Add(manager);
            elevator.Managers = elevator.Managers.OrderByDescending(r => r.StartDate).ToList();

            base.Update(elevator);
            return;
        }
        #endregion //Method
    }
}
