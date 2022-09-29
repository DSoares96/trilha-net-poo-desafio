using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "9999-9999", modelo: "XS", imei: "54515", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Iphone(numero: "8888-8888", modelo: "C20", imei: "2222", memoria: 32 );
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();