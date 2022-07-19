using Microsoft.AspNetCore.Authorization;
using QuanLySangKien.Entities.Dtos;
using QuanLySangKien.Permissions;
using System;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace QuanLySangKien.Entities
{
    [RemoteService(Name = QuanLySangKienRemoteServiceConsts.RemoteServiceName)]
    //[ControllerName("FieldController")]
    [Authorize(QuanLySangKienPermissions.FieldManagement.Default)]
    public class FieldController : QuanLySangKienController, IFieldAppService
    {
        protected IFieldAppService FieldAppService { get; set; }
        public FieldController(IFieldAppService FieldAppService)
        {
            this.FieldAppService = FieldAppService;
        }
        [Authorize(QuanLySangKienPermissions.FieldManagement.Create)]
        public virtual async Task<FieldDto> CreateAsync(CreateUpdateFieldDto input)
        {
            return await FieldAppService.CreateAsync(input);
        }
        [Authorize(QuanLySangKienPermissions.FieldManagement.Delete)]
        public virtual async Task DeleteAsync(Guid id)
        {
            await FieldAppService.DeleteAsync(id);
        }
        [AllowAnonymous]
        public virtual async Task<FieldDto> GetAsync(Guid id)
        {
            return await FieldAppService.GetAsync(id);
        }
        [AllowAnonymous]
        public virtual async Task<PagedResultDto<FieldDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            return await FieldAppService.GetListAsync(input);
        }
        [Authorize(QuanLySangKienPermissions.FieldManagement.Update)]

        public virtual async Task<FieldDto> UpdateAsync(Guid id, CreateUpdateFieldDto input)
        {
            return await FieldAppService.UpdateAsync(id, input);
        }
    }
}
