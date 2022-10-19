using System;
using System.Globalization;
using System.Numerics;

BigInteger a = 0;
BigInteger b = 1;
BigInteger fibo = 0;
BigInteger fibo1 = 0;
int sayac = 0;
int sayac1 = 0;
for (int i = 1; i > 0; i++)
{

    fibo = a + b;
    a = b;
    b = fibo;
    sayac++;
    sayac1 = 0;
    fibo1 = fibo;
    while (fibo1 > 0)
    {
        fibo1 = fibo1 / 10;
        sayac1++;
    }
    if (sayac1 == 1000)
    {
        Console.WriteLine(sayac+1);
        
    }
}



Console.ReadKey(true);
Console.Clear();


