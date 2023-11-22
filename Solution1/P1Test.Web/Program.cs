using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using P1Test.API.SECCI;
using P1Test.API.SECCI.Handlers;
using P1Test.Interfaces.API;
using P1Test.Interfaces.Services;
using P1Test.MiddleWare.Services;
using P1Test.Web.Data;
using RestSharp;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddMediatR(r =>
{
    r.RegisterServicesFromAssemblies(typeof(GetListPortFoliosHandler).GetType().Assembly);
});
builder.Services.AddTransient<IMiddleWareService, P1MiddleWare>();
builder.Services.AddTransient<IPortfolioDataAPI, SecciApi>();
builder.Services.AddTransient<IRestClient, RestClient>();
builder.Services.AddSingleton<ISecciClient, SecciClient>();
var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
