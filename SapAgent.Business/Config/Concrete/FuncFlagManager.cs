using SapAgent.DataAccess.Abstract;
using SapAgent.Entities.Concrete.Config;

namespace SapAgent.Business.Config.Concrete
{
    public class FuncFlagManager : ManagerConfig<FuncFlag>
    {
        public FuncFlagManager(IBaseDal<FuncFlag> entityRepository) :
            base(entityRepository)
        {

        }
    }
}
