using Weather.Interfaces;

namespace Weather.Data;


public class WeatherData : Subject
{
    private List<Observer> Observers { get; } = new();
    private double _Temperature;
    public double Temperature
    {
        get => this._Temperature;
    }
    private double _Humidity;
    public double Humidity
    {
        get => this._Humidity;
    }
    private double _Pressure;
    public double Pressure
    {
        get => this._Pressure;
    }

    public void RegisterObserver(Observer observer)
    {
        this.Observers.Add(observer);
    }

    public void RemoveObserver(Observer observer)
    {
        this.Observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (Observer observer in this.Observers)
            observer.Update();
    }

    public void MeasurementsChanged()
    {
        this.NotifyObservers();
    }

    public void SetMeasurements(double temperature, double humidity, double pressure)
    {
        this._Temperature = temperature;
        this._Humidity = humidity;
        this._Pressure = pressure;
        this.MeasurementsChanged();
    }
}