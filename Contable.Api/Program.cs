using Contable.Application;
using Contable.Infrastructure;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddInfrastructure();
    builder.Services.AddControllers();
    builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

    builder.Services.AddApplication();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("Commands", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title = "Contable API - Commands",
                Version = "v1",
                Description = "APIs for Create, Update and Delete"

            });

            options.SwaggerDoc("Queries", new Microsoft.OpenApi.Models.OpenApiInfo
            {
                Title = "Contable API - Queries",
                Version = "v1",
                Description = "APIs for Get and List"
            });

            options.DocInclusionPredicate((docName, apiDesc) =>
            {
               var groupName = apiDesc.GroupName;
                return string.IsNullOrEmpty(groupName) || docName.Equals(groupName, StringComparison.OrdinalIgnoreCase);
            });
        });
}

var app = builder.Build();
{
    app.UseExceptionHandler("/error");

    app.UseSwagger();
    app.UseSwaggerUI(options =>
        {
            options.SwaggerEndpoint("/swagger/Commands/swagger.json", "Contable API - Commands");
            options.SwaggerEndpoint("/swagger/Queries/swagger.json", "Contable API - Queries");
        });
    app.UseHttpsRedirection();
    app.UseAuthorization();
    app.MapControllers();
    app.Run();
}
