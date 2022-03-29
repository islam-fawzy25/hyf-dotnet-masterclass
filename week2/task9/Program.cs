//9. Ganymede calls
var alienJuptier = new JupiterTime(14, 25);
var alienTitan = new TitanTime(10, 40);
var alienganymede = new GanymedeTime(20, 25);
System.Console.WriteLine(alienganymede);
public abstract class AlienTime
{
    public int Hours { get; set; }
    public int Minutes { get; set; }
    private int _hoursInDay;
    public AlienTime(int hours, int minutes, int hoursInDay)
    {
        Hours = hours;
        Minutes = minutes;
        _hoursInDay = hoursInDay;
    }
    public override string ToString()
    {
        return $"Alien Time {Hours.ToString("00.##")}:{Minutes.ToString("00.##")}/{_hoursInDay.ToString()} Days";
    }
}
public class JupiterTime : AlienTime
{
    public JupiterTime(int hours, int minutes)
        : base(hours, minutes, 10)
    { }
}
public class TitanTime : AlienTime
{
    public TitanTime(int hours, int minutes)
        : base(hours, minutes, 900)
    { }
}
public class GanymedeTime : AlienTime
{
    public GanymedeTime(int hours, int minutes)
        : base(hours, minutes, 171)
    { }
}