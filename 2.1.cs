class Program
{
    static void Main(string[] args)
    {
        Console.Write("Water tank capacity: ");
        double Vmax = Convert.ToDouble(Console.ReadLine());
        Console.Write("The average volume of water that participants drank during each break: ");
        double VdrinkAvg = Convert.ToDouble(Console.ReadLine());
        Console.Write("Volume of water that can be added in each water filling cycle: ");
        double Vfill = Convert.ToDouble(Console.ReadLine());
        Console.Write("The interval between breaks: ");
        double tdaytdrink = Convert.ToDouble(Console.ReadLine());
        Console.Write("Interval between filling cycles: ");
        double tdaytfill = Convert.ToDouble(Console.ReadLine());
        Console.Write("The total duration of the event from start to finish of the day: ");
        double totalTime = Convert.ToDouble(Console.ReadLine());
        double fillAmount = (totalTime - (tdaytdrink + tdaytfill)) * Vfill;
        double drinkAmount = tdaytdrink * VdrinkAvg;
        double remainingWater = Vmax - (fillAmount + drinkAmount);

        if (remainingWater >= 0)
        {
            Console.WriteLine($"Enough Water, {remainingWater} left");
        }
        else if (fillAmount > Vmax)
        {
            Console.WriteLine("Overflow Water");
        }
        else
        {
            Console.WriteLine("Not Enough Water");
        }
    }
}