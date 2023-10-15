// Задача 40: Напишите программу, которая принимает на вход
//  три числа и проверяет, может ли существовать треугольник
//   с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон
// int[] array = new int[6];
// for (int i = 0; i < array.Length; i++)
// {
//   array[i]= new Random().Next(-1,3);
//   System.Console.Write(array[i]+ " ");
// }

// Console.WriteLine("Введите число");
// int num1 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num2 = int.Parse(Console.ReadLine());

// Console.WriteLine("Введите число");
// int num3 = int.Parse(Console.ReadLine());

// if(num1<num2+num3 && num2<num1+num3 && num3<num1+num2)   
// {
//   System.Console.WriteLine("Может");
// }
// else
// {
//   System.Console.WriteLine("Не может");
// }

// Задача 42: Напишите программу, которая будет преобразовывать
//  десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// Console.WriteLine("Введите число");
// int num1 = int.Parse(Console.ReadLine());

// string result ="";

// while(num1>0)
// {
//   result = num1%2 + result; // string n= 52 + "3"= 523  канкатинация
//   num1= num1/2;
// }

// System.Console.WriteLine(result);

// Задача 44: Не используя рекурсию, выведите первые N 
// чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// Console.WriteLine("Введите число");
// int num = int.Parse(Console.ReadLine());

// int first = 0;
// int second = 1;
 
// System.Console.Write(first+ ", "+ second+ ", ");

// for (int i = 2; i < num; i++)
// {
//   int nextNum= first+second;
//   System.Console.Write(nextNum+ ", ");

//   first=second;
//   second= nextNum;
// }

// Задача 39: Напишите программу, которая перевернёт
//  одномерный массив (последний элемент будет на первом 
//  месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] array = new int[6];

for (int i = 0; i < array.Length; i++)
{
  array[i]= new Random().Next(-1,10);
  System.Console.Write(array[i]+ " ");
}

for (int i = 0; i < array.Length /2; i++)
{
  int temp=0;
  temp= array[i];
  array[i]= array[array.Length-1-i];
  array[array.Length-1-i]= temp;
}
System.Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{
  System.Console.Write(array[i]+ " ");
}