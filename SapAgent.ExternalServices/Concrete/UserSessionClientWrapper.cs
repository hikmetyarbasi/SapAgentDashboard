using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using CheckLocks;
using SapAgent.ExternalServices.Abstract;
using UserSession;

namespace SapAgent.ExternalServices.Concrete
{
    public class UserSessionClientWrapper:IUserSessionClientWrapper
    {
        private zaygbcsys_ws_userses _userSessionClient;

        public UserSessionClientWrapper(zaygbcsys_ws_userses userSessionClient)
        {
            _userSessionClient = userSessionClient;
        }
        public async Task<ZaygbssysUsersessRf[]> GetData()
        {
            try
            {
                var data = await _userSessionClient.ZaygbcsysRfcsUsersesAsync(new ZaygbcsysRfcsUsersesRequest());
                return data.ZaygbcsysRfcsUsersesResponse.EtUsrSessList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
