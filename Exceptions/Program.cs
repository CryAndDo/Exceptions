using System.Numerics;
using Exceptions;


Complex Sobstvennoe(Complex a, Complex b)
{
    if (Math.Pow(b.Real, 2) + Math.Pow(b.Imaginary, 2) == 0)
        throw new MyException("На нуль незя");

    return a / b;
}
Complex Standart(Complex a, Complex b)
{
    if (Math.Pow(b.Real, 2) + Math.Pow(b.Imaginary, 2) == 0)
        throw new DivideByZeroException("На нуль незя");

    return a / b;
}
Complex Without(Complex a, Complex b)
{
    return a / b;
}
Complex Throw(Complex a, Complex b)
{
    if (Math.Pow(b.Real, 2) + Math.Pow(b.Imaginary, 2) == 0)
        throw new Exception("На нуль незя");

    return a / b;
}
try
{
    Console.Write("Введите действительную часть числа a: ");
    double a = double.Parse(Console.ReadLine());
    Console.Write("Введите мнимую часть числа a: ");
    double b = double.Parse(Console.ReadLine());
    Complex aC = new Complex(a, b);

    Console.Write("Введите действительную часть числа b: ");
    double c = double.Parse(Console.ReadLine());
    Console.Write("Введите мнимую часть числа b: ");
    double d = double.Parse(Console.ReadLine());
    Complex bC = new Complex(c, d);

    Console.WriteLine(Sobstvennoe(aC, bC));

}
catch (MyException ex)
{
    Console.WriteLine(ex.Message);
}
catch (ArithmeticException ex)
{
    Console.WriteLine(ex.Message);
}