using Contable.Application.EntitiesEnterprise.Adress.Common;
using Contable.Domain.Enterprise.Entities;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Adress.Command.Add;

public record AdressAddCommand(Adrress Adrress) : IRequest<AdressResponse>;
