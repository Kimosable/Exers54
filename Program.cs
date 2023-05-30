// / Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] arr = new int[rows, cols];

        Random rnd = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = rnd.Next(1, 100);
            }
        }

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0,4}", arr[i, j]);
            }
            Console.WriteLine();
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols - 1; j++)
            {
                for (int k = j + 1; k < cols; k++)
                {
                    if (arr[i, j] < arr[i, k])
                    {
                        int temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }
                }
            }
        }
        
        Console.WriteLine("Упорядоченный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0,4}", arr[i, j]);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}