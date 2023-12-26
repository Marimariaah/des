using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public List<string> ListaAplicativo { get; init; }

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
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
                Console.WriteLine("Numero inválido");
                return;
            }

            Console.WriteLine($"o telefone: {Numero}, foi alterado para: {numero}.");

            Numero = numero;
        }
    }
}