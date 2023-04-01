//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("enter the number");
        int number = (int)Convert.ToUInt32(Console.ReadLine());

        int remDiv = number % 2;

        if (remDiv == 0)
        {
            Console.WriteLine("yes");

        }
        else
        {
            Console.WriteLine("no");
        }
    }
}