using QuanLySangKien.Entities;

namespace Based.EntityFrameworkCore.QuanLySangKien.Entities;

public class FieldRepositoryTests : BasedEntityFrameworkCoreTestBase
{
    private readonly IFieldRepository _fieldRepository;

    public FieldRepositoryTests()
    {
        _fieldRepository = GetRequiredService<IFieldRepository>();
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
