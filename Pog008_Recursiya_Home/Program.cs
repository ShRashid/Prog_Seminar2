// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// string PrintNumbers(int end, int start)
// {
//     if(start == end)
//     {
//         return end.ToString();
//     }
//     return end+ " "+ PrintNumbers(end-1,start);
// }

// System.Console.WriteLine(PrintNumbers(num, 1));

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("Введите число");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int natSum = 0;

// PrintNumbers(num1, num2);

// void PrintNumbers(int start, int end)
// {
//     //System.Console.Write(start);
//     natSum += start;
    
//     if(start == end)
//     {
//         System.Console.Write(natSum);
//         return;
//     }
//     else
//     {
//         PrintNumbers(start+1, end);
//     }
// }

//Задача 68: Напишите программу вычисления функции Аккермана с помощью 
//рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"А ({m},{n}) = {Ack(m, n)} ");

int Ack(int m, int n)
{
  if (m == 0) 
  {
    return n + 1;
  }
  else if (n == 0)
  { 
    return Ack(m - 1, 1);
  } 
  else 
  {
    return Ack(m - 1, Ack(m, n - 1));
  }
}


