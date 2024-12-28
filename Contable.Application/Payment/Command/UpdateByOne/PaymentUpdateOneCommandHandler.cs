using Contable.Application.Payment.Common;
using Contable.Application.Services.Interfaces.Persistence.PaymentRepository;
using MediatR;

namespace Contable.Application.Payment.Command.UpdateByOne;

public class PaymentUpdateOneCommandHandler : IRequestHandler<PaymentUpdateOneCommand, PaymentResult>
{
    private readonly IPaymentRepositoryCommand _paymentRepositoryCommand;

    public PaymentUpdateOneCommandHandler(IPaymentRepositoryCommand paymentRepositoryCommand)
    {
        _paymentRepositoryCommand = paymentRepositoryCommand;
    }

    public async Task<PaymentResult> Handle(PaymentUpdateOneCommand request, CancellationToken cancellationToken)
    {
        var result = await _paymentRepositoryCommand.UpdateAsyncByOne(request.Id, request.Payments);
        return new PaymentResult(result);

    }
}
