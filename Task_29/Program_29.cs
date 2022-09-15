// Напишите программу, которая выводит 
// массив из 8 элементов, заполненный случайными числами.
// Для наглядности используем числа от 0 до 100

internal partial class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Массив из 8 элементов, заполненный случайными числами от 0 до 100:");

        int[] CreateArray()
        {
            Random rnd = new Random();
            int[] array = new int[8];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 101); // если скобки оставить пустыми, в массиве будут любые числа
            }
            return array;
        }

        void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}\t");
            }
        }
        int[] arr = CreateArray();
        PrintArray(arr);
    }
}