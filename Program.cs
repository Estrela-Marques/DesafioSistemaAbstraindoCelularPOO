using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Modelo: 1", imei: "0000000", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Uber");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "87654321", modelo: "Modelo: 12", imei: "UUUU-Y", memoria: 46);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");