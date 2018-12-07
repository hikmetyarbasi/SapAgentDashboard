using SapAgent.ExternalServices.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SystemList;

namespace SapAgent.ExternalServices.Concrete
{
    public class SystemListClientWrapper : ISystemListClientWrapper
    {
        private zaygbcsys_ws_systlst _client;

        public SystemListClientWrapper(zaygbcsys_ws_systlst client)
        {
            _client = client;
        }
        public async Task<ZaygbcsysMsxxlistV6Rf[]> GetData()
        {
            var data = await _client.ZaygbcsysRfcsSystlstAsync(new ZaygbcsysRfcsSystlstRequest());

            return data.ZaygbcsysRfcsSystlstResponse.EtSysList;
        }
    }
}
