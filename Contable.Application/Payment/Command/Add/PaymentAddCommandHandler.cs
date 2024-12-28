using Contable.Application.Payment.Common;
using Contable.Application.Services.Interfaces.Persistence.PaymentRepository;
using MediatR;

namespace Contable.Application.Payment.Command.Add;

public class PaymentAddCommandHandler : IRequestHandler<PaymentAddCommand, PaymentResult>
{
    private readonly IPaymentRepositoryCommand _paymentRepositoryCommand;

    public PaymentAddCommandHandler(IPaymentRepositoryCommand paymentRepositoryCommand)
    {
        _paymentRepositoryCommand = paymentRepositoryCommand;
    }

    public async Task<PaymentResult> Handle(PaymentAddCommand request, CancellationToken cancellationToken)
    {
        var result = await _paymentRepositoryCommand.AddAsync(request.Payments);
        return new PaymentResult(result);
    }
}
