using Contable.Application.Payment.Common;
using Contable.Application.Services.Interfaces.Persistence.PaymentRepository;
using MediatR;

namespace Contable.Application.Payment.Command.Update;

public class PaymentUpdateCommandHandler : IRequestHandler<PaymentUpdateCommand, PaymentResult>
{
    private readonly IPaymentRepositoryCommand _paymentRepositoryCommand;

    public PaymentUpdateCommandHandler(IPaymentRepositoryCommand paymentRepositoryCommand)
    {
        _paymentRepositoryCommand = paymentRepositoryCommand;
    }

    public async Task<PaymentResult> Handle(PaymentUpdateCommand request, CancellationToken cancellationToken)
    {
        var result = await _paymentRepositoryCommand.UpdateAsync(request.Id, request.Payments);
        return new PaymentResult(result);
    }
}
