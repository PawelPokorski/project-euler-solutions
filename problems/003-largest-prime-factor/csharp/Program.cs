using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(LargestPrimeFactor(600851475143));
    }
    
    static long LargestPrimeFactor(long n)
    {
        long maxPrime = -1;
        
        while(n % 2 == 0) {
            maxPrime = 2;
            n /= 2;
        }
        
        for(long i = 3; i * i <= n; i += 2)
        {
            while (n % i == 0)
            {
                maxPrime = i;
                n /= i;
            }
        }
        
        if (n > 2)
        {
            maxPrime = n;
        }
            
        return maxPrime;
    }
}
