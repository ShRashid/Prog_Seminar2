// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел: ");
int M = Console.ReadLine().ToInt32();
int[] array = new int[M];
int count = 0;
for(int i = 0; i < M; i++)
{
    array[i]=Console.ReadLine().ToInt32();
    if(array[i] > 0) count++;
}

Console.WriteLine(count);