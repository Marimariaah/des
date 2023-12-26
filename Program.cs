using System.ComponentModel;
using DesafioPOO.Models;

Iphone iphone12 = new Iphone("90000-0000", "iphone X", "111111112", 128);
Nokia nokia01 = new Nokia("50000-1111", "Nokia 3310", "22222222", 64);

iphone12.InstalarAplicativo("Whatsapp");
nokia01.InstalarAplicativo("Instagram");
Console.WriteLine();

Console.WriteLine("Alterando o número do SmartPhone: ");
iphone12.MudarNumeroSmartPhone("9 1111-1111");
nokia01.MudarNumeroSmartPhone("9 8888-8888");
Console.WriteLine();

Console.WriteLine("Modelo do SmartPhone: ");
iphone12.ExibirModelo();
nokia01.ExibirModelo();
Console.WriteLine();

Console.WriteLine("Imei do SmartPhone: ");
iphone12.ExibirImei();
nokia01.ExibirImei();
Console.WriteLine();

Console.WriteLine("chamada do SmartPhone: ");
iphone12.Ligar(nokia01.Modelo);
nokia01.Ligar(iphone12.Modelo);
Console.WriteLine();

Console.WriteLine("recebimento de chamada do SmartPhone: ");
iphone12.ReceberLigacao(nokia01.Modelo);
nokia01.ReceberLigacao(iphone12.Modelo);
Console.WriteLine();

Console.WriteLine("Memoria do SmartPhone: ");
nokia01.ExibirMemoria();
iphone12.ExibirMemoria();