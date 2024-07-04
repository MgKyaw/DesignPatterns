using System.Collections;

namespace Iterator;

class StationList : IEnumerable<RadioStation>
{
    private List<RadioStation> mStations = new List<RadioStation>();

    public RadioStation this[int index]
    {
        get { return mStations[index]; }
        set { mStations.Insert(index, value); }
    }

    public void Add(RadioStation station)
    {
        mStations.Add(station);
    }

    public void Remove(RadioStation station)
    {
        mStations.Remove(station);
    }

    public IEnumerator<RadioStation> GetEnumerator()
    {
        return mStations.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}