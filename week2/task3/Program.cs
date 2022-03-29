//3. Adding time
var time = new JupiterTime(2, 20);
var timeIn1Hour = time.AddHours(-13);

PrintTime(timeIn1Hour);// Output Time is 09:20
static void PrintTime(JupiterTime inputTime)
{
    Console.WriteLine($"Time is {inputTime.Hours.ToString("00.##")}:{inputTime.Minutes.ToString("00.##")}");
}
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
              if(Hours<0)Hours = 10 + Hours;
        }
        return this;
    }
}

