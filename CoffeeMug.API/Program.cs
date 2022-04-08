



using CoffeeMug.Data.IRepository;
using CoffeeMug.Data.ModelDbContext;
using CoffeeMug.Data.Repository;
using CoffeeMug.Logic.ILogic;
using CoffeeMug.Logic.Logic;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddScoped<IProductRepository, ProductRepostiory>();
builder.Services.AddScoped<IProductLogic, ProductLogic>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => c.EnableAnnotations());
builder.Services.AddDbContext<ProductDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("SqlServer"),
        x => x.MigrationsAssembly("CoffeeMug.Data")));


var app = builder.Build();


// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
