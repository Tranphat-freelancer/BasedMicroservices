using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace QuanLySangKien.Samples;

public interface ISampleAppService : IApplicationService
{
    Task<SampleDto> GetAsync();

    Task<SampleDto> GetAuthorizedAsync();
}
