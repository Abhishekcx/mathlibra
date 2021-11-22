using mathlibra;

namespace classff

{
    class program

    {
        static void Main(string[] args)
        {
            mathlibra.Mathclass Obj = new Mathclass();
            Console.WriteLine(Obj.add(4, 5));

            Console.WriteLine(Obj.div(4, 5));


            Console.WriteLine(Obj.sub(4, 5));

            Console.WriteLine(Obj.mul(5, 6));
            Console.ReadKey();
        }

    }
}