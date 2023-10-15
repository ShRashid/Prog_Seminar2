// Задача 46: Задайте двумерный массив размером
//  m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// Console.WriteLine("Введите кол-во строк массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите кол-во столбцов массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int[rows,columns];   // Строчек + столбцы

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10);
//         Console.Write(array[i,j]+ " ");
//     }
//     Console.WriteLine();
// }

// Задача 48: Задайте двумерный массив размера
//  m на n, каждый элемент в массиве находится 
//  по формуле: Aₘₙ = m+n. Выведите полученный
//   массив на экран.
// m = 3, n = 4.
// 0 1 2 3 
// 1 2 3 4
// 2 3 4 5   

// Console.WriteLine("Введите размерность массива:");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размерность массива:");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] arr = new int[rows, columns];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         arr[i, j] = i + j;
//         Console.Write(arr[i, j] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 49: Задайте двумерный массив. Найдите 
// элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 0 1 2 3 

// 1 4 7 2    0
// 5 9 2 3    1
// 8 4 2 4    2

// Console.WriteLine("Введите размероность массива");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите размероность массива");
// int columns = Convert.ToInt32(Console.ReadLine());

// int [,] array = new int[rows,columns];   // Строчек + столбцы

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i,j] = new Random().Next(0,10);
//         Console.Write(array[i,j]+ " ");
//     }
//     Console.WriteLine();
// }
//  Console.WriteLine();

// for (int i = 0; i < array.GetLength(0); i++)
// {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         if(i%2 ==0 && j%2==0)
//         {
//             array[i,j] = array[i,j]* array[i,j];
//         }
//         Console.Write(array[i,j]+ " ");
//     }
//     Console.WriteLine();
// }

// Задача 51: Задайте двумерный массив. 
// Найдите сумму элементов, находящихся 
// на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12



Console.WriteLine("Введите размероность массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите размероность массива");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array = new int[rows,columns];   // Строчек + столбцы

int sum=0;

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = new Random().Next(0,10);
        Console.Write(array[i,j]+ " ");

        if(i==j)
        {
            sum= sum + array[i,j];
        }
    }
    Console.WriteLine();
}

 Console.WriteLine("Сумма элементов на главной диагонали = "+ sum);