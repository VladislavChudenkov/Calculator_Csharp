using System.ComponentModel.Design;
using System.Net;

internal class Program
{
    private static void Main(string[] args)
    {  

        do 
            {
                Console.WriteLine("Введите действие");
                Console.WriteLine("1.Сложение");
                Console.WriteLine("2.Вычитание");
                Console.WriteLine("3.Умножение");
                Console.WriteLine("4.Деление");
                Console.WriteLine("5.Возведение в степень");
                Console.WriteLine("6.Квадратный корень");
                Console.WriteLine("7.1 процент от числа");
                Console.WriteLine("8.Факториал числа");
                Console.WriteLine("9.Выйти из программы");
                Console.WriteLine("Введите операцию");
                string operationstr = Console.ReadLine();
                Console.WriteLine("Введите первое число");
                string firstNumberstr = Console.ReadLine();
                double firstNumber = Convert.ToDouble(firstNumberstr);
                Console.WriteLine("Введите второе число");
                string secondNumberstr = Console.ReadLine();
                double secondNumber = Convert.ToDouble(secondNumberstr);
                switch (operationstr)
                {

                    case "1":
                        double resultSum = firstNumber + secondNumber;
                        Console.WriteLine(resultSum);
                        break;
                    case "2":
                        double resultMin = firstNumber - secondNumber;
                        Console.WriteLine(resultMin);
                        break;
                    case "3":
                        double resultMul = firstNumber * secondNumber;
                        Console.WriteLine(resultMul);
                        break;
                    case "4":
                    double resultDel = 0;
                    if (secondNumber == 0) 
                        Console.WriteLine("На ноль делить нельзя");
                    else 
                        resultDel = firstNumber / secondNumber;
                        Console.WriteLine(resultDel);
                        break;
                    case "5":
                        double resultDeg = Math.Pow(firstNumber, secondNumber);
                        Console.WriteLine(resultDeg);
                        break;
                    case "6":
                        double resultSqrt = Math.Sqrt(firstNumber);
                        Console.WriteLine(resultSqrt);
                        break;
                    case "7":
                        double resultProcent = firstNumber / 100;
                        Console.WriteLine(resultProcent);
                        break;
                    case "8":
                        double Factorial(double n)
                        {
                            if (n == 1) return 1;

                            return n * Factorial(n - 1);
                        }
                        double resultFactorial = Factorial(firstNumber) ;
                        Console.WriteLine(resultFactorial);
                        break;
                    case "9":
                       return;
                }
            } while (true);
    }
}