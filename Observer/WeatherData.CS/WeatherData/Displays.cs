using Weather.Interfaces;
using Weather.Data;

namespace Weather.Displays;


public class CurrentConditionsDisplay : Observer, DisplayElement
{
    private double Temperature { get; set; }
    private double Humidity { get; set; }
    private WeatherData _WeatherData { get; set; }

    public CurrentConditionsDisplay(WeatherData weatherData)
    {
        this._WeatherData = weatherData;
        this._WeatherData.RegisterObserver(this);
    }

    public void Update()
    {
        this.Temperature = this._WeatherData.Temperature;
        this.Humidity = this._WeatherData.Humidity;
        this.Display();
    }

    public void Display()
    {
        Console.WriteLine(
            $"Current conditions: {this.Temperature} F degrees {this.Humidity} % humidity"
        );
    }
}

public class ForecastDisplay : Observer, DisplayElement
{

    private double CurrentPressure { get; set; } = 29.92;
    private double LastPressure { get; set; }
    private WeatherData _WeatherData;

    public ForecastDisplay(WeatherData _WeatherData)
    {
        this._WeatherData = _WeatherData;
        this._WeatherData.RegisterObserver(this);
    }

    public void Update()
    {
        this.LastPressure = this.CurrentPressure;
        this.CurrentPressure = this._WeatherData.Pressure;
        this.Display();
    }

    public void Display()
    {
        Console.Write("Forecast: ");
        if (this.CurrentPressure > this.LastPressure)
            Console.WriteLine("Improving weather on the way!");

        else if (this.CurrentPressure == this.LastPressure)
            Console.WriteLine("More of the same");

        else if (this.CurrentPressure < this.LastPressure)
            Console.WriteLine("Watch out for cooler, rainy weather");
    }
}

public class StatisticsDisplay : Observer, DisplayElement
{
    private double MaxTemperature { get; set; } = 0.0;
    private double MinTemperature { get; set; } = 200;
    private double TemperatureSum { get; set; } = 0.0;
    private int NumReadings { get; set; }
    private WeatherData _WeatherData;

    public StatisticsDisplay(WeatherData weatherData)
    {
        this._WeatherData = weatherData;
        this._WeatherData.RegisterObserver(this);
    }

    public void Update()
    {
        this.TemperatureSum += this._WeatherData.Temperature;
        this.NumReadings++;

        double temperature = this._WeatherData.Temperature;
        if (temperature > this.MaxTemperature)
            this.MaxTemperature = temperature;
 
        if (temperature < this.MinTemperature)
            this.MinTemperature = temperature;

        this.Display();
    }

    public void Display()
    {
        Console.WriteLine(
              $"Avg/Max/Min temperature = {this.TemperatureSum/this.NumReadings}"
            + $"/{this.MaxTemperature}/{this.MinTemperature}"
        );
    }
}

public class HeadIndexDisplay : Observer, DisplayElement
{
    private double Temperature { get; set; }
    private double Humidity { get; set; }
    private double HeatIndex { get; set; }
    private WeatherData _WeatherData { get; set; }

    public HeadIndexDisplay(WeatherData weatherData)
    {
        this._WeatherData = weatherData;
        this._WeatherData.RegisterObserver(this);
    }

    public void Update()
    {
        this.Temperature = this._WeatherData.Temperature;
        this.Humidity = this._WeatherData.Humidity;
        this.HeatIndex = this.ComputeHeatIndex(this.Temperature, this.Humidity);
        this.Display();
    }

    public void Display()
    {
        Console.WriteLine($"Heat Index is {this.HeatIndex}");
    }

    private double ComputeHeatIndex(double temperature, double humidity)
    {
        double t = temperature;
        double rh = humidity;
        double heatIndex =
            (  ( (16.923)
               + (0.185212 * t)
               + (5.37941 * rh)
               - (0.100254 * t * rh)
               + (0.00941695 * (t * t))
               + (0.00728898 * (rh * rh))
               + (0.000345372 * (t * t * rh))
               - (0.000814971 * (t * rh * rh))
               + (0.0000102102 * (t * t * rh * rh))
               - (0.000038646 * (t * t * t))
               + (0.0000291583 * (rh * rh * rh))
               + (0.00000142721 * (t * t * t * rh))
               + (0.000000197483 * (t * rh * rh * rh))
               - (0.0000000218429 * (t * t * t * rh * rh))
               + 0.000000000843296 * (t * t * rh * rh * rh) )
            - (0.0000000000481975 * (t * t * t * rh * rh * rh)) );
        return heatIndex;
    }
}