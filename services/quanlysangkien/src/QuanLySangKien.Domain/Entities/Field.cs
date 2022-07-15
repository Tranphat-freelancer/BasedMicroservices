using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace QuanLySangKien.Entities
{
    //Lĩnh vực
    public class Field : AuditedAggregateRoot<Guid>
    {
        public string Descriptions { get; set; }
    protected Field()
    {
    }

    public Field(
        Guid id    ) : base(id)
    {
    }

    public Field(
        Guid id,
        string descriptions
    ) : base(id)
    {
        Descriptions = descriptions;
    }
    }
}
