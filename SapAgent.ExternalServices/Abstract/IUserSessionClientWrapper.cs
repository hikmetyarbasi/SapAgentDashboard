using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using UserSession;

namespace SapAgent.ExternalServices.Abstract
{
    public interface IUserSessionClientWrapper
    {
        Task<ZaygbssysUsersessRf[]> GetData();
    }
}
