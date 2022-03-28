namespace Task6
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
    }

}