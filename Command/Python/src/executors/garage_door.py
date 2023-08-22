class GarageDoor:

    def __init__(self, name: str) -> None:
        self._name = f"{name} door"
        self.speed = self.Speeds.HIGH

    @property
    def name(self) -> str:
        return self._name

    @name.setter
    def name(self) -> None:
        raise AttributeError("'name' is read only")

    def up(self) -> None:
        print(f"{self._name} is open")

    def down(self) -> None:
        print(f"{self._name} is closed")

    def stop(self) -> None:
        print(f"{self._name} stopping action")

    def light_on(self) -> None:
        print(f"{self._name} light is on")

    def light_off(self) -> None:
        print(f"{self._name} light is off")