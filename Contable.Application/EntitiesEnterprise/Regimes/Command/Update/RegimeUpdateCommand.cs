using Contable.Application.EntitiesEnterprise.Regimes.Common;
using Contable.Domain.Enterprise.Entities;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Regimes.Command.Update;

public record RegimeUpdateCommand(Guid Id, Regime Regime) : IRequest<RegimeResponse>;
