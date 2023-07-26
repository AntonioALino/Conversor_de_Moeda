using System;
using System.Collections.Generic;
public class Conversor
{
    static void Main(string[] args)
    {
        
        
        

        int orçamento;
        string opcao;
     
        Console.WriteLine("Você deseja fazer orçamento?");
        opcao = Console.ReadLine(); 
        
        if (opcao == "sim") {

        Dinheiro();

        DigiteOpcoes();

        

           

        } else
        {
            Console.WriteLine("Muito obrigado!");
        } 



       

               
       
    }
    static void DigiteOpcoes()
    {
        
        List<object> moedas = new List<object>();

        moedas.Add(ValordasMoedas());


        Console.WriteLine("Digite 1 para fazer orçamento com euro");
        Console.WriteLine("Digite 2 para fazer orçamento com dolar");
        Console.WriteLine("Digite 3 para fazer orçamento com dolar canadense");
        Console.WriteLine("Digite 4 para fazer orçamento com libra");
        Console.WriteLine("Digite 5 para registrar uma moeda e seu valor");

        Console.Write("Digite a opcao que voce deseja escolher\n");
        int opcaoEscolhida = int.Parse(Console.ReadLine());

        switch(opcaoEscolhida)
        {
            case 1:
                if (opcaoEscolhida== 1) {
                    Console.WriteLine(Dinheiro() * euro);
                } break;
                case 2:
                if (opcaoEscolhida == 2)
                {
                    Console.WriteLine(Dinheiro() * dolar);
                }
                break;
                case 3:
                if (opcaoEscolhida == 3)
                {
                    Console.WriteLine(Dinheiro() * dolarCand);
                }
                break;
                case 4:
                if (opcaoEscolhida == 4)
                {
                    Console.WriteLine(Dinheiro() * libra);
                }
                break;
                case 5: RegistrarMoeda();
                break;
            default: Console.WriteLine("Não existe essa função.");
                break;
        }
    }
    static void RegistrarMoeda()
    {

    Console.Clear();
    Console.WriteLine("Digite o nome da moeda que você deseja adicionar");
    string nomeMoeda = Console.ReadLine();

        Console.WriteLine("Digite o valor da moeda em relação a reais.");
        float valorMoeda = float.Parse(Console.ReadLine());


    }

    static int Dinheiro()
    {
        int dinheiro;
        Console.WriteLine("Quanto de dinheiro você pretende investir nessa viagem??");
        dinheiro = int.Parse(Console.ReadLine());

        return dinheiro;
    }
    static void ValorDasMoedas()
    {
        float euro =  
    } 
}   

