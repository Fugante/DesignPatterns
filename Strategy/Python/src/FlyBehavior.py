from typing import Protocol


class FlyBehavior(Protocol):
    def fly(self) -> None: ...


def fly_no_way() -> None:
    print("I can't fly")

def fly_with_wings() -> None:
    print("I'm flying!!")

def fly_rocket_powered() -> None:
    print("I'm flying with a rocket!")