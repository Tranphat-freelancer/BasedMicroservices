using AutoMapper;
using QuanLySangKien.Entities;
using QuanLySangKien.Entities.Dtos;

namespace QuanLySangKien;

public class QuanLySangKienApplicationAutoMapperProfile : Profile
{
    public QuanLySangKienApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Field, FieldDto>();
        CreateMap<Unit, UnitDto>();
        CreateMap<CreateUpdateFieldDto, Field>();
        CreateMap<CreateUpdateUnitDto, Unit>();
    }
}
