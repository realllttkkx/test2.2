class Program
{
    static void Main(string[] args)
    {
        double B1, B2, B3;
        Console.Write("Enter balance 1: ");
        B1 = ReadPositiveNumber();
        Console.Write("Enter balance 2: ");
        B2 = ReadPositiveNumber();
        Console.Write("Enter balance 3: ");
        B3 = ReadPositiveNumber();
        double L = 0; 
        
        while (true)
        {
            Console.Write("Enter payment amount (0 or negative to stop): ");
            double payment = ReadNumber();

            if (payment <= 0)
                break;

            if (payment <= B1)
            {
                B1 -= payment;
            }
            else if (payment <= B2)
            {
                B2 -= payment;
            }
            else if (payment <= B3)
            {
                B3 -= payment;
            }
            else
            {
                L += payment;
            }
        }

        Console.WriteLine($"Balance 1: {B1}");
        Console.WriteLine($"Balance 2: {B2}");
        Console.WriteLine($"Balance 3: {B3}");
        Console.WriteLine($"Left: {L}");
        Console.ReadLine();
    }

    static double ReadPositiveNumber()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.Write("Invalid input. Please enter a positive number: ");
        }
        return number;
    }

    static double ReadNumber()
    {
        double number;
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Invalid input. Please enter a number: ");
        }
        return number;
    }
}