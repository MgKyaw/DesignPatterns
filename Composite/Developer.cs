namespace Composite;

class Developer : IEmployee
{
    private float Salary;
    private string Name;

    public Developer(float salary, string name)
    {
        this.Salary = salary;
        this.Name = name;
    }

    public float GetSalary()
    {
        return this.Salary;
    }

    public string GetName()
    {
        return this.Name;
    }

    public string GetRole()
    {
        return "Developer";
    }
}