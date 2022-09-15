// Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int SummaDigits(int num)
        {
            int digitsquantity = Convert.ToString(number).Length;
            int summa = 0;

            for (int step = 0; step < digitsquantity; step++)
            {
                summa = summa + number % 10;
                number = number / 10;
            }
            return summa;
        }
        int result = SummaDigits(number);
        Console.WriteLine("Сумма цифр в числе: " + result);
    }
}