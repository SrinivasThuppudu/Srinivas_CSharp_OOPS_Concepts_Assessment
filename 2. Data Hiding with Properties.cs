using System;

class Student
{
    public string Name { get;  set; }
    public int RollNo { get;  set; }

    public Student(string name, int rollNo)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Name cannot be null or empty.");
        }

        if (rollNo <= 0)
        {
            throw new ArgumentException("Roll number must be greater than 0.");
        }

        Name = name;
        RollNo = rollNo;
    }
}