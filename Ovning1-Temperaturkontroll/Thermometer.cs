class Thermometer
{
    public double Temperature { get; set; }

    public string CheckTemperature()
    {
        if (Temperature < 0)
        {
            return "Det är minusgrader";
        }
        else if (Temperature <= 30)
        {
            return "Normal temperatur";
        }
        else
        {
            return "Varning för hög värme";
        }
    }
}