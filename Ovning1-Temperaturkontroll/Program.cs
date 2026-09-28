Thermometer thermometer = new Thermometer();

Console.Write("Ange temperaturen: ");
thermometer.Temperature = double.Parse(Console.ReadLine()!);

string result = thermometer.CheckTemperature();

Console.WriteLine(result);
