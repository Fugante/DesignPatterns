from abc import ABC, abstractmethod

from . import Ingredients


class Pizza(ABC):
    name: str
    dough: Ingredients.Dough
    sauce: Ingredients.Sauce
    veggies: list[Ingredients.Veggies]
    cheese: Ingredients.Cheese
    pepperoni: Ingredients.Pepperoni
    clams: Ingredients.Clams

    @abstractmethod
    def prepare(self) -> None:...

    def bake(self) -> None:
        print("Bake for 25 minutes at 350")

    def cut(self) -> None:
        print("Cutting the pizza into diagonal slices")

    def box(self) -> None:
        print("Place pizza in official PizzaStore box")


class CheesePizza(Pizza):

    def __init__(self, ingredient_factory: Ingredients.PizzaIngredientFactory) -> None:
        self._ingredient_factory = ingredient_factory

    def prepare(self) -> None:
        print(f"Preparing {self.name}")
        self.dough = self._ingredient_factory.create_dough()
        self.sauce = self._ingredient_factory.create_sauce()
        self.cheese = self._ingredient_factory.create_cheese()


class ClamPizza(Pizza):

    def __init__(self, ingredient_factory: Ingredients.PizzaIngredientFactory) -> None:
        self._ingredient_factory = ingredient_factory

    def prepare(self) -> None:
        print(f"Preparing {self.Name}")
        self.dough = self._ngredient_factory.create_dough()
        self.sauce = self._ngredient_factory.create_sauce()
        self.cheese = self._ngredient_factory.create_cheese()
        self.clam = self._ngredient_factory.create_clam()