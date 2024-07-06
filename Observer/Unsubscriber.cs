namespace Observer;

internal class Unsubscriber<JobPost> : IDisposable
{
    private List<IObserver<JobPost>> mObservers;
    private IObserver<JobPost> mObserver;

    public Unsubscriber(List<IObserver<JobPost>> observers, IObserver<JobPost> observer)
    {
        mObservers = observers;
        mObserver = observer;
    }

    public void Dispose()
    {
        if(mObservers.Contains(mObserver))
            mObservers.Remove(mObserver);
    }
}