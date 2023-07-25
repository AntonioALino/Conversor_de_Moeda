public class Conversor
{
    static void Main(string[] args)
    {
        int opcao;

        int dinheiro;
        float euro = 5.25f;
        float dolar = 4.75f;
        float dolarCand = 3.61f;
        float libra = 6.13f;

        Console.WriteLine("Quanto de dinheiro você pretende investir nessa viagem??");
        dinheiro = int.Parse(Console.ReadLine());

        switch (dinheiro) {
            case 0:
                if(opcao == euro)
                {
                    Console.WriteLine(dinheiro * euro);
                }
                break; case 1:
                if (opcao == euro)
                {
                    Console.WriteLine(dinheiro * euro);
                }
                break;
            case 2:
                if (opcao == euro)
                {
                    Console.WriteLine(dinheiro * euro);
                }
                break;
        }
    }
    void opcao()
    {

    }



}

