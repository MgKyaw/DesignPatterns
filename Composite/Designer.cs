namespace Composite;

class Designer : IEmployee
{
    private float Salary;
    private string Name;

    public Designer(float Salary, string Name)
    {
        this.Salary = Salary;
        this.Name = Name;
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
        return "Designer";
    }
}