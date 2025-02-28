
using System;
class Vehicle 
{ 
    public virtual void Start() 
    { 
        Console.WriteLine("Vehicle started"); 
    } 
}
class Car : Vehicle 
{ 
    public override void Start() 
    { 
        Console.WriteLine("Car started"); 
    } 
}
class Bike : Vehicle 
{ 
    public override void Start() 
    { 
        Console.WriteLine("Bike started"); 
    } 
}