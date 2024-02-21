using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello FinalProject World!!!!!");
        
        // SectionManager newCalculation = new SectionManager();
        // newCalculation.Start();

        // Manning manning = new Manning("concrete");
        // double _coefManning = Math.Round(manning.GetManning(), 3);
        // Console.WriteLine(_coefManning);
        Circular circular = new Circular(5.2, 3, 0.005, "steel");
        Console.WriteLine(circular.NormalHeight());

    }
}