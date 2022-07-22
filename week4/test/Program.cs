interface I1
{
    void Print();
}

interface I2
{
    void Print();
}

public class Program : I1, I2
{
    public void Print(){
        System.Console.WriteLine("print");
    }
    static void Main()
    {
        Program P =new Program();
        P.Print();



    }
}