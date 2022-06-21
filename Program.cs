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

        //ToLower = passa tudo para minusculo 
        string data = Console.ReadLine().ToLower();
        //isolando o tempo(numero) do tipo(segundo, minuto...) usando char para definir o dado para um caractere
        //Para isso apenas o ultimo caractere será considerado, com substring
        // (1,1) = (posição,quantidade) - usa-se o length para contar quantos itens tem - subtrai 1 pra bater coma contagem em prog. que começa do zero 
        char type = char.Parse(data.Substring(data.Length - 1, 1));
        //pegando apenas o tempo digitado
        int time = int.Parse(data.Substring(0, data.Length - 1 ));
        //multiplicador
        int multiplier = 1;

        //caso seja digitado 'm' o multiplier passa a valer 60
        if(type == 'm')
            multiplier = 60;
        
        //se for digitado 0 vai sair da aplicação
        if(time == 0)
            System.Environment.Exit(0);

        if(type == 'h')
            multiplier = 3600;

        //chamando o cronometro e multiplicando o time e o multiplier
        PreStart(time * multiplier);
    }

    //
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

    //função que inicia o cronômetro
    //recebendo o time via párametro 
    static void Start(int time){
        //variavel que irá percorrer o while
        int currentTime = 0;
        while(currentTime != time)
        {
            //para iniciar o terminal sempre limpo oq nesse caso deixará impresso apenas o currentTime
            Console.Clear();
            //tem que executar o incremento para não ficar rodando inifnitamente
            currentTime++;
            Console.WriteLine(currentTime);
            //Thread = execução atual do programa - Sleep = para ela dormir por um segundo
            Thread.Sleep(1000);
        }
           Console.Clear();
           Console.WriteLine("Stopwatch finalizado");        
           Thread.Sleep(2500);  
           Menu();           
    }
}