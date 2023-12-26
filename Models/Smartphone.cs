namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        protected string Numero { get; set; }
        public string Modelo { get; init; }
        private string Imei { get; init; }
        private int Memoria { get; init; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void ExibirNumeroAtual()
        {
            Console.WriteLine(Numero);
        }

        public void ExibirModelo()
        {
            Console.WriteLine($"O modelo do Smartphone é: {Modelo}");
        }

        public void ExibirImei()
        {
            Console.WriteLine($"O {Modelo} possui o imei: {Imei}");
        }

        public void ExibirMemoria()
        {
            Console.WriteLine($"O {Modelo} possui a memória de: {Memoria}");
        }

        public void Ligar(string aparelho)
        {
            Console.WriteLine($"O {Modelo} estar Ligando para {aparelho}");
        }

        public void ReceberLigacao(string aparelho)
        {
            Console.WriteLine($"O {Modelo} Recebendo ligação de {aparelho}");
        }


        public abstract void InstalarAplicativo(string nomeApp);
    }
}