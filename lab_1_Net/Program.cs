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
                    new Car { Make = "Mersedes 124", PricePerDay = 1015, Year = 1995 },
                    new Car { Make = "BMW X3 E83", PricePerDay = 1015, Year = 2021 },
                    new Car { Make = "BMW X5 E83", PricePerDay = 134, Year = 2021 },
                    new Car { Make = "Volkswagen Touran ", PricePerDay = 134, Year = 2014 },
                },

                Customers = new List<Customer>
                {
                   new Customer { FullName = "Стефанiвський Iлля", Address = "м.Київ, вул. Скоропадського 47", PhoneNumber = "067-478-695" },
                   new Customer { FullName = "Коваль Марина", Address = "м.Київ, вул.Незалежності 18", PhoneNumber = "098-785-365" },
                   new Customer { FullName = "Андрусенко Микита", Address = "м.Київ, вул. Шевченко 78", PhoneNumber = "096-487-324" },
                   new Customer { FullName = "Грабовський Олег", Address = "м.Київ, вул.Короленка 14", PhoneNumber = "095-478-214" },
                   new Customer { FullName = "Поводир Максим", Address = "м.Київ, вул. Довженка 65", PhoneNumber = "067-785-314" },
                   new Customer { FullName = "Кравченко Iрина", Address = "м.Київ, вул. Достоєвського 96", PhoneNumber = "098-458-364" }
                },

                Rentals = new List<Rental>
                {
                    new Rental
                    {
                        Car = new Car { Make = "Toyota Camry", PricePerDay = 650, Year = 2021 },
                        Customer = new Customer { FullName = "Стефанiвський Iлля", Address = "м.Київ, вул. Скоропадського 47", PhoneNumber = "067-478-695" },
                        RentalDate = new DateTime(2023, 03, 20),
                        ExpectedReturnDate = new DateTime(2023, 03, 23),
                        DepositAmount = 300,
                        RentalAmount = 1950
                    },
                    new Rental
                    {
                       Car = new Car { Make = "Honda Civic", PricePerDay = 950, Year = 2020 },
                       Customer =  new Customer { FullName = "Коваль Марина", Address = "м.Київ, вул.Незалежності 18", PhoneNumber = "098-785-365" },
                       RentalDate = new DateTime(2022, 12, 21),
                       ExpectedReturnDate = new DateTime(2023, 01, 23),
                       DepositAmount = 4000,
                       RentalAmount = 21850
                    },
                  new Rental
                  {
                        Car =  new Car { Make = "Ford Mustang", PricePerDay = 1000, Year = 2004 },
                        Customer =  new Customer { FullName = "Андрусенко Микита", Address = "м.Київ, вул. Шевченко 78", PhoneNumber = "096-487-324" },
                        RentalDate = new DateTime(2022, 05, 20),
                        ExpectedReturnDate = new DateTime(2022, 06, 10),
                        DepositAmount = 7510,
                        RentalAmount = 20000
                  },
                  new Rental
                    {
                        Car = new Car { Make = "Mersedes 124", PricePerDay = 1015, Year = 1995 },
                        Customer = new Customer { FullName = "Грабовський Олег", Address = "м.Київ, вул.Короленка 14", PhoneNumber = "095-478-214" },
                        RentalDate = new DateTime(2023, 02, 20),
                        ExpectedReturnDate = new DateTime(2023, 02, 24),
                        DepositAmount = 852,
                        RentalAmount = 4000
                    },
                  new Rental
                    {
                        Car = new Car { Make = "BMW X3 E83", PricePerDay = 1015, Year = 2021 },
                        Customer = new Customer { FullName = "Поводир Максим", Address = "м.Київ, вул. Довженка 65", PhoneNumber = "067-785-314" },
                        RentalDate = new DateTime(2023, 03, 08),
                        ExpectedReturnDate = new DateTime(2023, 03, 10),
                        DepositAmount = 654,
                        RentalAmount = 4000
                    },
                  new Rental
                    {
                        Car = new Car { Make = "BMW X5 E83", PricePerDay = 1015, Year = 2021 },
                        Customer = new Customer { FullName = "Стефанiвський Iлля", Address = "м.Київ, вул. Скоропадського 47", PhoneNumber = "067-478-695" },
                        RentalDate = new DateTime(2023, 03, 08),
                        ExpectedReturnDate = new DateTime(2023, 03, 10),
                        DepositAmount = 654,
                        RentalAmount = 4000
                    },
                  new Rental
                    {
                        Car = new Car { Make = "Volkswagen Touran ", PricePerDay = 134, Year = 2014 },
                        Customer =  new Customer { FullName = "Кравченко Iрина", Address = "м.Київ, вул. Достоєвського 96", PhoneNumber = "098-458-364" },
                        RentalDate = new DateTime(2023, 03, 08),
                        ExpectedReturnDate = new DateTime(2023, 03, 10),
                        DepositAmount = 654,
                        RentalAmount = 4000
                    },
                }    
            };

            //1. Відсортувати список клієнтів за повним ім'ям в алфавітному порядку:
           
           
            Console.WriteLine("1. Вiдсортувати список клiєнтiв за повним iм'ям в алфавiтному порядку:");
            var sortedCustomers = carRental.Customers.OrderBy(c => c.FullName);
            foreach (var customer in sortedCustomers)
            {
                Console.WriteLine(customer.FullName);
            }

            Console.WriteLine("========================================================================================");

            
            Console.WriteLine("2. Вiдсортувати список прокатiв за датою прокату в зростаючому порядку:");
            //2. Відсортувати список прокатів за датою прокату в зростаючому порядку:
            var sortedRentals = from r in carRental.Rentals
                                orderby r.RentalDate
                                select r;
            foreach (var rental in sortedRentals)
            {
                Console.WriteLine($"Машина: {rental.Car.Make}");
                Console.WriteLine($"Клiєнт: {rental.Customer.FullName}");
                Console.WriteLine($"Дата оренди: {rental.RentalDate.ToShortDateString()}");
                Console.WriteLine($"Дата повернення: {rental.ExpectedReturnDate.ToShortDateString()}");
                Console.WriteLine($"Депозитt: {rental.DepositAmount:C}");
                Console.WriteLine($"Вартість оренди: {rental.RentalAmount:C}");
                Console.WriteLine();
            }
            Console.WriteLine("========================================================================================");

            Console.WriteLine("3. Вiдсортувати список машин за цiною прокату за день вiд найбiльшої до найменшої:");
            //3. Відсортувати список машин за ціною прокату за день від найбільшої до найменшої:
            var sortedCars = carRental.Cars.OrderByDescending(c => c.PricePerDay);
            foreach (var car in sortedCars)
            {
                Console.WriteLine($"Машина: {car.Make}, Цiна за день: {car.PricePerDay:C}, Рiк: {car.Year}");
            }
            Console.WriteLine("========================================================================================");

            Console.WriteLine("4. Вiдсортувати список клiєнтiв за кiлькiстю символiв у номерi телефону вiд меншої до бiльшої");
            //4. Відсортувати список клієнтів за кількістю символів у номері телефону від меншої до більшої

            var sortedCustomer = carRental.Customers.OrderBy(c => c.PhoneNumber.Length);

            foreach (var customer in sortedCustomer)
            {
                Console.WriteLine($"Iм'я: {customer.FullName}, Номер телеофну: {customer.PhoneNumber}");
            }
            Console.WriteLine("========================================================================================");

            Console.WriteLine("5. Вiдсортувати список прокатiв за сумою депозиту вiд найбiльшої до найменшої:");
            //5. Відсортувати список прокатів за сумою депозиту від найбільшої до найменшої:
            var sortedRental = from r in carRental.Rentals
                                orderby r.DepositAmount descending
                                select r;
            foreach (var rental in sortedRental)
            {
                Console.WriteLine($"Машина, рiк випуску: {rental.Car.Make}, {rental.Car.Year}");
                Console.WriteLine($"Клiєнт: {rental.Customer.FullName}, {rental.Customer.Address}, {rental.Customer.PhoneNumber}");
                Console.WriteLine($"Дата оренди: {rental.RentalDate.ToShortDateString()}");
                Console.WriteLine($"Дата повернення: {rental.ExpectedReturnDate.ToShortDateString()}");
                Console.WriteLine($"Депозит: {rental.DepositAmount:C}");
                Console.WriteLine($"Вартімь оренди: {rental.RentalAmount:C}\n");
            }
            Console.WriteLine("========================================================================================");




            //6. Групування клієнтів по першій літері прізвища, а потім відображення кількості клієнтів в кожній групі
            Console.WriteLine("6. Групування клiєнтiв по першiй лiтерi прiзвища, а потiм вiдображення кiлькостi клiєнтiв в кожнiй групi");
            var customerGroups = from c in carRental.Customers
                                 group c by c.FullName[0] into g
                                 select new
                                 {
                                     FirstLetter = g.Key,
                                     Count = g.Count()
                                 };
            foreach (var group in customerGroups)
            {
                Console.WriteLine($"Клiєнт, перша лiтера прiзвища {group.FirstLetter}: {group.Count}");
            }
            Console.WriteLine("========================================================================================");

            // 7. Кількість оренд кожного автомобіля за всі періоди:
            Console.WriteLine("7. Кiлькiсть оренд кожного автомобiля за всi перiоди:");
            var rentalGroups = carRental.Rentals
                    .GroupBy(r => r.Car)
                    .Select(g => new
                    {
                        Car = g.Key,
                        TotalRentals = g.Count()
                    });

            foreach (var group in rentalGroups)
            {
                Console.WriteLine($"Машина: {group.Car.Make} {group.Car.Year}, Кiлькiсть оренд: {group.TotalRentals}");
            }
            Console.WriteLine("========================================================================================");
          
            Console.WriteLine("8. Групування орендованих автомобiлiв по роцi випуску, а потiм вiдображення середнього депозиту для кожної групи");
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
                Console.WriteLine($"Рiк: {group.Year}, Середнiй депозит: {group.AvgDeposit:C}");
            }

            Console.WriteLine("========================================================================================");
            Console.WriteLine("9. Загальна сума оренди для кожного клiєнта");
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
                Console.WriteLine($"Клiєнт: {group.Customer.FullName}, Загальна сума оренди: {group.TotalRentalAmount}");
            }

            Console.WriteLine("========================================================================================");
            Console.WriteLine("10. Групувати об'єкти  за маркою автомобiля та обчислювати середню суму орендної плати для кожної марки");
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
                Console.WriteLine($"Машина: {rental.CarMake}, Середня сума плати: {rental.AverageRentalAmount:C}");
            }

            Console.WriteLine("========================================================================================");
            //11. Вибираються машини, які мають властивість рівні певному клієнту

            Console.WriteLine("11. Вибираються машини, якi мають властивiсть рiвнi певному клiєнту");
            var rentalsByCustomer = carRental.Rentals.Where(r => r.Customer.FullName == "Стефанiвський Iлля");
            foreach (var rental in rentalsByCustomer)
            {
                Console.WriteLine($"Машина: {rental.Car.Make}, Дата оренди: {rental.RentalDate}, Вартiсть оренди: {rental.RentalAmount}");
            }

            Console.WriteLine("=========================================================================================");
            Console.WriteLine("12. Об'єкти зi списку машини, якi мають властивiсть цiну оренди, бiльшу нiж 1500");
            //12. Об'єкти зі списку carRental.Rentals машини, які мають властивість ціну оренди, більшу ніж 1500
            var expensiveRentals = from r in carRental.Rentals
                                   where r.RentalAmount > 1500
                                   select r;
            foreach (var rental in expensiveRentals)
            {
                Console.WriteLine($" Машина: {rental.Car.Make} , Вартiсть: {rental.RentalAmount}");
            }

            Console.WriteLine("========================================================================================");
            Console.WriteLine("13. Об'єкти зi списку  машин, якi мають рiк випуску 2021");

            //13. Об'єкти зі списку carRental.Cars машини, які мають рівну року випуску 2021
            var carsByYear = carRental.Cars.Where(c => c.Year == 2021);

            
            foreach (var car in carsByYear)
            {
                Console.WriteLine($"{car.Make}  - {car.Year}");
            }
            Console.WriteLine("========================================================================================");

            Console.WriteLine("14. Обераються машини, що попадають в дiапазон мiж 1 сiчня 2023 року та 22 березня 2023 року оренди.");
            //14. Обераються машини, що попадають в діапазон між 1 сiчня 2023 року та 22 березня 2023 року оренди.

            var rentalsByDate = from r in carRental.Rentals
                                where r.RentalDate >= new DateTime(2023, 01, 01) && r.RentalDate <= new DateTime(2023, 03, 22)
                                select r;
            foreach (var rental in rentalsByDate)
            {
                Console.WriteLine($"{rental.Customer.FullName} Оренда {rental.Car.Make} вiд {rental.RentalDate.ToShortDateString()}  Плата {rental.RentalAmount:C} з депозитом {rental.DepositAmount:C}");
            }
            Console.WriteLine("========================================================================================");

            Console.WriteLine("15. Обераються машини, що попадають в дiапазон депозиту мiж  1000  та 5000");
            //15. Обераються машини, що попадають в діапазон між 1000 та 5000
            var rentalsByDeposit = carRental.Rentals.Where(r => r.DepositAmount >= 1000 && r.DepositAmount <= 5000);
            foreach (var rental in rentalsByDeposit)
            {
                Console.WriteLine($" Машина: {rental.Car.Make} , Клiєнт: {rental.Customer.FullName}, Вартiсть депозиту: {rental.DepositAmount:C}");
            }
            Console.WriteLine("========================================================================================");
            Console.WriteLine("16. Знайти кiлькiсть оренд авто кожного бренду.");
            //16. Знайти кількість оренд авто кожного бренду.
            var carRentalsByMake = from rental in carRental.Rentals
                                   group rental by rental.Car.Make into carGroup
                                   select new { Make = carGroup.Key, RentalCount = carGroup.Count() };
            foreach (var group in carRentalsByMake)
            {
                Console.WriteLine($"Машина: {group.Make}, Кількість оренди: {group.RentalCount}");
            }
            Console.WriteLine("========================================================================================");
            Console.WriteLine("17.Знайти середнiй термiн оренди авто, якi були орендованi.");
            //17.Знайти середній термін оренди авто, які були орендовані.
            var averageCarAge = carRental.Cars
                     .Select(car => DateTime.Now.Year - car.Year)
                     .Average();
            Console.WriteLine($" Середнiй термiн оренди {averageCarAge} днiв");
            Console.WriteLine("========================================================================================");

            //18.Знайти найбільшу суму оренди серед усіх оренд.
            Console.WriteLine("18.Знайти найбiльшу суму оренди серед усiх оренд.");
            var maxRentalAmount = carRental.Rentals
                       .Select(rental => rental.RentalAmount)
                       .Max();
            Console.WriteLine($"Найбiльшу суму оренди { maxRentalAmount}");
            Console.WriteLine("========================================================================================");
            Console.WriteLine("19. Знайти суму депозитiв усiх оренд.");
            //19. Знайти суму депозитів усіх оренд.
            var totalDeposits = carRental.Rentals
                     .Select(rental => rental.DepositAmount)
                     .Sum();
            Console.WriteLine($"Сума депозитiв: {totalDeposits}");
            Console.WriteLine("========================================================================================");
            Console.WriteLine("20. Групування орендованих автомобiлiв по клiєнту, а потiм вiдображення загальної суми оренди для кожного клiєнта. ");
            //20. Групування орендованих автомобілів по клієнту, а потім відображення загальної суми оренди для кожного клієнта.
            var rentalByCustomer = carRental.Rentals
                                .GroupBy(r => r.Customer.FullName)
                                .Select(g => new { Customer = g.Key, TotalRentalAmount = g.Sum(r => r.RentalAmount) });

            foreach (var rental in rentalByCustomer)
            {
                Console.WriteLine($"Клiєнт: {rental.Customer}, Загальна вартiсть оренди: {rental.TotalRentalAmount}");
            }






        }



    }
    
}
