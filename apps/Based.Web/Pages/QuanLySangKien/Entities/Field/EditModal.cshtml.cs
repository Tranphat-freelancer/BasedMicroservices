using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLySangKien.Entities;
using QuanLySangKien.Entities.Dtos;
using Based.Web.Pages.QuanLySangKien.Entities.Field.ViewModels;

namespace Based.Web.Pages.QuanLySangKien.Entities.Field;

public class EditModalModel : BasedPageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateEditFieldViewModel ViewModel { get; set; }

    private readonly IFieldAppService _service;

    public EditModalModel(IFieldAppService service)
    {
        _service = service;
    }

    public virtual async Task OnGetAsync()
    {
        var dto = await _service.GetAsync(Id);
        ViewModel = ObjectMapper.Map<FieldDto, CreateEditFieldViewModel>(dto);
    }

    public virtual async Task<IActionResult> OnPostAsync()
    {
        var dto = ObjectMapper.Map<CreateEditFieldViewModel, CreateUpdateFieldDto>(ViewModel);
        await _service.UpdateAsync(Id, dto);
        return NoContent();
    }
}