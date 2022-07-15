using AutoMapper;
using Based.Web.Pages.QuanLySangKien.Entities.Field.ViewModels;
using Based.Web.Pages.QuanLySangKien.Entities.Unit.ViewModels;
using QuanLySangKien.Entities.Dtos;

namespace Based.Web;

public class BasedWebAutoMapperProfile : Profile
{
    public BasedWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<FieldDto, CreateEditFieldViewModel>();
        CreateMap<CreateEditFieldViewModel, CreateUpdateFieldDto>();
        CreateMap<UnitDto, CreateEditUnitViewModel>();
        CreateMap<CreateEditUnitViewModel, CreateUpdateUnitDto>();
    }
}
