using QuanLySangKien.Entities;

namespace Based.QuanLySangKien.Entities;

public class UnitAppServiceTests : BasedApplicationTestBase
{
    private readonly IUnitAppService _unitAppService;

    public UnitAppServiceTests()
    {
        _unitAppService = GetRequiredService<IUnitAppService>();
    }

    /*
    [Fact]
    public async Task Test1()
    {
        // Arrange

        // Act

        // Assert
    }
    */
}

