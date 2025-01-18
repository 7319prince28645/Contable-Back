using Contable.Application.EntitiesEnterprise.Adress.Common;
using Contable.Domain.Enterprise.Entities;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Adress.Command.Update;

public record AdressUpdateCommand(Guid Id, Adrress Adrress) : IRequest<AdressResponse>;
