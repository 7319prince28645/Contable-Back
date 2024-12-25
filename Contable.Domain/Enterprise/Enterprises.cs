using Contable.Domain.Enterprise.Entities;
using Contable.Domain.Task;
using Contable.Domain.User;
using Domain.DateTaxReturn;
using Domain.Payment;
using Domain.Statement;
using Domain.Transaction;
using System.Text.Json.Serialization;

namespace Contable.Domain.Enterprise;

public class Enterprises
{
    public Guid Id { get; init; }
    public bool Planilla { get; set; }
    public string? CompanyName { get; set; }
    public string? Ruc { get; set; }

    public Adrress? Address { get; set; }
    public Regime? Regime { get; set; }

    public Guid? PaymentsId { get; set; }
    public Guid? TasksId { get; set; }
    public Guid? ContactsId { get; set; }
    public Guid? EmployeesCompanyId { get; set; }
    public Guid TransactionsId { get; set; }
    public Guid? StatementsId { get; set; }
    public Guid? DateTaxReturnsId { get; set; }

    public Payments? Payments { get; set; }
    public Tasks? Tasks { get; set; }
    public Contacts? Contacts { get; set; }
    public EmployeesCompany? EmployeesCompany { get; set; }
    public Transactions? Transactions { get; set; }
    public Statements? Statements { get; set; }
    public DateTaxReturns? DateTaxReturns { get; set; }


    [JsonIgnore]
    public List<Users>? Users { get; set; } = [];

}

