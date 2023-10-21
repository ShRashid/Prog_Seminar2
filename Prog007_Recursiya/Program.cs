// Задача 63: Задайте значение N. Напишите
//  программу, которая выведет все натуральные 
//  числа в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int start, int end)
// {
//     if(start == end)
//     {
//         return start.ToString();
//     }
//     return start+ " "+ PrintNumbers(start+1,end);
// }

// System.Console.WriteLine(PrintNumbers(1, num));

// Задача 65: Задайте значения M и N. Напишите
//  программу, которая выведет все натуральные 
//  числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"


// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// PrintNumbers(num1, num2);

// void PrintNumbers(int start, int end)
// {
//     System.Console.WriteLine(start);
    
//     if(start == end)
//     {
//         return;
//     }
//     else
//     {
//         PrintNumbers(start+1, end);
//     }
// }

// Задача 67: Напишите программу, которая будет
//  принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int sum=0;

// System.Console.WriteLine(GetSum(num));

// int GetSum(int newNum)
// {
//     sum+= newNum % 10;
//     if(newNum==0)
//     {
//         return sum;
//     }
//     return GetSum(newNum /10);
// }

// Задача 69: Напишите программу, которая на вход
//  принимает два числа A и B, и возводит число А
//   в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8


Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(GetSum(num1, num2));

int GetSum(int num, int degree)
{
    if(degree==0)
    {
        return 1;
    }
    else if(degree==1)
    {
        return num;
    }
    return num * GetSum(num, degree-1);
}