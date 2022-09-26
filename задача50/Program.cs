// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int height = EnterInt("введите количество строк в массиве: ");
int width = EnterInt("введите количество столбцов в массиве: ");

int[,] numbers = new int[height, width];
Fill2DArray(numbers, height, width);
Print2DArray(numbers, height, width);
int line = EnterInt("введите строку: ");
int column = EnterInt("введите столбец: ");
FindElement(numbers, line, column);

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
            numbers[i, j] = new Random().Next(-10, 11);
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

void FindElement(int[,] numbers, int line, int column)
{
    if (line > height || column > width)
    {
        Console.WriteLine("Нет такого элемента в массиве");
    }
    else
    {
        Console.WriteLine($"Значение этого элемента = {numbers[line - 1, column - 1]}");
    }
}
