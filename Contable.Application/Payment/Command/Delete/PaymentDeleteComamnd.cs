using MediatR;

namespace Contable.Application.Payment.Command.Delete;

public record PaymentDeleteCommand(Guid Id) : IRequest<string>;
