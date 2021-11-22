namespace userde
{
    class program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("C:\\Users\\USHA DAHIKAR\\source\\ repos");
            if (di.Exists)
            { Console.WriteLine(di.FullName);
                Console.WriteLine(di.CreationTime);
                Console.WriteLine(di.Parent);

            }




            else
            {
                di.Create();

                Console.WriteLine("direct created");
            }
            Console.ReadKey();
        }
       
     }
}