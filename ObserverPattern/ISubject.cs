namespace ObserverPattern
{
    interface ISubject
    {
        void Attach(IObserver observer);
        void Notify();
    }
}
