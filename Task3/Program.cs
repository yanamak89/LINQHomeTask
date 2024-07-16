class Program
{
    static void Main()
    {
        // Створюємо англо-російський словник з використанням динамічних типів

        var dictionary = new List<dynamic>
        {
            new { English = "Apple", Ukrainian = "Яблуко" },
            new { English = "Book", Ukrainian = "Книга" },
            new { English = "Cat", Ukrainian = "Кішка" },
            new { English = "Dog", Ukrainian = "Собака" },
            new { English = "Elephant", Ukrainian = "Слон" },
            new { English = "Fish", Ukrainian = "Риба" },
            new { English = "Giraffe", Ukrainian = "Жираф" },
            new { English = "House", Ukrainian = "Дім" },
            new { English = "Ice cream", Ukrainian = "Морозиво" },
            new { English = "Jacket", Ukrainian = "Куртка" },
        };
        
        // Виводимо вміст словника на екран
        foreach (var word in dictionary)
        {
            Console.WriteLine($"English: {word.English}, Ukrainian: {word.Ukrainian}");
        }

        Console.ReadKey();

    }
}