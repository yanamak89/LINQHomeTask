using Task5;

class Program
{
    static void Main()
    {
        Calculator calculator = new Calculator();
        dynamic num1 = 10;
        dynamic num2 = 5;
        
        Console.WriteLine($"Add: {num1} + {num2} = {calculator.Add(num1, num2)}");
        Console.WriteLine($"Subtract: {num1} - {num2} = {calculator.Subtract(num1, num2)}");
        Console.WriteLine($"Multiply: {num1} * {num2} = {calculator.Multiply(num1, num2)}");
        Console.WriteLine($"Divide: {num1} / {num2} = {calculator.Divide(num1, num2)}");
        
        // Тест з іншими типами даних
        dynamic str1 = "Hello";
        dynamic str2 = "World";
        Console.WriteLine($"Add: {str1} + {str2} = {calculator.Add(str1, str2)}");
        Console.WriteLine($"Subtract: {num1} - {num2} = {calculator.Subtract(num1, num2)}");

        Console.ReadKey();
    }
}