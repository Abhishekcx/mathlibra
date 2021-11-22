class Jdj
{
    public int findavg(params int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)


        { sum = sum + arr[i];
        }

        int avg;
        avg = sum / arr.Length;
        return avg;

    }
    static void Main(string[] args)
    {
        Jdj h = new Jdj();
       int d= h.findavg(1, 6, 6, 6, 5);
        Console.WriteLine("average" +d);
        Console.ReadKey();

    }
}