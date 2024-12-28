using Contable.Application.Services.Interfaces.Persistence.PaymentRepository;
using Domain.Payment;
using Microsoft.EntityFrameworkCore;

namespace Contable.Infrastructure.Persistence.Repository.PaymentRepository;

public class PaymentCommandRepository : IPaymentRepositoryCommand
{
    private readonly ContextContable _contableDbContext;

    public PaymentCommandRepository(ContextContable contableDbContext)
    {
        _contableDbContext = contableDbContext;
    }

    public async Task<Payments> AddAsync(Payments payments)
    {
        Guid Id = new("0c8a4f38-037c-4556-bb22-e83080c5083f");

        var user = await _contableDbContext.Users.FindAsync(Id);

        if (user == null)
            throw new Exception("User not found");


        await _contableDbContext.Payments.AddAsync(payments);
        await _contableDbContext.SaveChangesAsync();
        user.PaymentsId = payments.Id;

        await _contableDbContext.SaveChangesAsync();


        return payments;
    }

    public async Task<string> DeleteAsync(Guid Id)
    {

        var payment = await _contableDbContext.Payments.FindAsync(Id);
        if (payment == null)
            return "Payment not found";

        var user = await _contableDbContext.Users.FirstOrDefaultAsync(x => x.PaymentsId == Id);
        if (user is not null)
        {
            user.PaymentsId = null;
            await _contableDbContext.SaveChangesAsync();
            return "Payment User deleted";

        }

        var enterprise = await _contableDbContext.Enterprises.FirstOrDefaultAsync(x => x.PaymentsId == Id);

        if (enterprise is not null)
        {
            enterprise.PaymentsId = null;
            await _contableDbContext.SaveChangesAsync();
            return "Payment Enterprise deleted";
        }

        return "Payment is not associated with any user or enterprise";
    }

    public async Task<Payments> UpdateAsync(Guid Id, Payments payments)
    {

        var payment = await _contableDbContext.Payments.FindAsync(Id);
        if (payment == null)
            throw new Exception("Payment not found");

        payment.Amount = payments.Amount;
        payment.MissingAmount = payments.MissingAmount;
        payment.UpdatedAt = DateTime.UtcNow;
        payment.Status = payments.Status;

        await _contableDbContext.SaveChangesAsync();

        return payment;

    }

    public async Task<Payments> UpdateAsyncByOne(Guid Id, Payments payments)
    {
        var payment = await _contableDbContext.Payments.FindAsync(Id);
        if (payment == null)
            throw new Exception("Payment not found");

        bool hasChanged = false;

        if (payment.Status != payments.Status && payments.Status != null)
        {
            payment.Status = payments.Status;
            hasChanged = true;
        }

        if (payments.Amount != payment.Amount)
        {
            if (payments.Amount > 0)
            { 
            payment.Amount = payments.Amount;
            hasChanged = true;
            }
        }

        if (payments.MissingAmount != payment.MissingAmount)
        {
            if (payments.MissingAmount > 0)
            { 
            payment.MissingAmount = payments.MissingAmount;
            hasChanged = true;
            }
        }

        // Actualizar la fecha si hubo cambios
        if (hasChanged)
        {
            payment.UpdatedAt = DateTime.UtcNow;
            await _contableDbContext.SaveChangesAsync();
        }

        return payment;

    }
}
