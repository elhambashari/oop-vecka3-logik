Vehicle vehicle = new Vehicle();

Console.Write("Ange fordonets årsmodell: ");
vehicle.Year = int.Parse(Console.ReadLine()!);

Console.Write("Har fordonet giltig försäkring? (ja/nej): ");
string insurance = Console.ReadLine()!.ToLower();

vehicle.HasInsurance = insurance == "ja";

string result = vehicle.CheckInspection();

Console.WriteLine($"Resultat: {result}");
