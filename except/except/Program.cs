using System;

namespace ErrorHa
{
    class DivNumbers
    {
     
       
        public  void Divide()
        {
            int num1, num2,result;
           


     
        
            try
            {
                Console.WriteLine("please enter the Number1");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("please enter the Number2");
                num2 = Convert.ToInt32(Console.ReadLine());

                result = num1 / num2;
                Console.WriteLine("division is" + result);
            }
            catch (DivideByZeroException e)
            {
     Console.WriteLine("exception occured" +e.Message);
            }
            finally
            {
                Console.WriteLine("program excuted");
            }
        }
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            DivNumbers d = new DivNumbers();
            d.Divide();
            Console.ReadKey();
        }
    }
}
