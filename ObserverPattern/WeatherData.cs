namespace ObserverPattern;

public class WeatherData : ISubject
{
    private List<IObserver> _observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData()
    {
        _observers = new List<IObserver>();
    }

    public void RegisterObserver(IObserver O) => _observers.Add(O);
    public void RemoveObserver(IObserver O) => _observers.Remove(O);
    public void NotifyObservers()
    {
        foreach (IObserver observer in _observers)
        {
            observer.Update(temperature, humidity, pressure);
        }
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;
        MeasurementsChanged();
    }
}
