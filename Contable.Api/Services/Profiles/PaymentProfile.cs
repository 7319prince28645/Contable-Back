using AutoMapper;
using Contable.Contractx.Payment.Command;
using Domain.Payment;

namespace Contable.Api.Services.Profiles;

public class PaymentProfile : Profile
{
    public PaymentProfile()
    {
   

        CreateMap<AddPayment, Payments>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Amount))
            .ForMember(dest => dest.MissingAmount, opt => opt.MapFrom(src => src.MissingAmount))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));


    }
}
