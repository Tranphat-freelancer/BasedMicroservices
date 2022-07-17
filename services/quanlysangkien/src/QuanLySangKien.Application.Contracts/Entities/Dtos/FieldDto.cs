using System;
using Volo.Abp.Application.Dtos;

namespace QuanLySangKien.Entities.Dtos;

[Serializable]
public class FieldDto : AuditedEntityDto<Guid>
{
    public string Descriptions { get; set; }
}