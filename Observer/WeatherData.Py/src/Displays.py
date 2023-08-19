from .Interfaces import (
    Subject,
    Observer,
    DisplayElement
)


class CurrentConditionsDisplay:

    def __init__(self, weather_data: Subject) -> None:
        self._temperature: float = 0.0
        self._humidity: float = 0.0
        self._weather_data: Subject = weather_data
        self._weather_data.register_observer(self)

    def update(self) -> None:
        self._temperature = self._weather_data.temperature
        self._humidity = self._weather_data.humidity
        self.display()

    def display(self) -> None:
        print(
            f"Current conditions: {self._temperature} F degrees "
            f"{self._humidity} % humidity"
        )


class ForecastDisplay:

    def __init__(self, weather_data: Subject) -> None:
        self._current_pressure: float = 29.92
        self._last_pressure: float = 0.0
        self._weather_data = weather_data
        self._weather_data.register_observer(self)

    def update(self) -> None:
        self._last_pressure = self._current_pressure
        self._current_pressure = self._weather_data.pressure
        self.display()

    def display(self) -> None:
        print("Forecast: ", end="")
        if self._current_pressure > self._last_pressure:
             print("Improving weather on the way!")

        elif self._current_pressure == self._last_pressure:
            print("More of the same")

        elif self._current_pressure < self._last_pressure:
            print("Watch out for cooler, rainy weather")


class StatisticsDisplay:

    def __init__(self, weather_data: Subject) -> None:
        self._max_temperature: float = 0
        self._min_temperature: float = 200
        self._temperature_sum: float = 0
        self._num_readings: int = 0
        self._weather_data: Subject = weather_data
        self._weather_data.register_observer(self)

    def update(self) -> None:
        temperature = self._weather_data.temperature
        self._temperature_sum += temperature
        self._num_readings += 1

        if temperature > self._max_temperature:
            self._max_temperature = temperature

        if temperature < self._min_temperature:
            self._min_temperature = temperature

        self.display()

    def display(self) -> None:
        print(
            f"Avg/Max/Min temperature = {self._temperature_sum/self._num_readings}"
            f"/{self._max_temperature}/{self._min_temperature}"
        )


class HeadIndexDisplay:

    def __init__(self, weather_data: Subject):
        self._temperature = 0
        self._humidity = 0
        self._heat_index = 0
        self._weather_data = weather_data
        self._weather_data.register_observer(self)

    def update(self) -> None:
        self._temperature = self._weather_data.temperature
        self._humidity = self._weather_data.humidity
        self._heat_index = self.compute_heat_index(self._temperature, self._humidity)
        self.display()

    def display(self) -> None:
        print(f"Heat Index is {self._heat_index}")

    def compute_heat_index(self, temperature: float, humidity: float) -> float:
        t = temperature
        rh = humidity
        heat_index = (
            (    (16.923)
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
            - (0.0000000000481975 * (t * t * t * rh * rh * rh))
        )
        return heat_index