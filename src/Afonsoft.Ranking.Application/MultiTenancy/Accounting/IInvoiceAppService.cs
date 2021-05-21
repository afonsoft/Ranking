using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Afonsoft.Ranking.MultiTenancy.Accounting.Dto;

namespace Afonsoft.Ranking.MultiTenancy.Accounting
{
    public interface IInvoiceAppService
    {
        Task<InvoiceDto> GetInvoiceInfo(EntityDto<long> input);

        Task CreateInvoice(CreateInvoiceDto input);
    }
}
