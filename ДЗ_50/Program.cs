// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.Clear();
Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string result = "Числа в массиве нет";
for  (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if  (array[i, j] == a) result = "Число есть в массиве";
    }
}
Console.WriteLine(result);
