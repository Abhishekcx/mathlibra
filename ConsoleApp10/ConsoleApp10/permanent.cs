using System;
public class Demo
{
    public static void Main(string[] args)
    {
        Double BasicSal, DA, HRA, GrossSal;

        Console.Write("Enter Basic Salary : ");
        BasicSal = Convert.ToInt32(Console.ReadLine());

        DA = (BasicSal * 30) / 100;
        HRA = (BasicSal* 50) / 100;
        GrossSal = BasicSal + DA + HRA;

        Console.Write("\n\nDearness Allowance 30% of Basic Salary : " + DA);
        Console.Write("\nHouse Rent 50% of Basic Salary : " + HRA);
        Console.Write("\nGross Salary : " + GrossSal);
        Console.ReadLine();
    }
}
