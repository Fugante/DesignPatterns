from abc import ABC, abstractproperty


class Beverage(ABC):

    @abstractproperty
    def description(self) -> str:
        pass

    @abstractproperty
    def cost(self) -> str:
        pass


class CondimentDecorator(Beverage):

    def __init__(self, beverage: Beverage) -> None:
        self._beverage = beverage

    @abstractproperty
    def beverage(self) -> Beverage:
        pass


# BEVERAGES

class Espresso(Beverage):

    def __init__(self) -> None:
        self._description: str = "Espresso"
        self._cost: float = 1.99

    @property
    def description(self) -> str:
        return self._description

    @description.setter
    def description(self, *_, **__) -> None:
        raise ValueError("description is read only")

    @property
    def cost(self) -> float:
        return self._cost

    @cost.setter
    def cost(self, *_, **__) -> None:
        raise ValueError("cost is read only")


class HouseBlend(Beverage):

    def __init__(self) -> None:
        self._description: str = "HouseBlend"
        self._cost: float = 0.89

    @property
    def description(self) -> str:
        return self._description
    
    @description.setter
    def description(self, *_, **__) -> None:
        raise ValueError("description is read only")

    @property
    def cost(self) -> float:
        return self._cost

    @cost.setter
    def cost(self, *_, **__) -> None:
        raise ValueError("cost is read only")


class DarkRoast(Beverage):

    def __init__(self) -> None:
        self._description: str = "DarkRoast"
        self._cost: float = 0.99

    @property
    def description(self) -> str:
        return self._description

    @description.setter
    def description(self, *_, **__) -> None:
        raise ValueError("description is read only")

    @property
    def cost(self) -> float:
        return self._cost
    
    @cost.setter
    def cost(self, *_, **__) -> None:
        raise ValueError("cost is read only")


class Decaf(Beverage):

    def __init__(self) -> None:
        self._description: str = "Decaf"
        self._cost: float = 1.05

    @property
    def description(self) -> str:
        return self._description

    @description.setter
    def description(self, *_, **__) -> None:
        raise ValueError("description is read only")

    @property
    def cost(self) -> float:
        return self._cost
    
    @cost.setter
    def cost(self, *_, **__) -> None:
        raise ValueError("cost is read only")


# CONDIMENTS

class Mocha(CondimentDecorator):

    def __init__(self, beverage: Beverage) -> None:
        super().__init__(beverage)

    @property
    def beverage(self) -> Beverage:
        return self._beverage

    @property
    def description(self) -> str:
        return f"{self._beverage.description}, Mocha"

    @description.setter
    def description(self, *_, **__) -> None:
        raise ValueError("description is read only")

    @property
    def cost(self) -> float:
        return self._beverage.cost + 0.20
    
    @cost.setter
    def cost(self, *_, **__) -> None:
        raise ValueError("cost is read only")


class Soy(CondimentDecorator):

    def __init__(self, beverage: Beverage) -> None:
        super().__init__(beverage)

    @property
    def beverage(self) -> Beverage:
        return self._beverage

    @property
    def description(self) -> str:
        return f"{self._beverage.description}, Soy"

    @description.setter
    def description(self, *_, **__) -> None:
        raise ValueError("description is read only")

    @property
    def cost(self) -> float:
        return self._beverage.cost + 0.15
    
    @cost.setter
    def cost(self, *_, **__) -> None:
        raise ValueError("cost is read only")


class Whip(CondimentDecorator):

    def __init__(self, beverage: Beverage) -> None:
        super().__init__(beverage)

    @property
    def beverage(self) -> Beverage:
        return self._beverage

    @property
    def description(self) -> str:
        return f"{self._beverage.description}, Whip"

    @description.setter
    def description(self, *_, **__) -> None:
        raise ValueError("description is read only")

    @property
    def cost(self) -> float:
        return self._beverage.cost + 0.10

    @cost.setter
    def cost(self, *_, **__) -> None:
        raise ValueError("cost is read only")
