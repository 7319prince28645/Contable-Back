using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Contable.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ConfigAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_UsersId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_UsersId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "EnterprisesId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "StatementId",
                table: "Transactions");

            migrationBuilder.DropColumn(
                name: "UsersId",
                table: "Tasks");

            migrationBuilder.AddColumn<Guid>(
                name: "TasksId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tasks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tasks",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionsId",
                table: "Tasks",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<Guid>(
                name: "ContactsId",
                table: "Enterprises",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DateTaxReturnsId",
                table: "Enterprises",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EmployeesCompanyId",
                table: "Enterprises",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PaymentsId",
                table: "Enterprises",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ruc",
                table: "Enterprises",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "StatementsId",
                table: "Enterprises",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TasksId",
                table: "Enterprises",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "TransactionsId",
                table: "Enterprises",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Adrress",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Reference = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EnterprisesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adrress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adrress_Enterprises_EnterprisesId",
                        column: x => x.EnterprisesId,
                        principalTable: "Enterprises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DateTaxReturns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DigitRuc = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateTaxReturns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeesCompany",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    NumberDocument = table.Column<int>(type: "int", nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResignationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeesCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ExchangeRates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BuyRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regime",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PercentageMonth = table.Column<float>(type: "real", nullable: true),
                    EnterprisesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regime", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Regime_Enterprises_EnterprisesId",
                        column: x => x.EnterprisesId,
                        principalTable: "Enterprises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Statements",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateStatement = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTaxReturnsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Statements_DateTaxReturns_DateTaxReturnsId",
                        column: x => x.DateTaxReturnsId,
                        principalTable: "DateTaxReturns",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Statements_Transactions_TransactionsId",
                        column: x => x.TransactionsId,
                        principalTable: "Transactions",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_TasksId",
                table: "Users",
                column: "TasksId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TransactionsId",
                table: "Tasks",
                column: "TransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Enterprises_ContactsId",
                table: "Enterprises",
                column: "ContactsId");

            migrationBuilder.CreateIndex(
                name: "IX_Enterprises_DateTaxReturnsId",
                table: "Enterprises",
                column: "DateTaxReturnsId");

            migrationBuilder.CreateIndex(
                name: "IX_Enterprises_EmployeesCompanyId",
                table: "Enterprises",
                column: "EmployeesCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Enterprises_PaymentsId",
                table: "Enterprises",
                column: "PaymentsId");

            migrationBuilder.CreateIndex(
                name: "IX_Enterprises_StatementsId",
                table: "Enterprises",
                column: "StatementsId");

            migrationBuilder.CreateIndex(
                name: "IX_Enterprises_TasksId",
                table: "Enterprises",
                column: "TasksId");

            migrationBuilder.CreateIndex(
                name: "IX_Enterprises_TransactionsId",
                table: "Enterprises",
                column: "TransactionsId");

            migrationBuilder.CreateIndex(
                name: "IX_Adrress_EnterprisesId",
                table: "Adrress",
                column: "EnterprisesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Regime_EnterprisesId",
                table: "Regime",
                column: "EnterprisesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Statements_DateTaxReturnsId",
                table: "Statements",
                column: "DateTaxReturnsId",
                unique: true,
                filter: "[DateTaxReturnsId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Statements_TransactionsId",
                table: "Statements",
                column: "TransactionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enterprises_Contacts_ContactsId",
                table: "Enterprises",
                column: "ContactsId",
                principalTable: "Contacts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enterprises_DateTaxReturns_DateTaxReturnsId",
                table: "Enterprises",
                column: "DateTaxReturnsId",
                principalTable: "DateTaxReturns",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enterprises_EmployeesCompany_EmployeesCompanyId",
                table: "Enterprises",
                column: "EmployeesCompanyId",
                principalTable: "EmployeesCompany",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enterprises_Payments_PaymentsId",
                table: "Enterprises",
                column: "PaymentsId",
                principalTable: "Payments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enterprises_Statements_StatementsId",
                table: "Enterprises",
                column: "StatementsId",
                principalTable: "Statements",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enterprises_Tasks_TasksId",
                table: "Enterprises",
                column: "TasksId",
                principalTable: "Tasks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Enterprises_Transactions_TransactionsId",
                table: "Enterprises",
                column: "TransactionsId",
                principalTable: "Transactions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Transactions_TransactionsId",
                table: "Tasks",
                column: "TransactionsId",
                principalTable: "Transactions",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Tasks_TasksId",
                table: "Users",
                column: "TasksId",
                principalTable: "Tasks",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enterprises_Contacts_ContactsId",
                table: "Enterprises");

            migrationBuilder.DropForeignKey(
                name: "FK_Enterprises_DateTaxReturns_DateTaxReturnsId",
                table: "Enterprises");

            migrationBuilder.DropForeignKey(
                name: "FK_Enterprises_EmployeesCompany_EmployeesCompanyId",
                table: "Enterprises");

            migrationBuilder.DropForeignKey(
                name: "FK_Enterprises_Payments_PaymentsId",
                table: "Enterprises");

            migrationBuilder.DropForeignKey(
                name: "FK_Enterprises_Statements_StatementsId",
                table: "Enterprises");

            migrationBuilder.DropForeignKey(
                name: "FK_Enterprises_Tasks_TasksId",
                table: "Enterprises");

            migrationBuilder.DropForeignKey(
                name: "FK_Enterprises_Transactions_TransactionsId",
                table: "Enterprises");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Transactions_TransactionsId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Tasks_TasksId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "Adrress");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "EmployeesCompany");

            migrationBuilder.DropTable(
                name: "ExchangeRates");

            migrationBuilder.DropTable(
                name: "Regime");

            migrationBuilder.DropTable(
                name: "Statements");

            migrationBuilder.DropTable(
                name: "DateTaxReturns");

            migrationBuilder.DropIndex(
                name: "IX_Users_TasksId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_TransactionsId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Enterprises_ContactsId",
                table: "Enterprises");

            migrationBuilder.DropIndex(
                name: "IX_Enterprises_DateTaxReturnsId",
                table: "Enterprises");

            migrationBuilder.DropIndex(
                name: "IX_Enterprises_EmployeesCompanyId",
                table: "Enterprises");

            migrationBuilder.DropIndex(
                name: "IX_Enterprises_PaymentsId",
                table: "Enterprises");

            migrationBuilder.DropIndex(
                name: "IX_Enterprises_StatementsId",
                table: "Enterprises");

            migrationBuilder.DropIndex(
                name: "IX_Enterprises_TasksId",
                table: "Enterprises");

            migrationBuilder.DropIndex(
                name: "IX_Enterprises_TransactionsId",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "TasksId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TransactionsId",
                table: "Tasks");

            migrationBuilder.DropColumn(
                name: "ContactsId",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "DateTaxReturnsId",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "EmployeesCompanyId",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "PaymentsId",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "Ruc",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "StatementsId",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "TasksId",
                table: "Enterprises");

            migrationBuilder.DropColumn(
                name: "TransactionsId",
                table: "Enterprises");

            migrationBuilder.AddColumn<Guid>(
                name: "EnterprisesId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "StatementId",
                table: "Transactions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Tasks",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UsersId",
                table: "Tasks",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "Payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_UsersId",
                table: "Tasks",
                column: "UsersId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_UsersId",
                table: "Tasks",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
