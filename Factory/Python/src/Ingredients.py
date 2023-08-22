from abc import ABC
from typing import Protocol


class Dough(ABC):
    name: str

class Sauce(ABC):
    name: str

class Cheese(ABC):
    name: str

class Veggies(ABC):
    name: str

class Pepperoni(ABC):
    name: str

class Clams(ABC):
    name: str

class ThinCrustDough(Dough):
    name: str = "Thin Crust Dough"

class MarinaraSauce(Sauce):
    name: str = "Marinara Sauce"

class ReggianoCheese(Cheese):
    name: str = "Reggiano Cheese"

class Garlic(Veggies):
    name: str = "Garlic"

class Onion(Veggies):
    name: str = "Onion"

class Mushroom(Veggies):
    name: str = "Mushroom"

class RedPepper(Veggies):
    name: str = "RedPepper"

class SlicedPepperoni(Pepperoni):
    name: str = "SlicedPepperoni"

class FreshClams(Clams):
    name: str = "FreshClams"


class PizzaIngredientFactory(Protocol):
    def create_dough(self) -> Dough:...
    def create_sauce(self) -> Sauce:...
    def create_cheese(self) -> Cheese:...
    def create_veggies(self) -> list[Veggies]:...
    def create_pepperoni(self) -> Pepperoni:...
    def create_clam(self) -> Clams:...


class NYPizzaIngredientFactory:
    def create_dough(self) -> Dough:
        return ThinCrustDough()

    def create_sauce(self) -> Sauce:
        return MarinaraSauce()

    def create_cheese(self) -> Cheese:
        return ReggianoCheese()

    def create_veggies(self) -> list[Veggies]:
        veggies: list[Veggies] = []
        veggies.append(Garlic())
        veggies.append(Onion())
        veggies.append(Mushroom())
        veggies.append(RedPepper())
        return veggies

    def create_pepperoni(self) -> Pepperoni:
        return SlicedPepperoni()

    def create_clam(self) -> Clams:
        return FreshClams()