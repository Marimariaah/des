namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public List<string> ListaAplicativo { get; init; }

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            ListaAplicativo = new List<string>();
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            ListaAplicativo.Add(nomeApp);
        }

        public void MudarNumeroSmartPhone(string numero)
        {
            if (string.IsNullOrEmpty(numero))
            {
                Console.WriteLine("Número inválido");
                return;
            }

            Console.WriteLine($"O telefone: {Numero}, foi alterado para: {numero}.");

            Numero = numero;
        }
    }
}