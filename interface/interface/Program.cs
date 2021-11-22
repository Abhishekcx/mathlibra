namespace interfacedem
{
    interface IPrintable

    {
        public void Saving();
        
        public void Current();

       
    }
    class Account: IPrintable
    {
        public void Current()
        {
            throw new NotImplementedException();
        }

        public void Saving()
      
        {
            Console.WriteLine("saving");
        }
    
    }
    class Employee : IPrintable 
    {
        public void Current()
        {
            throw new NotImplementedException();
        }

        public  void Saving()
        {
            Console.WriteLine("employee");
        }
    
    }
    class Program

    {
        public void Current()
        {
            throw new NotImplementedException();
        }

        public void Saving()

        {
            Console.WriteLine("saving");
        }


        static void Main(string[] args)
        {


            Employee e = new Employee();
            Program p = new Program();
            e.Saving();
            p.Saving();


        }
    }
}