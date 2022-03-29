//8. We flew over to Titan
// Titan day = 900 hours
var titan = new TitanTime(1000, 40);//Titan Time is  100 : 40
var titan1 = new TitanTime(30, 70);// Titan Time is  031 : 10
System.Console.WriteLine(titan1);
class TitanTime
{
    public TitanTime(int hour, int minutes)
    {
        Minutes = minutes;
        Hours = hour;

        if (minutes > 59)
        {
            Hours += minutes / 60;
            Minutes = minutes % 60;
        }
        if (Hours > 899) Hours = Hours % 900;
    }
    public int Hours { get; set; }
    public int Minutes { get; set; }

    public override string ToString()
    {
        return $"Titan Time is  {Hours.ToString("000.###")} : {Minutes.ToString("00.##")}";
    }
}



