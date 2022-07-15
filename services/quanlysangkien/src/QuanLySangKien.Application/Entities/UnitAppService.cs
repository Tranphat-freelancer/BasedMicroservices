using System;
using QuanLySangKien.Entities.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace QuanLySangKien.Entities;

public class UnitAppService : CrudAppService<Unit, UnitDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateUnitDto, CreateUpdateUnitDto>,
    IUnitAppService
{

    private readonly IUnitRepository _repository;

    public UnitAppService(IUnitRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
