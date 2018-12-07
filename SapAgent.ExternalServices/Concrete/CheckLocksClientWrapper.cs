using CheckLocks;
using SapAgent.ExternalServices.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SapAgent.ExternalServices.Concrete
{
    public class CheckLocksClientWrapper : ICheckLocksClientWrapper
    {
        private readonly zaygbcsys_ws_chklocks _checkLocksClient;

        public CheckLocksClientWrapper(zaygbcsys_ws_chklocks userSessionClient)
        {
            _checkLocksClient = userSessionClient;
        }
        public async Task<ZaygbcsysLocksRf[]> GetData()
        {
            try
            {
                var data = await _checkLocksClient.ZaygbcsysRfcsLocksAsync(new ZaygbcsysRfcsLocksRequest());
                return data.ZaygbcsysRfcsLocksResponse.EtLockList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
