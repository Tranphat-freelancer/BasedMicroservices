using AutoMapper;
using QuanLySangKien.Entities;
using QuanLySangKien.Entities.Dtos;

namespace Based;

public class BasedApplicationAutoMapperProfile : Profile
{
    public BasedApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Field, FieldDto>();
        CreateMap<CreateUpdateFieldDto, Field>(MemberList.Source);
        CreateMap<Unit, UnitDto>();
        CreateMap<CreateUpdateUnitDto, Unit>(MemberList.Source);
    }
}
