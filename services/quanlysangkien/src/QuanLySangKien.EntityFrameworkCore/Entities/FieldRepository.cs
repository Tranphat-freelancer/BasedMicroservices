using QuanLySangKien.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace QuanLySangKien.Entities;

public class FieldRepository : EfCoreRepository<QuanLySangKienDbContext, Field, Guid>, IFieldRepository
{
    public FieldRepository(IDbContextProvider<QuanLySangKienDbContext> dbContextProvider) : base(dbContextProvider)
    {
    }

    public override async Task<IQueryable<Field>> WithDetailsAsync()
    {
        return (await GetQueryableAsync()).IncludeDetails();
    }
}