using QuanLySangKien.Entities;
using Shouldly;
using System.Threading.Tasks;
using Xunit;

namespace Based.QuanLySangKien.Entities;

public class FieldAppServiceTests : BasedApplicationTestBase
{
    private readonly IFieldAppService _fieldAppService;

    public FieldAppServiceTests()
    {
        _fieldAppService = GetRequiredService<IFieldAppService>();
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

