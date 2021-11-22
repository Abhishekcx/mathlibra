namespace seale
{
    class Parent
    {
        public virtual void Demo()
        {
            Console.WriteLine("parent class");
        }
    }
    class Child : Parent
    {
        public  sealed override void Demo()
        {
            Console.WriteLine("child class");
        }
    }
    class grandChild : Child
    {
        public  override void Demo()
        {
            Console.WriteLine("grand child class");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
        }
    }
}