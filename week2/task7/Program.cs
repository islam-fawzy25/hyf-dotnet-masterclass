//7. We fell asleep! What should we do now?
namespace Task7
{
    public class JupiterTime
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

    }
    class Program
    {
        static void Main(string[] args)
        {
            var signaler = new Signaler();
            signaler.AddTime(new JupiterTime(2, 00));
            signaler.AddTime(new JupiterTime(4, 00));
            signaler.AddTime(new JupiterTime(6, 00));
            // We woke up at 4:21
            // signaler.Check(new JupiterTime(4, 21));
            // signaler.Check(new JupiterTime(6, 21));
             signaler.Check(new JupiterTime(1, 17));
        }
    }
}
