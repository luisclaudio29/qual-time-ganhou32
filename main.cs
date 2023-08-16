using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o nome do primeiro time: ");
        string time1 = Console.ReadLine();

        Console.Write("Digite o número de gols marcados pelo primeiro time: ");
        int golsTime1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o nome do segundo time: ");
        string time2 = Console.ReadLine();

        Console.Write("Digite o número de gols marcados pelo segundo time: ");
        int golsTime2 = Convert.ToInt32(Console.ReadLine());

        if (golsTime1 > golsTime2)
        {
            Console.WriteLine($"O vencedor é o time {time1}!");
        }
        else if (golsTime2 > golsTime1)
        {
            Console.WriteLine($"O vencedor é o time {time2}!");
        }
        else
        {
            Console.WriteLine("EMPATE!");
        }
    }
}
