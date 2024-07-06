namespace Observer;

class JobPosting : IObservable<JobPost>
{
    private List<IObserver<JobPost>> mObservers = new List<IObserver<JobPost>>();
    private List<JobPost> mJobPosts = new List<JobPost>();

    public IDisposable Subscribe(IObserver<JobPost> observer)
    {
        if(!mObservers.Contains(observer))
            mObservers.Add(observer);

        return new Unsubscriber<JobPost>(mObservers, observer);
    }

    public void AddJob(JobPost jobPost)
    {
        mJobPosts.Add(jobPost);
        Notify(jobPost);
    }

    private void Notify(JobPost jobPost)
    {
        foreach(var observer in mObservers)
        {
            observer.OnNext(jobPost);
        }
    }
}