// 2. Adding constructor

// Let's add constructor so this becomes possible:

 var time = new JupiterTime(7, 40); // output Time is 07:40
  var time1 = new JupiterTime(7, 4); // output Time is 07:04


// Ooops, some of our crew members accidentally wrote:

var time2 = new JupiterTime(14, 88); // Óutput Time is 05:28

// This should actually become equal to 5:28. Add the code to fix overflow.

PrintTime(time2);
PrintTime(time1);
PrintTime(time);

static void PrintTime(JupiterTime time)
{

    Console.WriteLine($"Time is {time.Hours.ToString("00.##")}:{time.Minutes.ToString("00.##")}");
}
class JupiterTime
{
    public JupiterTime(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
        if (minutes > 59)
        {
            Hours += minutes / 60;
            Minutes = minutes % 60;
        }

        if (Hours > 9)  Hours= Hours % 10;
    }

    public int Hours { get; set; }
    public int Minutes { get; set; }
}