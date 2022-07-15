using System;
using Volo.Abp.Domain.Repositories;

namespace QuanLySangKien.Entities;

public interface IUnitRepository : IRepository<Unit, Guid>
{
}
