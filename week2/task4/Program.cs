// // 3. Adding time

// // We need to add method AddHours which accepts a number which returns a new time object with the added hours. Let's look at an example:

// var time = new JupiterTime(-2, 125);
// // var timeIn1Hour = time.AddHours(-3);
// //  var timeIn13Hour = time.AddHours(13);
// // var timeInminus = time.AddHours(-4);


// PrintTime(time);// Output print 3:20.
// //  PrintTime(timeIn13Hour);// Output print 3:20.
// // PrintTime(timeInminus);// Time is 08:20


// // The code should print 3:20.

// //     Bonus: What happens if we add a large number like 11? Bonus: What happens if we add a negative number? 
// //How do we go back? What is before 0:00 for example?



// static void PrintTime(JupiterTime inputTime)
// {

//     Console.WriteLine($"Time is {inputTime.Hours.ToString("00.##")}:{inputTime.Minutes.ToString("00.##")}");
// }
// class JupiterTime
// {
//     int _hours, _minutes;
//     public JupiterTime(int hours, int minutes)
//     {
//         Hours = hours;
//         Minutes = minutes;
//         // Handle a large numbers
//         if (hours > 9) Hours = hours % 10;
//         if (minutes > 59)
//         {
//             System.Console.WriteLine("minutes"+minutes+"Hours"+Hours+"Minutes"+Minutes);
//             Hours += minutes / 60;
//             Minutes = minutes % 60;
//                         System.Console.WriteLine("minutes"+minutes+"Hours"+Hours+"Minutes"+Minutes);

//         }
//         //I estimate the negative value at the start is a mistake and I convert it by default.
//         //  if (hours < 0)
//         // {
//         //     Hours = Math.Abs(hours % 10);
//         // }
//         // if (minutes < 0)
//         // {
//         //     Minutes = Math.Abs(minutes % 60);
//         //     Hours += Math.Abs(minutes / 60);
//         // }

//         // Or we can accept the negative values.
//         if (hours < 0)
//         {
//             Hours = (hours % 10) + 10;
//         }
//         if (minutes < 0)
//         {
//             Minutes = minutes % 60;
//             Hours += minutes / 60;
//             if (Minutes < 0)
//             {
//                 Hours = Hours - 1;
//                 Minutes = 60 + Minutes;
//             }
//         }

//     }

//     public int Hours
//     {
//         get => _hours;
//         set
//         {
//             // if (value > 9) _hours = value % 10;
//             // else if (value < 0) _hours = 0;
//             //else
//             _hours = value;

//         }
//     }
//     public int Minutes
//     {
//         get => _minutes; set
//         {
//             // if (value > 59)
//             // {
//             //     _hours += value / 60;
//             //     _minutes = value % 60;
//             // }
//             // else if (value < 0) _minutes = 0;
//             // else
//             _minutes = value;

//         }
//     }

//     public JupiterTime AddHours(int inputHours)
//     {
//         System.Console.WriteLine("inputHours" + inputHours + "Hours" + Hours);
//         Hours += inputHours % 10;
//         return this;
//     }
// }

var time = new JupiterTime(1, 21);
var timeIn20Minutes = time.AddMinutes(-180);// Output Time is 08:21
// var timeIn20Minutes = time.AddMinutes(20);// Output Time is 01:41

PrintTime(timeIn20Minutes);

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
}



