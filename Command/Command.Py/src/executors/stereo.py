class Stereo:

    def __init__(self, name: str) -> None:
        self._name = f"{name} stereo"
        self.speed = self.Speeds.HIGH

    @property
    def name(self) -> str:
        return self._name

    @name.setter
    def name(self) -> None:
        raise AttributeError("'name' is read only")

    def on(self) -> None:
        print(f"{self._name} is on")

    def off(self) -> None:
        print(f"{self._name} is off")

    def set_cd(self) -> None:
        print(f"{self._name} is set for CD input")

    def set_dvd(self) -> None:
        print(f"{self._name} is set for DVD input")

    def set_radio(self) -> None:
        print(f"{self._name} is set to radio")

    def set_volume(self, volume: int) -> None:
        print(f"{self._name} volume is set to {volume}")