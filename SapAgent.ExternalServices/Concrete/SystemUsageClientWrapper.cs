using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SystemUsages;
using SapAgent.ExternalServices.Abstract;

namespace SapAgent.ExternalServices.Concrete
{
    public class SystemUsageClientWrapper : ISystemUsageClientWrapper
    {
        private readonly zaygbcsys_ws_sysusage _client;

        public SystemUsageClientWrapper(zaygbcsys_ws_sysusage client)
        {
            _client = client;
        }

        public async Task<ZaygbssysSysusageRf[]> GetData()
        {
            try
            {
                var data = await _client.ZaygbcsysRfcsSysusageAsync(new ZaygbcsysRfcsSysusageRequest());
                return data.ZaygbcsysRfcsSysusageResponse.EtSnapshots;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
