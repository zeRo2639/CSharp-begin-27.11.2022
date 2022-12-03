int N = Convert.ToInt32(Console.ReadLine());
       int res = 1;
       while (res < N)
       {
        Console.WriteLine(res+1);
       if (res % 2 == 0)
        Console.WriteLine(res);
        res = res + 2;
       }