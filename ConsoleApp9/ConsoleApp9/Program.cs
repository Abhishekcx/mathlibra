namespace EMP
{

    class Program
    {
     
        static void Main(string[] args )
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            EMPLOYEE a = new EMPLOYEE();
            a.Salary(a);

        }

    }

    class EMPLOYEE
    {
       public int empno, salary;

      public  string ename, designation;

        public void EMPNO(int b)
        {
            Console.WriteLine("ENTER EMPLOYEE NO");
            empno = Convert.ToInt32(Console.ReadLine());

        }
#pragma warning disable IDE0060 // Remove unused parameter
        public void Salary( int h)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            Console.WriteLine("ENTER saary");
            salary = Convert.ToInt32(Console.ReadLine());

        }
        public void Ename(string f)
        {
            Console.WriteLine("enter employ name");
#pragma warning disable CS8601 // Possible null reference assignment.
            ename = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.

        }
        public void Desig(string s)
        {
            Console.WriteLine("enter desig");
#pragma warning disable CS8601 // Possible null reference assignment.
            designation = Console.ReadLine();
#pragma warning restore CS8601 // Possible null reference assignment.


        }
      
    }
}