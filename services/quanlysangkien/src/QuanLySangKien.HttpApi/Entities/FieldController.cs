using Microsoft.AspNetCore.Authorization;
using QuanLySangKien.Entities.Dtos;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace QuanLySangKien.Entities
{
    [RemoteService(Name = QuanLySangKienRemoteServiceConsts.RemoteServiceName)]
    //[ControllerName("FieldController")]
    [Authorize]
    public class FieldController : QuanLySangKienController, IFieldAppService
    {
        protected IFieldAppService FieldAppService { get; set; }
        public FieldController(IFieldAppService FieldAppService)
        {
            this.FieldAppService = FieldAppService;
        }
        public virtual async Task<FieldDto> CreateAsync(CreateUpdateFieldDto input)
        {
            return await FieldAppService.CreateAsync(input);
        }
        public virtual async Task DeleteAsync(Guid id)
        {
            await FieldAppService.DeleteAsync(id);
        }
        public virtual async Task<FieldDto> GetAsync(Guid id)
        {
            return await FieldAppService.GetAsync(id);
        }

        public virtual async Task<PagedResultDto<FieldDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return await FieldAppService.GetListAsync(input);
        }

        public virtual async Task<FieldDto> UpdateAsync(Guid id, CreateUpdateFieldDto input)
        {
            return await FieldAppService.UpdateAsync(id, input);
        }
    }
}
