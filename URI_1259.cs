using System;

    class URI
    {
        static void Main(string[] args)
        {
        int N, i, j, k,odd,even,ck,ck1;
         N =Convert.ToInt32(Console.ReadLine());
        int[] array = new int[N];
        even = 0;odd = 0;
        for (i = 0; i < N; i++)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                even++;

            }
            else
            {
                odd++;
            }
            array[i] = num;
        }

        int [] evenarray = new int[even];
        int[] oddarray = new int[odd];
        ck = 0;
        ck1 = 0;
        for (i = 0; i < N; i++)
        {
            if (array[i] % 2 == 0)
            {
                evenarray[ck] = array[i];
                ck++;
            }
            else
            {
                oddarray[ck1] = array[i];
                ck1++;
            }
        }

        Array.Sort(evenarray);
        for (i = 0; i < evenarray.Length; i++)
        {
            Console.WriteLine(evenarray[i]);
        }

        Array.Sort(oddarray);
        Array.Reverse(oddarray);
        for (i = 0; i < oddarray.Length; i++)
        {
            Console.WriteLine(oddarray[i]);
        }

        Console.ReadKey();
        }
    }

