using System;

namespace Exercise2;

class Program
{
    int[] maulana = new int[109];
    int n;
    int i;

    public void input()
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
    }
}