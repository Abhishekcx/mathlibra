namespace properties
{
    static class Program
    {
        private static void Main()
        {
            Employee emp1 = new Employee();
            emp1.FirstName = "John";
            emp1.empno = 55;
            emp1.Salary = 1000;
            emp1.desig = "manager";

            Console.WriteLine("FirstName:{0}\nempno: {1} \nSalary: {2}\ndesign:{3}",
                emp1.FirstName, emp1.empno, emp1.Salary,emp1.desig);

            Employee emp2 = new Employee();
            emp2.FirstName = "John";
            emp2.empno = 56;
            emp2.Salary = 6556000;
            emp1.desig = "presi";
            Console.WriteLine("FirstName:{0}\nempno: {1} \nSalary: {2}\ndesig:{3}",
                emp2.FirstName, emp2.empno, emp2.Salary,emp1.desig);


            Console.ReadLine();
        }
    }
    public class Employee
    {
        private string _firstName;
        private int _empno;
        private int _salary;
        private string _desig;

        public int Salary
        {
            get
            {
                return _salary;
            }
            set
            {
                if (value < 0)
                    throw new Exception("Salary can not be negative");
                _salary = value;
            }
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                if (value == null)
                    throw new Exception("FirstName can not be Null");
                _firstName = value;
            }
        }

        public int empno
        {
            get
            {
                return _empno;
            }
            set
            {
                if (value == null)
                    throw new Exception("no can not be Null");
                _empno = value;
            }
        }

        public string desig
        {
            get
            {
                return _desig;
            }
            set
            {
                if (value == null)
                    throw new Exception("desig can not be Null");
                _desig = value;
            }
        }
    }
}