// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int height = EnterInt("введите количество строк в массиве: ");
int width = EnterInt("введите количество столбцов в массиве: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
FindAverageColumn(numbers, height, width);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = new Random().Next(1, 11);
        }
    }
}

void Print2DArray(int[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}

void FindAverageColumn(int[,] numbers, int height, int width)
{
    for (int j = 0; j < width; j++)
    {
        double average = 0;
        for (int i = 0; i < height; i++)
        {
            average = average + numbers[i, j];
        }
        Console.WriteLine($"среднее арифметическое числел в {j + 1} столбце - {(average / height):F2}");
    }
}
