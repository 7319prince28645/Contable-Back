using Contable.Application.EntitiesEnterprise.Regimes.Common;
using Contable.Domain.Enterprise.Entities;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Regimes.Command.Add;

public record RegimeAddCommand(Regime Regime) : IRequest<RegimeResponse>;
