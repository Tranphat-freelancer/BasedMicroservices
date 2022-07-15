using System;
using QuanLySangKien.Entities.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace QuanLySangKien.Entities;

public interface IFieldAppService :
    ICrudAppService<
        FieldDto,
        Guid,
        PagedAndSortedResultRequestDto,
        CreateUpdateFieldDto,
        CreateUpdateFieldDto>
{

}