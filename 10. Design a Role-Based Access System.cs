using System;

class User
{
    public string Username { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;

    public virtual void AccessControl()
    {
        Console.WriteLine("Basic User Access.");
    }
}

class Admin : User
{
    public Admin()
    {
        Role = "Admin";
    }

    public override void AccessControl()
    {
        Console.WriteLine("Admin has full access to the system.");
    }
}

class Customer : User
{
    public Customer()
    {
        Role = "Customer";
    }

    public override void AccessControl()
    {
        Console.WriteLine("Customer has limited access.");
    }
}