from abc import ABC, abstractmethod

from . import Pizza
from . import Ingredients


class PizzaStore(ABC):
    def order_pizza(self, pizza_type: str) -> Pizza.Pizza:
        pizza: Pizza.Pizza = self.create_pizza(pizza_type)
        pizza.prepare()
        pizza.bake()
        pizza.cut()
        pizza.box()
        return pizza

    @abstractmethod
    def create_pizza(self, pizza_type: str) -> Pizza.Pizza:...


class NYPizzaStore(PizzaStore):
    def create_pizza(self, pizza_type: str) -> Pizza.Pizza:
        pizza: Pizza.Pizza = None
        ingredient_factory = Ingredients.NYPizzaIngredientFactory()

        if pizza_type == "cheese":
            pizza = Pizza.CheesePizza(ingredient_factory)
            pizza.name = "New York Style Cheese Pizza"
        # elif (type == "veggie")
            # return new NYStyleVeggiePizza()
        # elif (type == "clam")
            # return new NYStyleClamPizza()
        # elif (type == "pepperoni")
            # return new NYStylePepperoniPizza()
        return pizza