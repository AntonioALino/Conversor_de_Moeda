using System;
using System.Collections.Generic;
using System.Globalization;

public class Conversor
{
    static private List<string> opcoesMoeda = new List<string>();



    static private Dictionary<int, float> moedas = new();

    static Conversor() {
        moedas.Add(1, 5.24f);
        moedas.Add(2, 4.74f);
        moedas.Add(3, 3.58f);
        moedas.Add(4, 6.11f);
        opcoesMoeda.Add("Digite 1 para fazer orçamento com euro");
        opcoesMoeda.Add("Digite 2 para fazer orçamento com dolar");
        opcoesMoeda.Add("Digite 3 para fazer orçamento com dolar canadense");
        opcoesMoeda.Add("Digite 4 para fazer orçamento com libra");
    }
    static private string haveBudget { get; set; }
    static void Main(string[] args)
    {     

        Introducao();

    }
    static void DigiteOpcoes()
    {   
        for(int i = 0; i < opcoesMoeda.Count; i++)
        {
            Console.WriteLine(opcoesMoeda[i]);
        }
        Console.WriteLine("Digite registrar para registrar uma moeda e seu valor");
        Console.WriteLine("Digite sair para voltar ao menu principal");

        Console.Write("Digite a opcao que voce deseja escolher\n");
        string opcaoEscolhida = Console.ReadLine().ToString();
        int numeroInt;

            if (int.TryParse(opcaoEscolhida, out numeroInt)) {
                if (numeroInt <= opcoesMoeda.Count) { 
                Console.WriteLine(Dinheiro() * moedas[int.Parse(opcaoEscolhida)]); 
            }
            else
            {
                Console.WriteLine("Não existe essa função.");
            }
        }
            
               else if (opcaoEscolhida == "registrar")
        {
            RegistrarMoeda();
        } else if (opcaoEscolhida == "sair")
        {
            Introducao();
        } else
        {
            Console.WriteLine("Não existe essa função.");
        }

    }
    static void RegistrarMoeda()
    {

    Console.Clear();
    Console.WriteLine("Digite o nome da moeda que você deseja adicionar");
    string nomeMoeda = Console.ReadLine();

        Console.WriteLine("Digite o valor da moeda em relação a reais.");
        float valorMoeda = float.Parse(Console.ReadLine());
        int count = moedas.Count + 1;
        moedas.Add(count, valorMoeda);

        opcoesMoeda.Add($"Digite {count} para fazer orçamento com {nomeMoeda}");
        
        Introducao();


    }

    static int Dinheiro()
    {
        int dinheiro;
        Console.WriteLine("Quanto de dinheiro você pretende investir nessa viagem??");
        dinheiro = int.Parse(Console.ReadLine());

        return dinheiro;
    }
        static void Introducao()
    {
            
            Console.WriteLine("Você deseja fazer orçamento?");
            haveBudget = Console.ReadLine();

        haveBudget = haveBudget.ToUpper();

        if (haveBudget == "SIM")
        {
            Dinheiro();
            DigiteOpcoes();

        } else
        {
            Console.WriteLine("Ok, muito obrigado");
        }
       


        
    }
}   


