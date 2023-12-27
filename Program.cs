using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("--- Smartphone Nokia ---");
Smartphone nokia = new Nokia(numero: "91234-5678", modelo: "Modelo 1", imei: "11111111", memoria: 64 );
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n--- Smartphone iPhone ---");
Smartphone iphone = new Iphone(numero: "92345-6789", modelo: "Modelo 2", imei: "22222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
