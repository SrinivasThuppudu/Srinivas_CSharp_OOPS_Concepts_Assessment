using System;

interface IDiscountStrategy
{
    double ApplyDiscount(double amount);
    double GetDiscountAmount(double amount);
}

class NoDiscount : IDiscountStrategy
{
    public double ApplyDiscount(double amount)
    {
        return amount;
    }

    public double GetDiscountAmount(double amount)
    {
        return 0;
    }
}

class PercentageDiscount : IDiscountStrategy
{
    private double percentage;
    
    public PercentageDiscount(double percentage)
    {
        this.percentage = percentage;
    }

    public double ApplyDiscount(double amount)
    {
        return amount - (amount * (percentage / 100));
    }

    public double GetDiscountAmount(double amount)
    {
        return amount * (percentage / 100);
    }
}

class FixedAmountDiscount : IDiscountStrategy
{
    private double discountAmount;

    public FixedAmountDiscount(double discountAmount)
    {
        this.discountAmount = discountAmount;
    }

    public double ApplyDiscount(double amount)
    {
        return Math.Max(0, amount - discountAmount);
    }

    public double GetDiscountAmount(double amount)
    {
        return Math.Min(amount, discountAmount);
    }
}

class ShoppingCart
{
    private IDiscountStrategy discountStrategy;

    public ShoppingCart(IDiscountStrategy discountStrategy)
    {
        this.discountStrategy = discountStrategy;
    }

    public void Checkout(double totalAmount)
    {
        double discountAmount = discountStrategy.GetDiscountAmount(totalAmount);
        double finalAmount = discountStrategy.ApplyDiscount(totalAmount);
        Console.WriteLine($"Total Amount: {totalAmount}");
        Console.WriteLine($"Discount Given: {discountAmount}");
        Console.WriteLine($"Final Amount after Discount: {finalAmount}");
    }
}
