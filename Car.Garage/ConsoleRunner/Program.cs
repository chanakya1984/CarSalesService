// See https://aka.ms/new-console-template for more information

using Car.Garage.Repository.DbContext;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");
var context = new CarOnBoardingContext();
await CarOnBoardingContext.AddSeedData();

