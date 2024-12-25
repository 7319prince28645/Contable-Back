using Contable.Domain.Enterprise;
using Contable.Domain.Enterprise.Entities;
using Contable.Domain.Task;
using Contable.Domain.User;
using Domain.DateTaxReturn;
using Domain.ExchangeRate;
using Domain.Payment;
using Domain.Statement;
using Domain.Transaction;
using Microsoft.EntityFrameworkCore;

namespace Contable.Infrastructure.Persistence;

public class ContextContable : DbContext
{

    public ContextContable(DbContextOptions<ContextContable> options) : base(options) { }

    public DbSet<Users>? Users { get; set; }
    public DbSet<Transactions>? Transactions { get; set; }
    public DbSet<Tasks>? Tasks { get; set; }
    public DbSet<Statements>? Statements { get; set; }
    public DbSet<Payments>? Payments { get; set; }
    public DbSet<ExchangeRates>? ExchangeRates { get; set; }
    public DbSet<Enterprises>? Enterprises { get; set; }
    public DbSet<DateTaxReturns>? DateTaxReturns { get; set; }

    //Entities

    public DbSet<Adrress>? Adrress { get; set; }
    public DbSet<Contacts>? Contacts { get; set; }
    public DbSet<EmployeesCompany>? EmployeesCompany { get; set; }
    public DbSet<Regime>? Regime { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

    }
}
