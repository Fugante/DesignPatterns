from abc import ABC, abstractmethod
from typing import Callable

from . import FlyBehavior
from . import QuackBehavior


fly_method = Callable[[], None]
quack_method = Callable[[], None]


class Duck(ABC):

    def __init__(self, fly_behavior: fly_method, quack_behavior: quack_method) -> None:
        self.fly = fly_behavior
        self.quack = quack_behavior

    @abstractmethod
    def display(self) -> None:
        pass

    def swim(self) -> None:
        print("All ducks float, even decoys!")


class MallardDuck(Duck):
    def __init__(self) -> None:
        super().__init__(FlyBehavior.fly_with_wings, QuackBehavior.quack)

    def display(self) -> None:
        print("I'm a real Mallard duck")


class ModelDuck(Duck):
    def __init__(self) -> None:
        super().__init__(FlyBehavior.fly_no_way, QuackBehavior.quack)

    def display(self) -> None:
        print("I'm a model duck")