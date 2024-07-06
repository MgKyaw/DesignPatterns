namespace Observer;

class JobSeeker : IObserver<JobPost>
{
    public string Name { get; private set; }

    public JobSeeker(string name)
    {
        Name = name;
    }

    public void OnCompleted()
    {

    }

    public void OnError(Exception error)
    {

    }

    public void OnNext(JobPost jobPost)
    {
        Console.WriteLine($"Hi {Name}! New job posted: {jobPost.Name}");
    }
}