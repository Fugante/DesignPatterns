from typing import Protocol


class Observer(Protocol):
    def update(self) -> None: ...


class Subject(Protocol):
    def register_observer(self, observer: Observer) -> None: ...
    def remove_observer(self, observer: Observer) -> None: ...
    def notify_observers(self) -> None: ...


class DisplayElement(Protocol):
    def display(self) -> None: ...