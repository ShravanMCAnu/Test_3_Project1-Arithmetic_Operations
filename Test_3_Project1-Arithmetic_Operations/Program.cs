// See https://aka.ms/new-console-template for more information
using Test_3_Project1_Arithmetic_Operations;
try
{
    ArithmeticExceptions.Arithmetic1(10, 0);
    Console.WriteLine("Enter a value <");
    int n = int.Parse(Console.ReadLine());

}
catch(DivideByZeroException d)
{
    Console.WriteLine(d.Message);
}
catch(Exception e)
{
    Console.WriteLine("Arithematic Exception");

}
finally
{
    Console.WriteLine("Finally block");
}
