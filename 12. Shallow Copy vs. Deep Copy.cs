class Manager
{
    public string Name { get; set; }

    public Manager(string name)
    {
        Name = name;
    }
}

class Department
{
    public string Name { get; set; }
    public Manager DeptManager { get; set; }

    public Department()
    {
        Name = string.Empty;
        DeptManager = new Manager(string.Empty);
    }

    public Department(string name, Manager manager)
    {
        Name = name;
        DeptManager = manager;
    }

    public Department ShallowCopy()
    {
        return (Department)this.MemberwiseClone();
    }

    public Department DeepCopy()
    {
        return new Department(Name, new Manager(DeptManager.Name));
    }
}