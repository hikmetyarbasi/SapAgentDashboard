using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BackgroundProcess;

namespace SapAgent.ExternalServices.Abstract
{
    public interface IBackgroundProcessClientWrapper
    {
        Task<ZaygbssysTbtcjobBkRf[]> GetData();
    }
}
