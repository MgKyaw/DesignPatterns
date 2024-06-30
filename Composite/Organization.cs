namespace Composite;

class Organization
{
    protected List<IEmployee> employees;

    public Organization()
    {
        employees = new List<IEmployee>();
    }

    public void AddEmployee(IEmployee employee)
    {
        employees.Add(employee);
    }

    public float GetNetSalaries()
    {
        float netSalaries = 0;

        foreach (var employee in employees)
        {
            netSalaries += employee.GetSalary();
        }

        return netSalaries;
    }
}