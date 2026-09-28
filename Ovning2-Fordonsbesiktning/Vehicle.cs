class Vehicle
{
    public int Year { get; set; }
    public bool HasInsurance { get; set; }

    public string CheckInspection()
    {
        int age = DateTime.Now.Year - Year;

        if (age > 5 && HasInsurance == false)
        {
            return "Ej godkänt";
        }
        else if (age < 5 && HasInsurance == true)
        {
            return "Godkänt";
        }
        else
        {
            return "Måste kompletteras";
        }
    }
}