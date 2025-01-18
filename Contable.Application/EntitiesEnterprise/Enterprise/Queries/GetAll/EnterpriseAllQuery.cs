using Contable.Application.EntitiesEnterprise.Enterprise.Common;
using MediatR;

namespace Contable.Application.EntitiesEnterprise.Enterprise.Queries.GetAll;

public record EnterpriseAllQuery() : IRequest<IEnumerable<EnterpriseResult>>;
