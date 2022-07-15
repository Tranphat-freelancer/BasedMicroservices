using System;
using QuanLySangKien.Entities.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace QuanLySangKien.Entities;

public class FieldAppService : CrudAppService<Field, FieldDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateFieldDto, CreateUpdateFieldDto>,
    IFieldAppService
{

    private readonly IFieldRepository _repository;

    public FieldAppService(IFieldRepository repository) : base(repository)
    {
        _repository = repository;
    }
}
