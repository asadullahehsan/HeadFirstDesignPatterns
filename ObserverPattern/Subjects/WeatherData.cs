using ObserverPattern.Observers;

namespace ObserverPattern.Subjects;

public class WeatherData : ISubject
{
    private List<IObserver> _observers;    
    public float Temperature { get; set; }
    public float Humidity { get; set; }
    public float Pressure { get; set; }

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
            observer.Update();
        }
    }

    public void MeasurementsChanged()
    {
        NotifyObservers();
    }

    public void SetMeasurements(float temperature, float humidity, float pressure)
    {
        Temperature = temperature;
        Humidity = humidity;
        Pressure = pressure;
        MeasurementsChanged();
    }
}
