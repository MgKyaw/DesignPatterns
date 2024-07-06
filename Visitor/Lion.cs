namespace Visitor;

class Lion : IAnimal
{
    public void Roar()
    {
        Console.WriteLine("Roar!");
    }

    public void Accept(IAnimalOperation operation)
    {
        operation.VisitLion(this);
    }
}