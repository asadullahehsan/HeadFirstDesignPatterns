namespace ObserverPattern;

public interface ISubject
{
    public void RegisterObserver(IObserver O);
    public void RemoveObserver(IObserver O);
    public void NotifyObservers();
}
