using Contable.Application.EntitiesEnterprise.Regimes.Common;
using Contable.Domain.Enterprise.Entities;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Regimes.Command.UpdateOne;

public record RegimeUpdateOneCommand(Guid Id, Regime Regime) : IRequest<RegimeResponse>;
