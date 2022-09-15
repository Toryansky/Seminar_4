// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите основание степени число A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите показатель степени число B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        int RaisingToAPower(int numA, int numB)
        {
            int count = 1;
            for (int i = 1; i <= B; i++)
            {
                count *= A;
            }
            return count;
        }
        int result = RaisingToAPower(A, B);
        Console.WriteLine("Результат возведения числа A в степень B: " + result);
    }
}