using ObserverPattern.Subjects;

namespace ObserverPattern.Observers;

class CurrentConditionsDisplay : IObserver, IDisplayElement
{
    private float _temperature;
    private float _humidity;
    private WeatherData _weatherData;

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }
    void IObserver.Update()
    {
        _temperature = _weatherData.Temperature;
        _humidity = _weatherData.Humidity;
        Display();
    }
    public void Display()
    {
        Console.WriteLine($"Current conditions: {_temperature} F degrees and {_humidity}% humidity");
    }
}
