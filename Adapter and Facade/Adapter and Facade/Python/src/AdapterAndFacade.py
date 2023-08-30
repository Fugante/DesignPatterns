import random

from .Duck import Duck
from .Turkey import Turkey


class TurkeyAdapter:
 
    def __init__(self, turkey: Turkey) -> None:
        self.turkey = turkey

    def quack(self) -> None:
        self.turkey.gobble()

    def fly(self) -> None:
        for i in range(5):
            self.turkey.fly()


class DuckAdapter:

    def __init__(self, duck: Duck) -> None:
        self.duck = duck

    def gobble(self) -> None:
        self.duck.quack()

    def fly(self) -> None:
        if random.randint(0, 4) == 4:
            self.duck.fly()