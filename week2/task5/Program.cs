//5. Better printout
var time = new JupiterTime(1, 21);
 time.AddMinutes(-180);// Output Time is 08:21

System.Console.WriteLine(time);
class JupiterTime
{
    public JupiterTime(int hour, int minutes)
    {
        Minutes = minutes;
        Hours = hour;

        if (minutes > 59)
        {
            Hours += minutes / 60;
            Minutes = minutes % 60;
        }
        if (Hours > 9) Hours = Hours % 10;
    }
    public int Hours { get; set; }
    public int Minutes { get; set; }
    public JupiterTime AddHours(int inputHours)
    {
        if (inputHours > 9)
        {
            inputHours = inputHours % 10;
            Hours += inputHours;
        }
        if (inputHours < 0)
        {
            inputHours = inputHours % 10;
            Hours += inputHours;
            if (Hours < 0) Hours = 10 + Hours;
        }
        return this;
    }
    public JupiterTime AddMinutes(int inputMinutes)
    {
        if (inputMinutes > 59)
        {
            Hours += inputMinutes / 60;
            inputMinutes = inputMinutes % 60;
        }
        if (inputMinutes < 0)
        {
            Hours += inputMinutes / 60;
            inputMinutes = inputMinutes % 60;
        }
        if (Hours > 9) Hours = Hours % 10;
        if (Hours < 0) Hours = 10 + (Hours % 10);
        return this;
    }
    public override string ToString()
    {
        return "Time is " + Hours.ToString("00.##")+ ":"+ Minutes.ToString("00.##");
    }
}



