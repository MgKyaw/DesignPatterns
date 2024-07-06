namespace Strategy;

class BubbleSort : ISortStrategy
{
    public List<int> Sort(List<int> unsortedSort)
    {
        Console.WriteLine("Sorting using Bubble Sort!");
        return unsortedSort;
    }
}