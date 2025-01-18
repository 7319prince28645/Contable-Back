using Contable.Application.EntitiesEnterprise.Adress.Common;
using Contable.Domain.Enterprise.Entities;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Adress.Command.UpdateOne;

public record AdressUpdateOneCommand(Guid Id, Adrress Adrress) : IRequest<AdressResponse>;
