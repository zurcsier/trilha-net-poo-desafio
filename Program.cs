using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Iphone iphone = new Iphone(numero: "1234567", modelo: "Modelo 1", imei: "11111",memoria:256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Waze");

Console.WriteLine("\n  --------------------------------------------------- \n");

Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia(numero: "1234567", modelo: "Modelo 2", imei: "22222",memoria:128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("FaceBook");