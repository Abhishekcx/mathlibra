using System;

namespace enumdemo
{
    class program

    {
        enum days

        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,
            Sunday
        }
       
        class Program
        {
            public static void Week(days d)
            {
                Console.WriteLine("days is", d);
        }

            // Main Method
            static void Main(string[] args)
            {
                Week(days.Monday);
                Console.WriteLine("Value of Monday is " +
                                    (int)days.Monday);
                Console.WriteLine("Value of Tuesday is " +
                                            (int)days.Tuesday);
                Console.WriteLine("Value of Wednesday is " +
                                            (int)days.Wednesday);
                Console.WriteLine("Value of Thursday is " +
                                            (int)days.Thursday);
                Console.WriteLine("Value of Friday is " +
                                            (int)days.Friday);
                Console.WriteLine("Value of Saturday is " +
                                            (int)days.Saturday);
                Console.WriteLine("Value of Sunday is " +
                                            (int)days.Sunday);
              
                 


                Console.ReadKey();
            }
        }
    }
}