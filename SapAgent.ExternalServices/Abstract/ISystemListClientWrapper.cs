using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SystemList;

namespace SapAgent.ExternalServices.Abstract
{
    public interface ISystemListClientWrapper
    {
        Task<ZaygbcsysMsxxlistV6Rf[]> GetData();
    }
}
