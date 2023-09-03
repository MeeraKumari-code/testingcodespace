class program
{
    static void Main(string[] args)
    {
        // create new instance of calculator class
        Calculator calc = new Calculator();
        // call methods on calc object
        System.Console.WriteLine(calc.Add(1, 2));
        System.Console.WriteLine(calc.Subtract(1, 2));
        System.Console.WriteLine(calc.Multiply(1, 2));
        System.Console.WriteLine(calc.Divide(1, 2));
    }
}
// create new calculator class with methods: add, subtract, multiply, divide

// Path: consoleApp/Calculator.cs
class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Subtract(int a, int b)
    {
        return a - b;
    }
    public int Multiply(int a, int b)
    {
        return a * b;
    }
    public int Divide(int a, int b)
    {
        return a / b;
    }
}

