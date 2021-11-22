namespace operatorload
{
    class student
{
    int marks;
    public student(int m)
    {
        marks = m;
    }
    public static student operator +(student a, student b)
    {
        student res = new student(0);
        res.marks = a.marks + b.marks;
        return res;
    }
    public static student operator -(student a, student b)
    {
        student res = new student(0);
        res.marks = a.marks - b.marks;
        return res;
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


        Console.ReadKey();
    }
}
}
