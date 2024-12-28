using Contable.Application.Payment.Common;
using Domain.Payment;
using MediatR;

namespace Contable.Application.Payment.Command.UpdateByOne;

public record PaymentUpdateOneCommand(Guid Id, Payments Payments) : IRequest<PaymentResult>;
