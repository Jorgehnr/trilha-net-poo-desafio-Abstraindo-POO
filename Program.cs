using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "85986365", modelo: "Nokia luma", imei: "115265202508", memoria: 128);

nokia.Ligar("85865252");
nokia.InstalarAplicativo("Dio");

Console.WriteLine("--------------------------------------------------------------------------------------");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "85865252", modelo: "Iphone 77s", imei: "585825252154", memoria: 256);

iphone.ReceberLigacao("85 85986365");
iphone.Ligar("85986365");
iphone.InstalarAplicativo("Youtube");
