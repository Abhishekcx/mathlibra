namespace operatorload
{
    class student
    {
        int marks;
        public student(int m)
    {
            marks = m;
    }
    public static student  operator +(student a, student b)
        {
            student res = new student(0);
            res.marks = a.marks+b.marks;
            return res;
        }
    public static student operator -(student a, student b)
        {
            student res = new student(0);
            res.marks = a.marks - b.marks;
            return res;
          }
        public static bool operator == (student a,
                                       student b)
        { if (a.marks == b.marks)
                return true;
            else
                return false; 
        }
        public static bool operator !=(student a,
                                     student b)
        {
            if (a.marks == b.marks)
                return true;
            else
                return false;
        }
        public void printmarks()
        {
            Console.WriteLine(marks);   
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            student obj1 = new student(77);
            student obj2 = new student(72);

            student add = obj1 + obj2;  
            add.printmarks();   

           student sub = obj1 - obj2;
            sub.printmarks();
            if (obj1 == obj2)
                Console.WriteLine("eqaul");
            else
                Console.WriteLine("mraks not equal");

  
            Console.ReadKey();
        }
    }
}

