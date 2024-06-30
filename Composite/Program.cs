namespace Composite;

class Program
{
    static void Main(string[] args)
    {
        var developer = new Developer(5000, "John");
        var designer = new Designer(8000, "Peter");

        var organization = new Organization();
        organization.AddEmployee(developer);
        organization.AddEmployee(designer);

        System.Console.WriteLine($"Net salary of employees in this organization is {organization.GetNetSalaries():c}.");
        // Net salary of employees in this organization is $13,000.00.
    }
}