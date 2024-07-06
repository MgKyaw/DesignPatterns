namespace Observer;

class Program 
{
    static void Main(string[] args)
    {
        var johnDoe = new JobSeeker("John Doe");
        var janeDoe = new JobSeeker("Jane Doe");
        
        var jobPosting = new JobPosting();
        jobPosting.Subscribe(johnDoe);
        jobPosting.Subscribe(janeDoe);

        jobPosting.AddJob(new JobPost("Software Engineering"));
    }
}