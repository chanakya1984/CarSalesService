namespace Car.Garage.Repository.DbContext;

using Entities;
using Microsoft.EntityFrameworkCore;

public class CarOnBoardingContext : DbContext
{
    public DbSet<CarModel> Cars { get; set; }
    public DbSet<CarOnBoarding> CarsOnBoarding { get; set; }
    public DbSet<Insurance> Insurances { get; set; }
    public DbSet<Manufacturer> Manufacturers { get; set; }
    public DbSet<PollutionCertificate> PollutionCertificates { get; set; }
    public DbSet<RcBook> RcBooks { get; set; }

    public CarOnBoardingContext(DbSet<CarModel> cars, DbSet<CarOnBoarding> carsOnBoarding, DbSet<Insurance> insurances, DbSet<Manufacturer> manufacturers, DbSet<PollutionCertificate> pollutionCertificates, DbSet<RcBook> rcBooks)
    {
        this.Cars = cars;
        this.CarsOnBoarding = carsOnBoarding;
        this.Insurances = insurances;
        this.Manufacturers = manufacturers;
        this.PollutionCertificates = pollutionCertificates;
        this.RcBooks = rcBooks;
    }

    public CarOnBoardingContext(DbContextOptions<CarOnBoardingContext> options, DbSet<CarModel> cars, DbSet<CarOnBoarding> carsOnBoarding, DbSet<Insurance> insurances, DbSet<Manufacturer> manufacturers, DbSet<PollutionCertificate> pollutionCertificates, DbSet<RcBook> rcBooks)
    {
        this.Cars = cars;
        this.CarsOnBoarding = carsOnBoarding;
        this.Insurances = insurances;
        this.Manufacturers = manufacturers;
        this.PollutionCertificates = pollutionCertificates;
        this.RcBooks = rcBooks;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseCosmos(
            "https://localhost:8081",
            "C2y6yDjf5/R+ob0N8A7Cgv30VRDJIWEHLM+4QDU5DE2nQ9nDuVTqobD4b8mGGyPMbIZnqyMsEcaGQy67XIw/Jw==",
            databaseName: nameof(CarOnBoardingContext));

    public static async Task AddSeedData()
    {
        await using var context = new CarOnBoardingContext();
        var _ = await context.Database.EnsureDeletedAsync();
        if (await context.Database.EnsureCreatedAsync())
        {
            //var entity = new Manufacturer
            //{
            //    Id = 0,
            //    Name = "Test 1"
            //};
            //context.Manufacturers.Add(entity);
            var entity = new Manufacturer() {Name = "Test 2"};
            var entity2 = new Manufacturer() { Name = "Test 3" };
            context.Manufacturers.Add(entity);
            context.Manufacturers.Add(entity2);
            await context.SaveChangesAsync();
        }
    }
}
