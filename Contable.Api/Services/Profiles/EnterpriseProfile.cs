using AutoMapper;
using Contable.Application.Enterprise.Command.Add;
using Contable.Contractx.Enterprise.Commands;
using Contable.Domain.Enterprise;

namespace Contable.Api.Services.Profiles;

public class EnterpriseProfile : Profile
{
    public EnterpriseProfile()
    {
        CreateMap<AddEnterpriseDTO, EnterpriseAddCommand>().
           ConstructUsing(src => new EnterpriseAddCommand(new Enterprises
           {
               Planilla = src.Planilla,
               CompanyName = src.CompanyName,
               Ruc = src.Ruc,
           }));

        CreateMap<AddEnterpriseDTO, Enterprises>()
            .ForMember(dest => dest.Planilla, opt => opt.MapFrom(src => src.Planilla))
            .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.CompanyName))
            .ForMember(dest => dest.Ruc, opt => opt.MapFrom(src => src.Ruc));
    }
}
