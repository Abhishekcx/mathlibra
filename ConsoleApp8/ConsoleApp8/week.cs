
class Program
{

    static void Main(string[] args)
    {
        int weekn;
        Console.Write("Enter Month Number (1 - 12): ");
        weekn = Convert.ToInt32(Console.ReadLine());

        switch (weekn)
        {
            case 1:
                Console.WriteLine("sun");
                break;
            case 2:
                Console.WriteLine("mon");
                break;
            case 3:
                Console.WriteLine("tues");
                break;
            case 4:
                Console.WriteLine("wed");
                break;
            case 5:
                Console.WriteLine("thrus");
                break;
            case 6:
                Console.WriteLine("fri");
                break;


            default:
                Console.WriteLine("you did not enter correct value for week name");
                break;
        }

        Console.ReadLine();
    }
}
