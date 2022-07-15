using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace QuanLySangKien.Entities
{
    //Đơn vị
    public class Unit : AuditedAggregateRoot<Guid>
    {
        public string Descriptions { get; set; }
        protected Unit()
        {
        }

        public Unit(
            Guid id) : base(id)
        {
        }

    public Unit(
        Guid id,
        string descriptions
    ) : base(id)
    {
        Descriptions = descriptions;
    }
    }
}
