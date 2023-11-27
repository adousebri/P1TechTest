using MediatR;
using P1Test.API.SECCI;
using P1Test.API.SECCI.Handlers;
using P1Test.API.SECCI.Requests;
using P1Test.Interfaces.API;
using P1Test.Interfaces.Services;
using P1Test.MiddleWare.Services;
using P1Test.Models.FrontEnd;
using RestSharp;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

builder.Services.AddTransient<IMiddleWareService, P1MiddleWare>();
builder.Services.AddTransient<IPortfolioDataAPI, SecciApi>();
builder.Services.AddTransient<IRestClient, RestClient>();
builder.Services.AddSingleton<ISecciClient, SecciClient>();

builder.Services.AddTransient<IRequestHandler<GetListPortFoliosRequest, PortFolioCollection>, GetListPortFoliosHandler>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapFallbackToFile("/index.html");

app.Run();
