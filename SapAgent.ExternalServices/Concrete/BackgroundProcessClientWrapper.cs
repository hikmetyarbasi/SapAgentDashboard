using BackgroundProcess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SapAgent.ExternalServices.Abstract;

namespace SapAgent.ExternalServices.Concrete
{

    public class BackgroundProcessClientWrapper : IBackgroundProcessClientWrapper
    {
        private zaygbcsys_ws_bckgprc _backProcessClient;

        public BackgroundProcessClientWrapper(zaygbcsys_ws_bckgprc client)
        {
            this._backProcessClient = client;
        }

        public async Task<ZaygbssysTbtcjobBkRf[]> GetData()
        {
            try
            {
                var data = await _backProcessClient.ZaygbcsysRfcsBckgprcAsync(new ZaygbcsysRfcsBckgprcRequest());
                return data.ZaygbcsysRfcsBckgprcResponse.EtJoblist;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
