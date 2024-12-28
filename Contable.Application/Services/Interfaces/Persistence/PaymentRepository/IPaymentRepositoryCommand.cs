
using Domain.Payment;

namespace Contable.Application.Services.Interfaces.Persistence.PaymentRepository;

public interface IPaymentRepositoryCommand
{
    Task<Payments> AddAsync(Payments payments);
    Task<Payments> UpdateAsync(Guid Id, Payments payments);
    Task<string> DeleteAsync(Guid Id);
    Task<Payments> UpdateAsyncByOne(Guid Id, Payments payments);



}
