using Contable.Application.Enterprise.Common;
using MediatR;

namespace Contable.Application.Enterprise.Queries.GetAll;

public record EnterpriseAllQuery() : IRequest<IEnumerable<EnterpriseResult>>;
