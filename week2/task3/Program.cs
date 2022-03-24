// 3. Adding time

// We need to add method AddHours which accepts a number which returns a new time object with the added hours. Let's look at an example:

var time = new JupiterTime(2, 20);
var timeIn1Hour = time.AddHours(1);
//  var timeIn13Hour = time.AddHours(13);
// var timeInminus = time.AddHours(-4);


PrintTime(timeIn1Hour);// Output print 3:20.
//  PrintTime(timeIn13Hour);// Output print 3:20.
// PrintTime(timeInminus);// Time is 08:20


// The code should print 3:20.

//     Bonus: What happens if we add a large number like 11? Bonus: What happens if we add a negative number? How do we go back? What is before 0:00 for example?



static void PrintTime(JupiterTime inputTime)
{

    Console.WriteLine($"Time is {inputTime.Hours.ToString("00.##")}:{inputTime.Minutes.ToString("00.##")}");
}
class JupiterTime
{
    int _hours, _minutes;
    public JupiterTime(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;

    }

    public int Hours
    {
        get => _hours; set
        {
            if (value > 9) _hours = value % 10;
            else if (value < 0) _hours = 10 + value;
            else _hours = value;

        }
    }
    public int Minutes
    {
        get => _minutes; set
        {
            if (value > 59)
            {
                _hours += value / 60;
                _minutes = value % 60;
            }
            else if (value < 0) System.Console.WriteLine(value);
            else _minutes = value;

        }
    }

    public JupiterTime AddHours(int inputHours)
    {
        // if (inputHours < 0) Hours -= inputHours;
        // else
        Hours += inputHours;
        return this;
    }
}