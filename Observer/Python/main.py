from src import (
    WeatherData,
    Displays
)


def main() -> None:
    weather_data = WeatherData.WeatherData()
    current_display = Displays.CurrentConditionsDisplay(weather_data)
    statistics_display = Displays.StatisticsDisplay(weather_data)
    forecast_display = Displays.ForecastDisplay(weather_data)
    heat_index_display = Displays.HeadIndexDisplay(weather_data)

    weather_data.set_measurements(80, 65, 30.4)
    weather_data.set_measurements(82, 70, 29.2)
    weather_data.set_measurements(78, 90, 29.2)


if __name__ == "__main__":
    main()