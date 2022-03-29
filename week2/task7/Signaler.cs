namespace Task7
{
    public class Signaler
    {
        List<JupiterTime> TimeList = new List<JupiterTime>();
        public void AddTime(JupiterTime time)
        {
            TimeList.Add(time);
        }
        public void Inform()
        {
            if (TimeList.Count == 0) System.Console.WriteLine("No timers added yet.");

            foreach (var item in TimeList)
            {
                System.Console.WriteLine(item);
            }
        }
        public void Check(JupiterTime time)
        {
            foreach (var item in TimeList)
            {
                if (item.Hours <= time.Hours && item.Minutes < time.Minutes) System.Console.WriteLine(item.Hours.ToString("00.##") + ":" + item.Minutes.ToString("00.##"));

            }
            System.Console.WriteLine("No signals needed to be sent yet.");
        }
    }
}