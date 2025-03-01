﻿using ObserverPattern.Subjects;

namespace ObserverPattern.Observers;

public class ForecastDisplay : IObserver, IDisplayElement
{
    private float currentPressure = 29.22f;
    private float lastPressure;
    private WeatherData _weatherData;

    public ForecastDisplay(WeatherData weatherData)
    {
        _weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update()
    {
        lastPressure = currentPressure;
        currentPressure = _weatherData.Pressure;
        Display();
    }

    public void Display()
    {
        Console.WriteLine($"Last pressure: {lastPressure}, current pressure: {currentPressure}");
    }
}
