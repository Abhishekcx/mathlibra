using System;
public class waged
{
    public static void Main(string[] args)
    {
        Double noh,ha ,Gross_Salary;

        Console.Write("Enter hors emply worked for: ");
        noh = Convert.ToInt32(Console.ReadLine());

        
        Gross_Salary = noh * 500;

        
        Console.Write("\nno of hours employ worked for : " + noh);
        Console.Write("\nGross Salary : " + Gross_Salary);
        Console.ReadLine();
    }
}