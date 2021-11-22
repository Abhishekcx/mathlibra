using System;

namespace arra
{
    class Exercise1
    {
        public static void Main()
        {
            int[] arr = new int[5];
          
            Console.Write("\n\nRead and Print elements of an array:\n");
            Console.Write("-----------------------------------------\n");
            try
            {

                for ( int i = 0; i < arr.Length; i++)
                {
                    Console.Write("element - {0} : ", i);
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("exception occured" + e.Message);


            }



        }
    }
}
