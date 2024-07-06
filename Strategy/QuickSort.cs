namespace Strategy;

class QuickSort : ISortStrategy
{
    public List<int> Sort(List<int> unsortedList)
    {
        Console.WriteLine("Sorting using Quick Sort!");
        return unsortedList;
    }
}