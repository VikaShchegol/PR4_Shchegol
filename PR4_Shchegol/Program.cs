using System;

namespace TownApp
{
    class Town
    {
        public string Name;
        public string Country;
        public string Region;
        public int Population;
        public double YearIncome;
        public double Square;
        public bool HasPort;
        public bool HasAirport;

        public double GetYearIncomePerInhabitant()
        {
            if (Population == 0)
            {
                return 0;
            }

            return YearIncome / Population;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter city name: ");
            string name = Console.ReadLine();

            Console.Write("Enter country name: ");
            string country = Console.ReadLine();

            Console.Write("Enter region name: ");
            string region = Console.ReadLine();

            Console.Write("Enter population: ");
            int population;
            bool isValidPopulation = int.TryParse(Console.ReadLine(), out population);
            if (!isValidPopulation)
            {
                Console.WriteLine("Invalid population value. Setting to 0.");
                population = 0;
            }

            Console.Write("Enter yearly income: ");
            double yearIncome = double.Parse(Console.ReadLine());

            Console.Write("Enter square: ");
            double square = double.Parse(Console.ReadLine());

            Console.Write("Does the city have a port (true/false): ");
            bool hasPort = bool.Parse(Console.ReadLine());

            Console.Write("Does the city have an airport (true/false): ");
            bool hasAirport = bool.Parse(Console.ReadLine());

            Town town = new Town();
            town.Name = name;
            town.Country = country;
            town.Region = region;
            town.Population = population;
            town.YearIncome = yearIncome;
            town.Square = square;
            town.HasPort = hasPort;
            town.HasAirport = hasAirport;

            // Outputting city information
            Console.WriteLine();
            Console.WriteLine("~City Information~");
            Console.WriteLine();
            Console.WriteLine($"Name: {town.Name}");
            Console.WriteLine($"Country: {town.Country}");
            Console.WriteLine($"Region: {town.Region}");
            Console.WriteLine($"Population: {town.Population}");
            Console.WriteLine($"Yearly Income: {town.YearIncome}");
            Console.WriteLine($"Square: {town.Square}");
            Console.WriteLine($"Has Port: {town.HasPort}");
            Console.WriteLine($"Has Airport: {town.HasAirport}");

            // Calculating and outputting average yearly income per inhabitant
            double incomePerInhabitant = town.GetYearIncomePerInhabitant();
            Console.WriteLine($"Average Yearly Income Per Inhabitant: {incomePerInhabitant}");
        }
    }
}
