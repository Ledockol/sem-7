// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
for(int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + " ");
    };
    Console.WriteLine();
}

for(int j = 0; j < array.GetLength(1); j++)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        sum = array[i,j] + sum;
    }
    Console.Write($"Среднее арифметическое каждого столбца: {sum};");
}