from abc import (
    ABC,
    abstractclassmethod,
)


class MenuComponent(ABC):

    @property
    def name(self) -> str:
        raise NotImplementedError

    @name.setter
    def name(self) -> None:
        raise ValueError("'name' is read only")

    @property
    def description(self) -> str:
        raise NotImplementedError

    @description.setter
    def description(self) -> None:
        raise ValueError("'description' is read only")

    @property
    def price(self) -> float:
        raise NotImplementedError

    @price.setter
    def price(self) -> None:
        raise ValueError("'price' is read only")

    @property
    def vegetarian(self) -> bool:
        raise NotImplementedError

    @vegetarian.setter
    def vegetarian(self) -> None:
        raise ValueError("'vegetarian' is read only")

    def add(self) -> None:
        raise NotImplementedError

    def remove(self) -> None:
        raise NotImplementedError

    def get_child(self, index: int):
        raise NotImplementedError

    @abstractclassmethod
    def print(self) -> None:...


class MenuItem(MenuComponent):
    def __init__(
        self,
        name: str,
        description: str,
        vegetarian: bool,
        price: float
    ) -> None:
        self._name = name
        self._description = description
        self._vegetarian = vegetarian
        self._price = price

    @property
    def name(self) -> str:
        return self._name

    @property
    def description(self) -> str:
        return self._description

    @property
    def price(self) -> float:
        return self._price

    @property
    def vegetarian(self) -> bool:
        return self._vegetarian

    def print(self) -> None:
        print(f"  {self._name} {'(v)' if self._vegetarian else ''}, {self._price}")
        print(f"   -- {self._description}");


class Menu(MenuComponent):
    def __init__(self, name: str, description: str) -> None:
        self._menu_components: list[MenuComponent] = []
        self._name = name
        self._description = description

    @property
    def name(self) -> str:
        return self._name

    @property
    def description(self) -> str:
        return self._description

    def add(self, menu_component: MenuComponent) -> None:
        self._menu_components.append(menu_component)

    def get_child(self, index: int):
        return self._menu_components[index]

    def print(self) -> None:
        print(f"\n{self._name}, {self._description}")
        print("---------------------")

        for menu_component in self._menu_components:
            menu_component.print()