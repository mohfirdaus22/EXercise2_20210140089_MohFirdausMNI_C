using System;
using System.Collections.Specialized;

namespace Exercise2;

class Program
{
    int[] maulana = new int[109];
    int n;
    int i;
    private int[] arr = new int[20];
    private int cmp_count = 0; 
    private int mov_count = 0;

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

    void swap(int x, int y)
    {
        int temp;
        temp = maulana[x];
        maulana[x] = maulana[y];
        maulana[y] = temp;



    }
    public void q_sort(int low, int high)
    {
        int mid, i, Mf;
        if (low > high)
            return;
        i = low + 1;
        Mf = high;

        mid = maulana[low];
        while (i < Mf)
        {
            while ((maulana[i]<=mid) && (i <=mid))
            {
                i++;
                cmp_count++;
            }
            cmp_count++;

            if (i < Mf)
            {
                swap(i, Mf);
                mov_count++;
            }
        }


    }
    
}