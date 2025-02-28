using System;

sealed class SecuritySystem
{
    public void Authenticate()
    {
        Console.WriteLine("Authentication Successful!");
    }
}

// This will result in a compilation error
// class MonitorSystem : SecuritySystem
// {
// }