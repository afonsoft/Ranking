using System.Threading.Tasks;
using Abp.Dependency;

namespace Afonsoft.Ranking.MultiTenancy.Accounting
{
    public interface IInvoiceNumberGenerator : ITransientDependency
    {
        Task<string> GetNewInvoiceNumber();
    }
}