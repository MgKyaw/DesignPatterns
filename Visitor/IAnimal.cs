namespace Visitor;

interface IAnimal
{
    public void Accept(IAnimalOperation operation);
}