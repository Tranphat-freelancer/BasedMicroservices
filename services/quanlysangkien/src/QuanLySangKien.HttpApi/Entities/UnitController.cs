using Microsoft.AspNetCore.Authorization;
using QuanLySangKien.Entities.Dtos;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace QuanLySangKien.Entities
{
    [RemoteService(Name = QuanLySangKienRemoteServiceConsts.RemoteServiceName)]
    //[ControllerName("UnitController")]
    [Authorize]
    public class UnitController : QuanLySangKienController, IUnitAppService
    {
        protected IUnitAppService UnitAppService { get; set; }
        public UnitController(IUnitAppService UnitAppService)
        {
            this.UnitAppService = UnitAppService;
        }
        public virtual async Task<UnitDto> CreateAsync(CreateUpdateUnitDto input)
        {
            return await UnitAppService.CreateAsync(input);
        }

        public virtual async Task DeleteAsync(Guid id)
        {
            await UnitAppService.DeleteAsync(id);
        }

        public virtual async Task<UnitDto> GetAsync(Guid id)
        {
            return await UnitAppService.GetAsync(id);
        }

        public virtual async Task<PagedResultDto<UnitDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return await UnitAppService.GetListAsync(input);
        }

        public virtual async Task<UnitDto> UpdateAsync(Guid id, CreateUpdateUnitDto input)
        {
            return await UnitAppService.UpdateAsync(id, input);
        }
    }
}
