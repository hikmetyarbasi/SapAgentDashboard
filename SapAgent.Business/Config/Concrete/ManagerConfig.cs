using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SapAgent.Business.Config.Abstract;
using SapAgent.DataAccess.Abstract;
using SapAgent.Entities.Abstract;

namespace SapAgent.Business.Config.Concrete
{
    public class ManagerConfig<T> : IManagerConfig<T> where T : class, IEntity, new()
    {
        public readonly IBaseDal<T> _dal;

        public ManagerConfig(IBaseDal<T> entityRepository)
        {
            _dal = entityRepository;
        }
        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return _dal.GetAll(filter);
        }

        public virtual void StartOperation()
        {
            throw new NotImplementedException();
        }
    }
}
