using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using TCA.Business.Concrete;
using TCA.Business.GenericService;
using TCA.Business.Interface;
using TCA.DataAccess.Context;
using TCA.DataAccess.DataContracts;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IPersonsService, PersonsManager>();
builder.Services.AddScoped(typeof(IHttpGenericService<>), typeof(HttpGenericService<>));
builder.Services.AddScoped<IPeoplesSourceAccessService, PeopleSourceAccessManager>();
builder.Services.AddScoped<IPersonsPositionsDR, PersonPositionsDRManager>();
builder.Services.AddScoped<IPersonsPositionsHolding, PersonsPositionsHoldingManager>();
builder.Services.AddScoped<IAdressesHoldingService, AdressesHoldingManager>();
builder.Services.AddScoped<IActivePassiveUsersService, ActivePassiveUsersManager>();
builder.Services.AddScoped<IOrganizationLewelHoldingService, OrganizationLewelHoldingManager>();
builder.Services.AddScoped<IOrganizationLewelDrService, OrganizationLewelDRManager>();
builder.Services.AddScoped<IAllPersonsInfoDRServices, AllPersonsInfoDRManager>();
builder.Services.AddScoped<IAllPersonsInfoService, AllPersonsInfoManager>();

#region JWT TOKEN - 1
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("V1", new OpenApiInfo
    {
        Version = "V1",
        Title = "TURKUVAZ Collective ",
        Description = "Colletive WebAPI"
    });
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Description = "Bearer Authentication with JWT Token",
        Type = SecuritySchemeType.Http
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement {
        {
            new OpenApiSecurityScheme {
                Reference = new OpenApiReference {
                    Id = "Bearer",
                        Type = ReferenceType.SecurityScheme
                }
            },
            new List < string > ()
        }
    });
});

#endregion

#region DataBase 
//appsetting.json dosyasýndan çekiyoruz.
builder.Services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("CollectiveConnection")));

#endregion

#region Temp Db 
builder.Services.AddDbContext<CollectiveServiceTestDBContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("CollectiveServiceConnection")));
#endregion

#region JWT TOKEN - 2
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(o =>
{
    o.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey
        (Encoding.UTF8.GetBytes(builder.Configuration["Jwt:key"])),
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = false,
        ValidateIssuerSigningKey = true
    };
});
#endregion

builder.Services.AddAuthorization();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();

    #region Swagerr

    app.UseSwaggerUI(options =>
    {

        options.SwaggerEndpoint("/swagger/V1/swagger.json", "Product WebAPI");
    });
    #endregion

}
app.UseAuthentication();
app.UseRouting();
app.UseAuthorization();
app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
app.UseHttpsRedirection();


app.MapControllers();

app.Run();
