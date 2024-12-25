using Contable.Api.Services;
using Contable.Application;
using Contable.Infrastructure;
using FluentValidation.AspNetCore;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddInfrastructure();
    builder.Services.AddControllers();
    builder.Services.AddAutoMapper(typeof(UserMapping));

    builder.Services.AddApplication();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");

    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
