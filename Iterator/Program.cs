namespace Iterator;

class Program 
{
    static void Main(string[] args)
    {
        var stations = new StationList();
        var station1 = new RadioStation(89);
        stations.Add(station1);

        var station2 = new RadioStation(101);
        stations.Add(station2);

        var station3 = new RadioStation(102);
        stations.Add(station3);

        foreach(var station in stations)
        {
            Console.WriteLine(station.GetFrequency());
        }

        var q = stations.Where(s => s.GetFrequency() == 89).FirstOrDefault();
        Console.WriteLine(q.GetFrequency());

        Console.ReadLine();
    }
}