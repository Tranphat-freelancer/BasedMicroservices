using QuanLySangKien.Entities;

namespace Based.EntityFrameworkCore.QuanLySangKien.Entities;

public class UnitRepositoryTests : BasedEntityFrameworkCoreTestBase
{
    private readonly IUnitRepository _unitRepository;

    public UnitRepositoryTests()
    {
        _unitRepository = GetRequiredService<IUnitRepository>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        await WithUnitOfWorkAsync(async () =>
        {
            // Arrange

            // Act

            //Assert
        });
    }
    */
}
