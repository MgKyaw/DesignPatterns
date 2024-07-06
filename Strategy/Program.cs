namespace Strategy;

class Program 
{
    static void Main(string[] args)
    {
        var unsortedList = new List<int> {1, 2, 10, 5, 9, 6};

        var sorter = new Sorter(new BubbleSort());
        sorter.Sort(unsortedList);

        sorter = new Sorter(new QuickSort());
        sorter.Sort(unsortedList);
    }
}