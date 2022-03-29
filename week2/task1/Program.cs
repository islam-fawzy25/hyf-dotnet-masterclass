// 1. A simple tracker

// Let's create a new class called JupiterTime. It needs to have two properties: Hours and Minutes so that the following code works:

var time = new JupiterTime();
time.Hours = 8;
time.Minutes = 40;
PrintTime(time);

static void PrintTime(JupiterTime time){
if (time.Minutes < 10)
{
   Console.WriteLine($"Time is {time.Hours}:0{time.Minutes}");

}else
 Console.WriteLine($"Time is {time.Hours}:{time.Minutes}");
}

class JupiterTime
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
}
// Now create a function called PrintTime which accepts JupiterTime as a parameter and prints out HH:mm. If we run:



