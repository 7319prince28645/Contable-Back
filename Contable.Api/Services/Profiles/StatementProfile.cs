using AutoMapper;
using Contable.Contractx.Statement.Command;
using Domain.Statement;

namespace Contable.Api.Services.Profiles;

public class StatementProfile : Profile
{
    public StatementProfile()
    {
        CreateMap<AddStatement, Statements>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.TransactionsId, opt => opt.MapFrom(src => src.TransactionsId))
            .ForMember(dest => dest.DateTaxReturnsId, opt => opt.MapFrom(src => src.DateTaxReturnsId));
    }
}
