using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLySangKien.Entities;
using QuanLySangKien.Entities.Dtos;
using Based.Web.Pages.QuanLySangKien.Entities.Unit.ViewModels;

namespace Based.Web.Pages.QuanLySangKien.Entities.Unit;

public class CreateModalModel : BasedPageModel
{
    [BindProperty]
    public CreateEditUnitViewModel ViewModel { get; set; }

    private readonly IUnitAppService _service;

    public CreateModalModel(IUnitAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditUnitViewModel, CreateUpdateUnitDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}