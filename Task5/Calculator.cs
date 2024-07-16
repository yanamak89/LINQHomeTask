namespace Task5;

public class Calculator
{
    public dynamic Add(dynamic a, dynamic b)
    {
        return a + b;
    }
    public dynamic Subtract(dynamic a, dynamic b)
    {
        return a - b;
    }
    
    public dynamic Multiply(dynamic a, dynamic b)
    {
        return a * b;
    }
    public dynamic Divide(dynamic a, dynamic b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Division by zero not possible.");
        }
        return a / b;
    }
}