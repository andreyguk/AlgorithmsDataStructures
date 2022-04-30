
using System.Diagnostics;
using System.Numerics;

Console.WriteLine("SumFactorail");
var n = 10;
Console.WriteLine($"n = {n}");
SumFactorail(n);
SumFactorailTwo(n);

static void SumFactorail(int n) {
    var time = Stopwatch.StartNew();

    BigInteger sum = 0;
    for (int i = 1; i <= n; i++)
    {
        BigInteger subSum = 1;

        for (int j = 1; j <= i; j++)
        {
            subSum *= j;
        }
        sum += subSum;
    }
    time.Stop();
    Console.WriteLine($"sum_test_1 = {sum}, time = {time.Elapsed.Ticks} ");
}

static void SumFactorailTwo(int n)
{   
    var time = Stopwatch.StartNew();

    BigInteger sum = 0;
    BigInteger subSum = 1;
    for (int i = 1; i <= n; i++)
    {
        subSum *= i;
        
        sum += subSum;
    }
    time.Stop();
    Console.WriteLine($"sum_test_2 = {sum}, time = {time.Elapsed.Ticks} ");
}