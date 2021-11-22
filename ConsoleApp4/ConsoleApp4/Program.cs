// See https://aka.ms/new-console-template for more information
{int count = 0;
Console.WriteLine("Prime numbers between 1 and 100 are: ");
Console.WriteLine("==============================================");
for (int i = 1; i < 101; i++)
{
    count = 0;
        if (i > 1)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    count = 1;
                    break;
                }
            }
            if (count == 0)
            {
                Console.Write(i + "  ");
            }
        }