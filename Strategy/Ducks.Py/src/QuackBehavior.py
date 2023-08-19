from typing import Protocol


class QuackBehavior(Protocol):
    def quack(self) -> None: ...


def quack() -> None:
    print("Quack")

def mute_quack() -> None:
    print("<< Silence >>")

def squeak() -> None:
    print("Squeak")