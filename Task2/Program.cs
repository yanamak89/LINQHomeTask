using Task2;

class Program
{
    static void Main()
    {
        // Створюємо колекцію автомобілів
        List<Car> cars = new List<Car>
        {
            new Car { Brand = "Toyota", Model = "Land cruiser 200", Color = "Black", ProductionYear = 2017 },
            new Car { Brand = "BMW", Model = "X4M", Color = "Blue", ProductionYear = 2018 },
            new Car { Brand = "Mazda", Model = "Model 3", Color = "Gray", ProductionYear = 2011 },
            new Car { Brand = "Jeep", Model = "Cherokee", Color = "Black", ProductionYear = 2020 }
        };

        // Створюємо колекцію покупців
        List<Buyer> buyers = new List<Buyer>
        {
            new Buyer { BuyerName = "Yana", Model = "Land cruiser 200", PhoneNumber = "+4812940044" },
            new Buyer { BuyerName = "Vitalii", Model = "X4M", PhoneNumber = "+4510549548" },
            new Buyer { BuyerName = "Mykhailo", Model = "Model 3", PhoneNumber = "+4510549349" },
            new Buyer { BuyerName = "Maria", Model = "Cherokee", PhoneNumber = "+45344549548" }
        };
        
        //Використовуючи найпростіший запит LINQ, виведіть на екран інформацію про покупця
        // одного з автомобілів і повну характеристику придбаної ним моделі. 

        var query = from car in cars
            join buyer in buyers on car.Model equals buyer.Model
            select new
            {
                BuyerName = buyer.BuyerName,
                BuyerPhone = buyer.PhoneNumber,
                CarBrand = car.Brand,
                CarModel = car.Model,
                CarYear = car.ProductionYear,
                CarColor = car.Color
            };
        // Виводимо результат запиту
        foreach (var result in query)
        {
            Console.WriteLine($"Покупець: {result.BuyerName}");
            Console.WriteLine($"Телефон: {result.BuyerPhone}");
            Console.WriteLine($"Автомобіль: {result.CarBrand} {result.CarModel}, {result.CarColor} color, Production year is {result.CarYear}");
            Console.WriteLine($"------------");
        }

        Console.ReadKey();
    }
}