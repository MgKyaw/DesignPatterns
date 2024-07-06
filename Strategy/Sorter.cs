namespace Strategy;

class Sorter
{
    private readonly ISortStrategy mSorter;

    public Sorter(ISortStrategy sorter)
    {
        mSorter = sorter;
    }

    public List<int> Sort(List<int> unsortedList)
    {
        return mSorter.Sort(unsortedList);
    }
}