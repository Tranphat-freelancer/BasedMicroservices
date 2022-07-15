using QuanLySangKien.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace QuanLySangKien.Entities;

public class UnitRepository : EfCoreRepository<QuanLySangKienDbContext, Unit, Guid>, IUnitRepository
{
    public UnitRepository(IDbContextProvider<QuanLySangKienDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Unit>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}