from .Interfaces import (
    Subject,
    Observer,
    DisplayElement
)


class WeatherData:
    def __init__(self) -> None:
        self._observers: list[Observer] = []
        self._temperature: float = 0.0
        self._humidity: float = 0.0
        self._pressure: float = 0.0

    @property
    def observers(self) -> list[Observer]:
        return self._observers

    @observers.setter
    def observers(self, *_, **__) -> None:
        raise AttributeError("observers is read-only")

    @property
    def temperature(self) -> float:
        return self._temperature
    
    @temperature.setter
    def temperature(self, *_, **__) -> None:
        raise AttributeError("temperature is read-only")

    @property
    def humidity(self) -> float:
        return self._humidity

    @humidity.setter
    def humidity(self, *_, **__) -> None:
        raise AttributeError("humidity is read-only")

    @property
    def pressure(self) -> float:
        return self._pressure

    @pressure.setter
    def pressure(self, *_, **__) -> None:
        raise AttributeError("pressure is read-only")
    
    def register_observer(self, observer: Observer) -> None:
        self.observers.append(observer)

    def remove_observer(self, observer: Observer) -> None:
        self.observers.remove(observer)

    def notify_observers(self) -> None:
        for observer in self.observers:
            observer.update()

    def measurements_changed(self) -> None:
        self.notify_observers()

    def set_measurements(
        self,
        temperature: float,
        humidity: float,
        pressure: float
    ) -> None:
        self._temperature = temperature
        self._humidity = humidity
        self._pressure = pressure
        self.measurements_changed()
