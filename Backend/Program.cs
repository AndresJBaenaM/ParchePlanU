using ApiParchePlanU.DAO;
using ApiParchePlanU.Interfaces;
using ApiParchePlanU.Models;
using ApiParchePlanU.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi;
using Scalar.AspNetCore;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;

var builder = WebApplication.CreateBuilder(args);

//Extraemos del archivo appsettings.json la cadena de conexión a la base de datos
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

//Configuramos Entity Framework con SQL Server
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

//Configuramos Identity usando nuestro modelo User
builder.Services.AddIdentity<User, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequiredLength = 8;
    options.Password.RequireNonAlphanumeric = false;
})
.AddEntityFrameworkStores<ApplicationDbContext>()
.AddDefaultTokenProviders();


//Configuración de autenticación con JWT
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,

        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],

        IssuerSigningKey = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!))
    };
});


//Registro de Services del proyecto
builder.Services.AddScoped<IParcheService, ParcheService>();
builder.Services.AddScoped<IPlanService, PlanService>();
builder.Services.AddScoped<IVoteService, VoteService>();
builder.Services.AddScoped<IAttendanceService, AttendanceService>();
builder.Services.AddScoped<IRankingServices, RankingService>();


//Auth service
builder.Services.AddScoped<IAuthService, AuthService>();


//Controllers
builder.Services.AddControllers();


//OpenAPI (documentación)
builder.Services.AddOpenApi();

var app = builder.Build();


//Pipeline de ejecución
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    //Documentación interactiva
    app.MapScalarApiReference();
}


app.UseHttpsRedirection();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    // Asegura que la BD esté creada
    var dbContext = services.GetRequiredService<ApplicationDbContext>();
    dbContext.Database.Migrate();

    // Ejecuta seed de usuarios (SIN problemas de await)
    SeedUsersAsync(services).GetAwaiter().GetResult();
}

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

async Task SeedUsersAsync(IServiceProvider services)
{
    var userManager = services.GetRequiredService<UserManager<User>>();
    var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

    string[] roles = { "Admin", "User" };

    // Crear roles
    foreach (var role in roles)
    {
        if (!await roleManager.RoleExistsAsync(role))
        {
            await roleManager.CreateAsync(new IdentityRole(role));
        }
    }

    // Usuario 1
    if (await userManager.FindByEmailAsync("user1@test.com") == null)
    {
        var user1 = new User
        {
            UserName = "user1@test.com",
            Email = "user1@test.com",
            NombreCompleto = "Juan Pérez",
            Programa = "Ingeniería"
        };

        var result = await userManager.CreateAsync(user1, "12345678");

        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(user1, "Admin");
        }
    }

    // Usuario 2
    if (await userManager.FindByEmailAsync("user2@test.com") == null)
    {
        var user2 = new User
        {
            UserName = "user2@test.com",
            Email = "user2@test.com",
            NombreCompleto = "María López",
            Programa = "Diseño"
        };

        var result = await userManager.CreateAsync(user2, "12345678");

        if (result.Succeeded)
        {
            await userManager.AddToRoleAsync(user2, "User");
        }
    }
}