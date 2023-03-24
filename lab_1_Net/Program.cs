using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab_1_Net
{ 
    class Program
    {
        static void Main(string[] args)
        {


            var carRental = new CarRental
            {
                Cars = new List<Car>
                {
                    new Car { Make = "Toyota Camry", PricePerDay = 650, Year = 2021 },
                    new Car { Make = "Honda Civic", PricePerDay = 950, Year = 2020 },
                    new Car { Make = "Ford Mustang", PricePerDay = 1000, Year = 2004 },
                    new Car { Make = "Mersedes 124", PricePerDay = 1015, Year = 1995 }
                },

                Customers = new List<Customer>
                {
                   new Customer { FullName = "John Doe", Address = "123 Main St", PhoneNumber = "555-1234" },
                   new Customer { FullName = "Jane Smith", Address = "456 Oak St", PhoneNumber = "555-5678" },
                   new Customer { FullName = "Bob Johnson", Address = "789 Elm St", PhoneNumber = "555-9012" }
                },

                Rentals = new List<Rental>
                {
                    new Rental
                    {
                        Car = new Car { Make = "Toyota Camry", PricePerDay = 50.0m, Year = 2021 },
                        Customer = new Customer { FullName = "John Doe", Address = "123 Main St", PhoneNumber = "555-1234" },
                        RentalDate = new DateTime(2023, 03, 20),
                        ExpectedReturnDate = new DateTime(2023, 03, 23),
                        DepositAmount = 100.0m,
                        RentalAmount = 150.0m
                    },
                    new Rental
                    {
                       Car = new Car { Make = "Ford Mustang", PricePerDay = 100.0m, Year = 2019 },
                       Customer = new Customer { FullName = "Jane Smith", Address = "456 Oak St", PhoneNumber = "555-5678" },
                       RentalDate = new DateTime(2023, 03, 21),
                       ExpectedReturnDate = new DateTime(2023, 03, 23),
                       DepositAmount = 200.0m,
                       RentalAmount = 300.0m
                    },
                  new Rental
                  {
                        Car = new Car { Make = "Honda Civic", PricePerDay = 45.0m, Year = 2020 },
                        Customer = new Customer { FullName = "Bob Johnson", Address = "789 Elm St", PhoneNumber = "555-9012" },
                        RentalDate = new DateTime(2023, 03, 22),
                        ExpectedReturnDate = new DateTime(2023, 03, 24),
                        DepositAmount = 150.0m,
                        RentalAmount = 225.0m
                  }
                }    
            };
            
            //1. Відсортувати список клієнтів за повним ім'ям в алфавітному порядку:
            var sortedCustomers = carRental.Customers.OrderBy(c => c.FullName);
            foreach (var customer in sortedCustomers)
            {
                Console.WriteLine(customer.FullName);
            }

            Console.WriteLine("========================================================================================");
            //2. Відсортувати список прокатів за датою прокату в зростаючому порядку:
            var sortedRentals = from r in carRental.Rentals
                                orderby r.RentalDate
                                select r;
            foreach (var rental in sortedRentals)
            {
                Console.WriteLine($"Car make: {rental.Car.Make}");
                Console.WriteLine($"Customer name: {rental.Customer.FullName}");
                Console.WriteLine($"Rental date: {rental.RentalDate.ToShortDateString()}");
                Console.WriteLine($"Expected return date: {rental.ExpectedReturnDate.ToShortDateString()}");
                Console.WriteLine($"Deposit amount: {rental.DepositAmount:C}");
                Console.WriteLine($"Rental amount: {rental.RentalAmount:C}");
                Console.WriteLine();
            }
            Console.WriteLine("========================================================================================");

            //3. Відсортувати список машин за ціною прокату за день від найбільшої до найменшої:
            var sortedCars = carRental.Cars.OrderByDescending(c => c.PricePerDay);
            foreach (var car in sortedCars)
            {
                Console.WriteLine($"Make: {car.Make}, Price per day: {car.PricePerDay:C}, Year: {car.Year}");
            }
            Console.WriteLine("========================================================================================");

            //4. Відсортувати список клієнтів за кількістю символів у номері телефону від меншої до більшої

            var sortedCustomer = carRental.Customers.OrderBy(c => c.PhoneNumber.Length);

            foreach (var customer in sortedCustomer)
            {
                Console.WriteLine($"Name: {customer.FullName}, Phone Number: {customer.PhoneNumber}");
            }
            Console.WriteLine("========================================================================================");


            //5. Відсортувати список прокатів за сумою депозиту від найбільшої до найменшої:
            var sortedRental = from r in carRental.Rentals
                                orderby r.DepositAmount descending
                                select r;
            foreach (var rental in sortedRental)
            {
                Console.WriteLine($"Car make and model: {rental.Car.Make}, {rental.Car.Year}");
                Console.WriteLine($"Rental customer: {rental.Customer.FullName}, {rental.Customer.Address}, {rental.Customer.PhoneNumber}");
                Console.WriteLine($"Rental date: {rental.RentalDate.ToShortDateString()}");
                Console.WriteLine($"Expected return date: {rental.ExpectedReturnDate.ToShortDateString()}");
                Console.WriteLine($"Deposit amount: {rental.DepositAmount:C}");
                Console.WriteLine($"Rental amount: {rental.RentalAmount:C}\n");
            }
            Console.WriteLine("========================================================================================");


         

            //6. Групування клієнтів по першій літері прізвища, а потім відображення кількості клієнтів в кожній групі

            var customerGroups = from c in carRental.Customers
                                 group c by c.FullName[0] into g
                                 select new
                                 {
                                     FirstLetter = g.Key,
                                     Count = g.Count()
                                 };
            foreach (var group in customerGroups)
            {
                Console.WriteLine($"Customers with names starting with {group.FirstLetter}: {group.Count}");
            }
            Console.WriteLine("========================================================================================");

            // 7. Кількість оренд кожного автомобіля за всі періоди:
            var rentalGroups = carRental.Rentals
                    .GroupBy(r => r.Car)
                    .Select(g => new
                    {
                        Car = g.Key,
                        TotalRentals = g.Count()
                    });

            foreach (var group in rentalGroups)
            {
                Console.WriteLine($"Car: {group.Car.Make} {group.Car.Year}, Total Rentals: {group.TotalRentals}");
            }
            Console.WriteLine("========================================================================================");

            //8. Групування орендованих автомобілів по році випуску, а потім відображення середнього депозиту для кожної групи
            var rentalGroup = carRental.Rentals
                .GroupBy(r => r.Car.Year)
                .Select(g => new
                {
                    Year = g.Key,
                    AvgDeposit = g.Average(r => r.DepositAmount)
                });

            foreach (var group in rentalGroup)
            {
                Console.WriteLine($"Year: {group.Year}, Average Deposit: {group.AvgDeposit:C}");
            }

            Console.WriteLine("========================================================================================");
            //9. Загальна сума оренди для кожного клієнта
            var rentalGroupss = carRental.Rentals
                   .GroupBy(r => r.Customer)
                   .Select(g => new
                   {
                       Customer = g.Key,
                       TotalRentalAmount = g.Sum(r => r.RentalAmount)
                   });
            foreach (var group in rentalGroupss)
            {
                Console.WriteLine($"Customer: {group.Customer.FullName}, Total Rental Amount: {group.TotalRentalAmount}");
            }

            Console.WriteLine("========================================================================================");
            //10. Групувати об'єкти  за маркою автомобіля та обчислювати середню суму орендної плати для кожної марки
            var rentalGroupses = from r in carRental.Rentals
                                 group r by r.Car.Make into g
                                 select new
                                 {
                                     CarMake = g.Key,
                                     AverageRentalAmount = g.Average(r => r.RentalAmount)
                                 };

            foreach (var rental in rentalGroupses)
            {
                Console.WriteLine($"Car Make: {rental.CarMake}, Average Rental Amount: {rental.AverageRentalAmount:C}");
            }

            Console.WriteLine("========================================================================================");
            //11. Вибираються машини, які мають властивість рівні певному клієнту

            
            var rentalsByCustomer = carRental.Rentals.Where(r => r.Customer.FullName == "John Doe");
            foreach (var rental in rentalsByCustomer)
            {
                Console.WriteLine($"Car: {rental.Car}, Rental date: {rental.RentalDate}, Rental amount: {rental.RentalAmount}");
            }

            Console.WriteLine("=========================================================================================");

            //12. Об'єкти зі списку carRental.Rentals машини, які мають властивість ціну оренди, більшу ніж 200.0
            var expensiveRentals = from r in carRental.Rentals
                                   where r.RentalAmount > 200.0m
                                   select r;
            foreach (var rental in expensiveRentals)
            {
                Console.WriteLine($" Car: {rental.Car.Make} , Amount: {rental.RentalAmount}");
            }

            Console.WriteLine("========================================================================================");

            //13. Об'єкти зі списку carRental.Cars машини, які мають рівну року випуску 2021
            var carsByYear = carRental.Cars.Where(c => c.Year == 2021);

            
            foreach (var car in carsByYear)
            {
                Console.WriteLine($"{car.Make}  - {car.Year}");
            }
            Console.WriteLine("========================================================================================");

            //14. Обераються машини, що попадають в діапазон між 21 березня 2023 року та 22 березня 2023 року оренди.

            var rentalsByDate = from r in carRental.Rentals
                                where r.RentalDate >= new DateTime(2023, 03, 21) && r.RentalDate <= new DateTime(2023, 03, 22)
                                select r;
            foreach (var rental in rentalsByDate)
            {
                Console.WriteLine($"{rental.Customer.FullName} rented {rental.Car.Make} on {rental.RentalDate.ToShortDateString()}  paying {rental.RentalAmount:C} with a deposit of {rental.DepositAmount:C}");
            }
            Console.WriteLine("========================================================================================");

            //15. Обераються машини, що попадають в діапазон між 150.0 та 200.0.
            var rentalsByDeposit = carRental.Rentals.Where(r => r.DepositAmount >= 150.0m && r.DepositAmount <= 200.0m);
            foreach (var rental in rentalsByDeposit)
            {
                Console.WriteLine($" Car: {rental.Car.Make} , Customer: {rental.Customer.FullName}, Deposit Amount: {rental.DepositAmount:C}");
            }
            Console.WriteLine("========================================================================================");

            //16. Знайти кількість оренд авто кожного бренду.
            var carRentalsByMake = from rental in carRental.Rentals
                                   group rental by rental.Car.Make into carGroup
                                   select new { Make = carGroup.Key, RentalCount = carGroup.Count() };
            foreach (var group in carRentalsByMake)
            {
                Console.WriteLine($"Make: {group.Make}, Rental Count: {group.RentalCount}");
            }
            Console.WriteLine("========================================================================================");

            //17.Знайти середній термін оренди авто, які були орендовані.
            var averageCarAge = carRental.Cars
                     .Select(car => DateTime.Now.Year - car.Year)
                     .Average();
            Console.WriteLine(averageCarAge);
            Console.WriteLine("========================================================================================");

            //18.Знайти найбільшу суму оренди серед усіх оренд.
            var maxRentalAmount = carRental.Rentals
                       .Select(rental => rental.RentalAmount)
                       .Max();
            Console.WriteLine(maxRentalAmount);
            Console.WriteLine("========================================================================================");
            //19. Знайти суму депозитів усіх оренд.
            var totalDeposits = carRental.Rentals
                     .Select(rental => rental.DepositAmount)
                     .Sum();
            Console.WriteLine($"Total deposits: {totalDeposits}");
            Console.WriteLine("========================================================================================");
            //20. Групування орендованих автомобілів по клієнту, а потім відображення загальної суми оренди для кожного клієнта.
            var rentalByCustomer = carRental.Rentals
                                .GroupBy(r => r.Customer.FullName)
                                .Select(g => new { Customer = g.Key, TotalRentalAmount = g.Sum(r => r.RentalAmount) });

            foreach (var rental in rentalByCustomer)
            {
                Console.WriteLine($"Customer: {rental.Customer}, Total Rental Amount: {rental.TotalRentalAmount}");
            }






        }



    }
    
}
