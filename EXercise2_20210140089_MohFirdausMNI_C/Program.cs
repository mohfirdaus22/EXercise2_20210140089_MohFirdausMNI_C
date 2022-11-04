using System;

namespace Exercise2;

class Program
{
    int[] maulana = new int[109];
    int n;
    int i;

    public void input()
        //array input
    {
        while(true)
        {
            Console.WriteLine("Enter the number of element in array :");
            string s = Console.ReadLine();
            n = Int32.Parse(s);
            if ((n > 0) && (n <= 109))
                break;
            else
                Console.WriteLine("\n Array should have minimum 1 and maximum 109 element. \n");

        }
        //accepst array element
        Console.WriteLine("");
        Console.WriteLine("-------------------");
        Console.WriteLine(" Enter the element ");
        Console.WriteLine("-------------------");
        for (i = 0; i< n; i++)
        {
            Console.Write("<" + (i + 1) + ">");
            string s1 = Console.ReadLine();
            maulana[i] = Int32.Parse(s1);
        }
    }
}