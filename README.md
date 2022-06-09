# stopwatch
 Creating a stopwatch with C# 

using System;
using System.Threading;
                                                                   
public class Stopwatch
{

    public static void Main()
    {

        Menu();
    }

    static void Menu()
    {
        Console.Clear();
        Console.WriteLine("S = Segundo");
        Console.WriteLine("M = Minuto");
        Console.WriteLine("H = Horas");
        Console.WriteLine("0 = Sair");
        Console.WriteLine("Digite sempre o tempo que quer contar seguido de uma das letras acima. Exemplo: 60S");
        Console.WriteLine("Quanto tempo deseja contar?");

        string data = Console.ReadLine().ToLower();
   
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        int time = int.Parse(data.Substring(0, data.Length - 1 ));
        int multiplier = 1;

        if(type == 'm')
            multiplier = 60;
        
        if(time == 0)
            System.Environment.Exit(0);

        if(type == 'h')
            multiplier = 3600;

        PreStart(time * multiplier);
    }

    static void PreStart(int time) {
        Console.Clear();
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.Write("GO!!!");
        Thread.Sleep(2500);

        Start(time);
    }

    static void Start(int time)
    {
        int currentTime = 0;
        while(currentTime != time)
        {
            Console.Clear();
            currentTime++;
            Console.WriteLine(currentTime);
            Thread.Sleep(1000);
        }
           Console.Clear();
           Console.WriteLine("Stopwatch finalizado");        
           Thread.Sleep(2500);  
           Menu();           
    }
}
