class Light:

    def __init__(self, name: str) -> None:
        self._name = f"{name} light"

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