using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BackgroundProcess;
using CheckDumps;
using SapAgent.ExternalServices.Abstract;

namespace SapAgent.ExternalServices.Concrete
{
    public class CheckDumpsClientWrapper : ICheckDumpsClientWrapper
    {
        private zaygbcsys_ws_chkdumps _checkDumpsClient;

        public CheckDumpsClientWrapper(zaygbcsys_ws_chkdumps checkDumpsClient)
        {
            _checkDumpsClient = checkDumpsClient;
        }
        public async Task<Rdumpov[]> GetData()
        {
            try
            {
                var data = await _checkDumpsClient.ZaygbcsysRfcsChkdumpsAsync(new ZaygbcsysRfcsChkdumpsRequest());
                return data.ZaygbcsysRfcsChkdumpsResponse.EtDumplist;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
