namespace f
{
    public class employee
    {
       virtual public void persondet()
        {
            Console.WriteLine("this is the employ class");
        }
    }
    public class waged : employee
    {
        public override void persondet()
        {
            Console.WriteLine("this is the wa child class");

        }
    }
    public class permanent : employee
    {
        public void perm()
        {
            Console.WriteLine("this is the  perm child class");

        }
    }

    class program
    {
        static void Main(string[] args)
        {
            waged w = new waged();
            w.persondet();


        }
    }
}