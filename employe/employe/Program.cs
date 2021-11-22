using System;

namespace arra
{
    class Exercise1
    {
        public static void Main()
        {
            int[] empno = new int[10];
            int[] empname = new int[10];
            int[] empsalry = new int[10];

            Console.Write("\n\nRead and Print empno of an array:\n");
            Console.Write("-----------------------------------------\n");
            try
            {

                for (int i = 0; i < empno.Length; i++)
                {
                    Console.Write("empno - {0} : ", i);

                  
                    empno[i] = Convert.ToInt32(Console.ReadLine());
                   
                }
                for (int i = 0; i < empname.Length; i++)
                {
                    

                    Console.Write("empnname- {0}:", i);
                  
                    empname[i] = Convert.ToChar(Console.ReadLine());
             
                }
                for (int i = 0; i < empsalry.Length; i++)
                {
                   
                    Console.Write("emp salry -{0}:", i);
                   
                    empsalry[i] = Convert.ToInt32(Console.ReadLine());
                }

            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("exception occured" + e.Message);


            }



        }
    }
}
