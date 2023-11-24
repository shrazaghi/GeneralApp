using App.API.GraphQL.Queries;
using App.Repository.Contexts;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using GeneralApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.Configure(services => services.AddAutoFac());
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services
    .AddGraphQLServer()
    .RegisterDbContext<AppReadDbContext>()
    //.AddQueryType<HelloWorldQuery>()
    .AddQueryType<ProductQuery>();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory())
    .ConfigureContainer<ContainerBuilder>(builder =>
    {
        builder.RegisterModule(new AutoFacServicesModule());
    });

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGraphQL();

app.MapControllers();

app.Run();
