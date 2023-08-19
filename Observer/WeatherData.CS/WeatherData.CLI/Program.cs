using Weather.Data;
using Weather.Displays;
using Weather.Interfaces;

public class WeatherStation
{
    public static void Main()
    {
        WeatherData weatherData = new();
        CurrentConditionsDisplay currentDisplay = new(weatherData);
        StatisticsDisplay statisticsDisplay = new(weatherData);
        ForecastDisplay forecastDisplay = new(weatherData);
        HeadIndexDisplay heatIndexDisplay = new(weatherData);

        weatherData.SetMeasurements(80, 65, 30.4);
        weatherData.SetMeasurements(82, 70, 29.2);
        weatherData.SetMeasurements(78, 90, 29.2);
    }
}