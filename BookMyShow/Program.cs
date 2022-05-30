using SimpleInjector;
using BookMyShow.Models.CoreModels;
using BookMyShow.DataModels;
using BookMyShow.Interface;
using BookMyShow.Services;
using BookMyShow.Models;
using SimpleInjector.Lifestyles;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddMvcCore();
builder.Services.AddAutoMapper(typeof(MapperClass));
var container = new Container();
container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
builder.Services.AddSimpleInjector(container, options =>
{
    options.AddAspNetCore().AddControllerActivation();
});
container.Register<ICustomerService, CustomerService>();
container.Register<IMovieService, MovieService>();
container.Register<ITheaterService, TheaterService>();
container.Register<ITheaterHallService, TheaterHallService>();
container.Register<IShowService, ShowService>();
container.Register<IBookingService, BookingService>();
container.Register<ICityService, CityService>();
container.Register<ICustomerSeatService, CustomerSeatService>();
container.Register<ISeatService, SeatService>();



builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.AddCors(cors => cors.AddPolicy("MyPolicy", builder =>
{
    builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
}));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.Services.UseSimpleInjector(container);
container.Verify();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseCors("MyPolicy");
app.UseAuthorization();

app.MapControllers();

app.Run();
