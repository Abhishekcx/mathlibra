namespace ABSTARCTCLASS
{
    abstract class account
    {
        public abstract void interest();

    }
    class saving : account
    {
        public override void interest()
        {
            Console.WriteLine("saving account");

        }
    }
    class current : account
    {
        public override void interest()
        {
            Console.WriteLine("current account");

        }
    }
    class fdaccount : account
    {
        public override void interest()
        {
            Console.WriteLine("fd account");

        }
    }
    class program
    {
        public void Callinterest(account s)
        {
            s.interest();
        }

        static void Main(string[] args)
        {
          saving a = new saving();
            a.interest();
            current b = new current();
            b.interest();
            fdaccount c = new fdaccount();
            c.interest();
            a.interest();
           b.interest();    
            c.interest();   
            Console.WriteLine(a);

            Console.ReadKey();

        }
    }
}
