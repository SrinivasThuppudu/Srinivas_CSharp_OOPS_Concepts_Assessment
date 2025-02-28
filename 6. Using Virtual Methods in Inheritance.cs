class Person 
{ 
    public virtual void GetDetails() 
    { 
        Console.WriteLine("Person details"); 
    } 
}
class Student1 : Person 
{ 
    string name = "Srini";
    int rollNo = 18;
    public override void GetDetails() 
    { 
        Console.WriteLine($"Student name:{name}, Student Id:{rollNo}"); 
    } 
 }
class Teacher : Person 
{ 
    string name = "Gopinath";
    int batch_no = 2;
    public override void GetDetails() 
    { 
        Console.WriteLine($"Teacher name:{name}, Batch No:{batch_no}"); 
    }
}