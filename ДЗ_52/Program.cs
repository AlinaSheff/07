// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
int count = 0;
for(int j = 0; j < n; j++)
{
    double sum = 0;
    double avg = 0;
    for(int i = 0; i < m; i++)
    {
       sum += array[i, j];
    }
    avg = Math.Round(sum / m, 1);
    count++;
    Console.WriteLine($"Сумма элементов {count} столбца = {sum}, Среднее арифметическое {count} столбца = {avg}");
}
