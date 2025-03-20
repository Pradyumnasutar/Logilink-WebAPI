using DeliveryOrdersWebApi.Controllers;
using DeliveryOrdersWebApi.DAL;
using eSupplier_Lib.Data;
using LES_USER_ADMINISTRATION_LIB.DAL;
using Logistic_Management_Lib;
using Logistic_Management_Lib.DAL;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

using static System.Runtime.InteropServices.JavaScript.JSType;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var jwtIssuer = builder.Configuration.GetSection("Jwt:Issuer").Get<string>();
var jwtKey = builder.Configuration.GetSection("Jwt:Key").Get<string>();

builder.Services.AddControllers();

//builder.Services.AddIdentityServer()
//    .AddInMemoryIdentityResources(new List<IdentityServer4.Models.IdentityResource>
//    {
//        new IdentityResources.OpenId(),
//        new IdentityResources.Profile(),
//    })
//    .AddInMemoryApiScopes(new List<ApiScope>
//    {
//        new ApiScope("api1", "My API")
//    })
//    .AddInMemoryClients(new List<Client>
//    {
//        new Client
//        {
//            ClientId = "client",
//            AllowedGrantTypes = GrantTypes.ClientCredentials,
//            ClientSecrets =
//            {
//                new IdentityServer4.Models.Secret("secret".Sha256())
//            },
//            AllowedScopes = { "api1" },
//            AccessTokenLifetime = 3600, // 1 hour
//            AbsoluteRefreshTokenLifetime = 2592000, // 30 days
//            SlidingRefreshTokenLifetime = 1296000, // 15 days
//            AllowOfflineAccess = true // Required for refresh tokens
//        }
//    })
//    .AddDeveloperSigningCredential();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        //options.Authority = "https://localhost:7193";
        options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
        {
            ValidateAudience = false,
            ValidIssuer = jwtIssuer,
            ValidAudience = jwtIssuer,
            ClockSkew = TimeSpan.Zero,
            IssuerSigningKey = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(jwtKey))
        };
        options.Events = new JwtBearerEvents
        {
            OnChallenge = context =>
            {
                context.HandleResponse();
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = 403;
                return context.Response.WriteAsync("{\"message\":\"Token expired\"}");
            }
        };
    });

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<DeliveryOrderDbContext>(options => options.UseSqlServer
//(builder.Configuration.GetConnectionString("MyConnectionString")));

//builder.Services.AddDbContext<DeliveryOrderDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString")));

builder.Services.AddDbContext<DeliveryOrderDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnectionString"),
    sqlServerOptions => sqlServerOptions.EnableRetryOnFailure()));

builder.Services.AddDbContext<LogisticDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LogisticConnectionString"),
    sqlServerOptions => sqlServerOptions.EnableRetryOnFailure()));

builder.Services.AddDbContext<UserAdminDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("UserAdminConnectionString"),
    sqlServerOptions => sqlServerOptions.EnableRetryOnFailure()));

builder.Services.AddDbContext<ESupplierConlashContext>(options=>
options.UseSqlServer(builder.Configuration.GetConnectionString("eSupplierConnectionString"),
    sqlServerOptions => sqlServerOptions.EnableRetryOnFailure()));


builder.Services.AddScoped<LogisticManagementV2Class>();
var app = builder.Build();

app.UseCors(
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting(); // added 28/06/23

app.UseHttpsRedirection();

//app.UseIdentityServer();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
