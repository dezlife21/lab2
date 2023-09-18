// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
class Equal
{
    public double A { get; set; }
    public double B { get; set; }

    public double Func(double x)
    {
        return A * x + B;
    }
    public string Root()
    {
        if (A == 0)
        {
            if (B == 0)
                return "Безлiч коренiв (нескiнченну кiлькiсть коренiв)";
            else
                return "Кореня немає";
        }
        else
        {
            double x = -B / A;
            return $"x = {x}";
        }
    }
    public void Print()
    {
        Console.WriteLine($"Значення полiв: A = {A}, B = {B}");
    }
}
class Program
{
    static void Main()
    {
        try
        {
            Equal equation = new Equal(); 
            Console.Write("Введiть значення A: ");
            equation.A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введiть значення B: ");
            equation.B = Convert.ToDouble(Console.ReadLine());
            equation.Print();
            Console.Write("Введiть значення X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double result = equation.Func(x);
            Console.WriteLine($"Результат виклику методу Func: {result}");
            string rootResult = equation.Root();
            Console.WriteLine($"Результат виклику методу Root: {rootResult}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Помилка: " + ex.Message);
        }
    }
}