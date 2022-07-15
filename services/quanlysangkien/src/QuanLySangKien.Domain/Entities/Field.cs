using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace QuanLySangKien.Entities
{
    //Lĩnh vực
    public class Field : AuditedAggregateRoot<Guid>
    {

    protected Field()
    {
    }

    public Field(
        Guid id    ) : base(id)
    {
    }
    }
}
