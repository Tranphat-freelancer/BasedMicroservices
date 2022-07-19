using System;
using QuanLySangKien.Entities.Dtos;
using QuanLySangKien.Permissions;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace QuanLySangKien.Entities;

public class UnitAppService : CrudAppService<Unit, UnitDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateUnitDto, CreateUpdateUnitDto>,
    IUnitAppService
{
    //protected override string GetPolicyName { get; set; } = QuanLySangKienPermissions.UnitManagement.Default;
    //protected override string GetListPolicyName { get; set; } = QuanLySangKienPermissions.UnitManagement.Default;
    protected override string CreatePolicyName { get; set; } = QuanLySangKienPermissions.UnitManagement.Create;
    protected override string UpdatePolicyName { get; set; } = QuanLySangKienPermissions.UnitManagement.Update;
    protected override string DeletePolicyName { get; set; } = QuanLySangKienPermissions.UnitManagement.Delete;
    private readonly IUnitRepository _repository;

    public UnitAppService(IUnitRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
