using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SapAgent.Business.Config.Abstract
{
    public interface IManagerConfig<T>
    {
        List<T> GetAll(Expression<Func<T, bool>> filter);
        void StartOperation();
    }
}
