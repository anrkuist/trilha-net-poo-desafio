using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia("8124454873", "NModelo", "12345", 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\nSmartphone iPhone:");
Smartphone iphone = new Iphone("7039459063", "iModelo", "67891", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");