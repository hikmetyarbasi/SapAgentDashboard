using System.Threading.Tasks;
using CheckDumps;

namespace SapAgent.ExternalServices.Abstract
{
    public interface ICheckDumpsClientWrapper
    {
        Task<Rdumpov[]> GetData();
    }
}