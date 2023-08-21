from enum import Enum


class Fan:
    class Speeds(Enum):
        HIGH = 3
        MEDIUM = 2
        LOW = 1
        OFF = 0

    def __init__(self, name: str) -> None:
        self._name = f"{name} fan"
        self.speed = self.Speeds.HIGH

    @property
    def name(self) -> str:
        return self._name

    @name.setter
    def name(self) -> None:
        raise AttributeError("'name' is read only")

    def high(self) -> None:
        self.speed = self.Speeds.HIGH

    def medium(self) -> None:
        self.speed = self.Speeds.MEDIUM

    def low(self) -> None:
        self.speed = self.Speeds.LOW

    def off(self) -> None:
        self.speed = self.Speeds.OFF