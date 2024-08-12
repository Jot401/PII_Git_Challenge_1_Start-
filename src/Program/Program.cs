Console.WriteLine(Multiplication.Multiply(3, 3));
Console.WriteLine(Division.Divide(18, 2));


// Esta clase implementa la operación Division
public class Division
{
    public static double Divide(int a, int b)
    {
        return (double)a / b;
    }
}

// Esta clase implementa la operación Multiplicación
public class Multiplication
{
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

// Esta clase implementa la operación Resta

public class Substraction
{
    public static int Substract(int a, int b)
    {
        return 0;
    }
}
