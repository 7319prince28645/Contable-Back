using Contable.Application.Payment.Common;
using Domain.Payment;
using MediatR;

namespace Contable.Application.Payment.Command.Update;

public record PaymentUpdateCommand(Guid Id, Payments Payments) : IRequest<PaymentResult>;
