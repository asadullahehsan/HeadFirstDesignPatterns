using ObserverPattern.Subjects;

namespace ObserverPattern.Observers;

public class StatisticsDisplay : IObserver, IDisplayElement
{
    private float _minTemperature;
    private float _maxTemperature;
    private WeatherData _weatherData;
    
    public StatisticsDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Display()
    {
        float avgTemperature = (_minTemperature + _maxTemperature) / 2;
        Console.WriteLine($"Avg/Max/Min temperature = {avgTemperature:0.0}/{_maxTemperature:0.0}/{_minTemperature:0.0}");
    }

    public void Update()
    {
        if (_minTemperature == 0 && _maxTemperature == 0)
        {
            _minTemperature = _weatherData.Temperature;
            _maxTemperature = _weatherData.Temperature;
        }
        float temp = _weatherData.Temperature;
        if (temp < _minTemperature)
        {
            _minTemperature = temp;
        }
        if (temp > _maxTemperature)
        {
            _maxTemperature = temp;
        }
        Display();
    }
}
