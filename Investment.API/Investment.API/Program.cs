using Investment.Application.Repositories;
using Investment.Application.Repositories.Interfaces;
using Investment.Application.UnitOfWork;
using Investment.Application.UnitOfWork.Interfaces;
using Investment.Data;
using Investment.Domain.Entities.Assets;
using Investment.Domain.Entities.Core;
using Microsoft.EntityFrameworkCore;

namespace Investment.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<ApplicationDbContext>(opt =>
            {
                opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            builder.Services.AddScoped<IGenericRepository<AppUser>, GenericRepository<AppUser>>();
            builder.Services.AddScoped<IGenericRepository<AgriCultureProperty>, GenericRepository<AgriCultureProperty>>();
            builder.Services.AddScoped<IGenericRepository<Bank>, GenericRepository<Bank>>();
            builder.Services.AddScoped<IGenericRepository<Cash>, GenericRepository<Cash>>();
            builder.Services.AddScoped<IGenericRepository<CommercialProperty>, GenericRepository<CommercialProperty>>();
            builder.Services.AddScoped<IGenericRepository<FixedDeposit>, GenericRepository<FixedDeposit>>();
            builder.Services.AddScoped<IGenericRepository<Jewellery>, GenericRepository<Jewellery>>();
            builder.Services.AddScoped<IGenericRepository<MutualFund>, GenericRepository<MutualFund>>();
            builder.Services.AddScoped<IGenericRepository<NationalSavingCertificate>, GenericRepository<NationalSavingCertificate>>();
            builder.Services.AddScoped<IGenericRepository<OtherProperty>, GenericRepository<OtherProperty>>();
            builder.Services.AddScoped<IGenericRepository<PersonalProvidentFund>, GenericRepository<PersonalProvidentFund>>();
            builder.Services.AddScoped<IGenericRepository<PostOfficeSaving>, GenericRepository<PostOfficeSaving>>();
            builder.Services.AddScoped<IGenericRepository<ProvidentFund>, GenericRepository<ProvidentFund>>();
            builder.Services.AddScoped<IGenericRepository<ResedentialProperty>, GenericRepository<ResedentialProperty>>();
            builder.Services.AddScoped<IGenericRepository<Stock>, GenericRepository<Stock>>();
            builder.Services.AddScoped<IGenericRepository<Vehicle>, GenericRepository<Vehicle>>();
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
        }
    }
}