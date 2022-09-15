using Business.Abstract;
using Business.Concrete;
using DataAcces.Abstract;
using DataAcces.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSingleton<ICarService, CarManager>();//Burada ayn� �ekilde ba��ml�l�klardan kurtulmak i�in yap�lan bir yap�d�r.
//Bu yap�da ICarService'i g�r�rsen e�er CarManager'� new'le anlma�na gelmketedir.
builder.Services.AddSingleton<ICarDal, EfCarDal>();//Burada ise ICarDal g�r�rsen,EfCarDal new'le anlam�na gelmektedir.

//BRANDS
builder.Services.AddSingleton<IBrandService, BrandManager>();
builder.Services.AddSingleton<IBrandDal, EfBrandDal>();

//Colors
builder.Services.AddSingleton<IColorService, ColorManager>();
builder.Services.AddSingleton<IColorDal, EfColorDal>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
