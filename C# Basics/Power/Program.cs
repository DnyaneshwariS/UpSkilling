using System;

namespace Power
{
    class Power{
 
    public static int power(int x, int n)
    {
 int result=1;
      
        if (n == 0)
            return 1;
 

        if (x == 0)
            return 0;
 
       for ( int i = 1; i <= n; i ++)

                  result = result * x;
                  return result;
    }
 
    public static void Main(String[] args)
    {
        int x = 2;
        int n = 3;
 
        Console.WriteLine(power(x, n));
    }
}
}
