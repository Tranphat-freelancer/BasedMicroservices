using Based.Web.Pages.QuanLySangKien.Entities.Field.ViewModels;
using Microsoft.AspNetCore.Mvc;
using QuanLySangKien.Entities;
using QuanLySangKien.Entities.Dtos;
using System.Threading.Tasks;

namespace Based.Web.Pages.QuanLySangKien.Entities.Field;

public class CreateModalModel : BasedPageModel
{
    [BindProperty]
    public CreateEditFieldViewModel ViewModel { get; set; }

    private readonly IFieldAppService _service;

    public CreateModalModel(IFieldAppService service)
    {
        _service = service;
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditFieldViewModel, CreateUpdateFieldDto>(ViewModel);
        await _service.CreateAsync(dto);
        return NoContent();
    }
}