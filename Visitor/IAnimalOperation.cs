namespace Visitor;

interface IAnimalOperation
{
    public void VisitMonkey(Monkey monkey);
    public void VisitLion(Lion lion);
    public void VisitDolphin(Dolphin dolphin);
}