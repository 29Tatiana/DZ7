// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int height = EnterInt("введите количество строк в массиве: ");
int width = EnterInt("введите количество столбцов в массиве: ");

double[,] numbers = new double[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void Fill2DArray(double[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            numbers[i, j] = Convert.ToDouble(new Random().Next(-1000, 1000)) / 100;
        }
    }
}

void Print2DArray(double[,] numbers, int height, int width)
{
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write($"{numbers[i, j],5} ");
        }
        Console.WriteLine();
    }
}