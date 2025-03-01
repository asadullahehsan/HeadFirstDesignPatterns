using ObserverPattern.Observers;
using ObserverPattern.Subjects;

Console.WriteLine("Observer Pattern");
Console.WriteLine("Weather O Rama\n\n");

#region Subject
WeatherData weatherData = new WeatherData();
#endregion

#region Observers
CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherData);
ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);
//StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData);
#endregion

weatherData.SetMeasurements(80, 65, 30.4f);
weatherData.SetMeasurements(82, 70, 29.2f);
weatherData.SetMeasurements(78, 90, 29.2f);
