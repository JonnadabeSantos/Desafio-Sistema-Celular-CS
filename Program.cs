using DesafioPOO.Models;

Console.WriteLine("SmartPhone Nokia:");
Smartphone nokia = new Nokia(numero: 2410025 , modelo: "Gt 5", imei: "3322114", memoria: 512);
nokia.Ligar();
nokia.InstalarAplicativo("Uber Driver");

Console.WriteLine("\nSmartPhone iPhone:");
Smartphone iPhone = new Iphone(numero: 3120043, modelo: "iPhone 15", imei: "339dd31x7#", memoria: 128);
iPhone.Ligar();
iPhone.InstalarAplicativo("Instagram");

// TODO: Realizar os testes com as classes Nokia e Iphone