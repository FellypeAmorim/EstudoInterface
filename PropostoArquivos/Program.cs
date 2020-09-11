using PropostoArquivos.Entities;
using PropostoArquivos.Services;
using System;
using System.Globalization;

namespace PropostoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car Model: ");
            string carModel = Console.ReadLine();
            Console.Write("PickUp (dd/mm/yyyy  hh:mm): ");
            DateTime carStart = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.CurrentUICulture);
            Console.Write("Return (dd/mm/yyyy  hh:mm): ");
            DateTime carReturn = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(carStart, carReturn, new Vehicle(carModel));
            
            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine());
            Console.Write("Enter per day: ");
            double pricePerDay = double.Parse(Console.ReadLine());

            RentalService rentalService = new RentalService(pricePerHour, pricePerDay, new BrazilTaxService());

            rentalService.ProcessInvoice(carRental);

            Console.WriteLine();
            Console.WriteLine("Invoice: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
