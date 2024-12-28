using Contable.Application.Services.Interfaces.Persistence.PaymentRepository;
using MediatR;

namespace Contable.Application.Payment.Command.Delete;

public class PaymentDeleteCommandHandler : IRequestHandler<PaymentDeleteCommand, string>
{
    private readonly IPaymentRepositoryCommand _paymentRepositoryCommand;

    public PaymentDeleteCommandHandler(IPaymentRepositoryCommand paymentRepositoryCommand)
    {
        _paymentRepositoryCommand = paymentRepositoryCommand;
    }

    public async Task<string> Handle(PaymentDeleteCommand request, CancellationToken cancellationToken)
    {
        return await _paymentRepositoryCommand.DeleteAsync(request.Id);
    }
}
