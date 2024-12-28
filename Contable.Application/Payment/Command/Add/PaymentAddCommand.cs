using Contable.Application.Payment.Common;
using Domain.Payment;
using MediatR;

namespace Contable.Application.Payment.Command.Add;

public record PaymentAddCommand(Payments Payments) : IRequest<PaymentResult>;
