
using System;
class Bank
{
    private static double InterestRate = 3.5;

    public static void SetInterestRate(double rate)
    {
        InterestRate = rate;
    }

    public static double GetInterestRate()
    {
        return InterestRate;
    }
}