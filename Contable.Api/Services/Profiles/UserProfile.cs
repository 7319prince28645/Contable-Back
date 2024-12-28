using AutoMapper;
using Contable.Application.Authentication.Command;
using Contable.Application.Authentication.Commom;
using Contable.Contractx.Users.Commands;
using Contable.Contractx.Users.Queries;
using Contable.Contractx.Users;
using Contable.Domain.User;

namespace Contable.Api.Services.Profiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<Users, UserDTO>().ReverseMap();
        CreateMap<UpdateDTO, Users>();

        CreateMap<CreateDTO, RegisterCommand>()
            .ConstructUsing(src => new RegisterCommand(new Users
            {
                FirstName = src.FirstName,
                LastName = src.LastName,
                Email = src.Email,
                Password = src.Password,
                Salary = src.Salary,
                Planilla = src.Planilla,
                DatePlanilla = src.DatePlanilla,
                DateBeginning = src.DateBeginning
            }));

        CreateMap<AuthenticationResultToken, AuthenticationResponse>()
            .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.Users.FirstName))
            .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.Users.LastName))
            .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Users.Email))
            .ForMember(dest => dest.DateBeginning, opt => opt.MapFrom(src => src.Users.DateBeginning))
            .ForMember(dest => dest.DatePlanilla, opt => opt.MapFrom(src => src.Users.DatePlanilla))
            .ForMember(dest => dest.Planilla, opt => opt.MapFrom(src => src.Users.Planilla))
            .ForMember(dest => dest.Salary, opt => opt.MapFrom(src => src.Users.Salary))
            .ForMember(dest => dest.Token, opt => opt.MapFrom(src => src.Token));
    }
}
