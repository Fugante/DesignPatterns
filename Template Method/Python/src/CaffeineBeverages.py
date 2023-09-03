from abc import (
    ABC,
    abstractmethod
)


class CaffeineBeverage(ABC):

    def prepare_recipe(self) -> None:
        self.boil_water()
        self.brew()
        self.pour_in_cup()
        if self.condiments_needed():
            self.add_condiments()

    @abstractmethod
    def brew(self) -> None:...

    @abstractmethod
    def add_condiments(self) -> None:...

    def boil_water(self) -> None:
        print("Boiling water")

    def pour_in_cup(self) -> None:
        print("Pouring into cup")

    def condiments_needed(self) -> bool:
        return True


class Coffee(CaffeineBeverage):

    def brew(self) -> None:
        print("Dripping Coffee through filter")

    def add_condiments(self) -> None:
        print("Adding Sugar and Milk")

    def condiments_needed(self) -> bool:
        answer = self.get_user_input()
        return answer.lower().startswith("y")

    def get_user_input(self) -> str:
        answer = input("Would you like milk and sugar with your coffee (y/n)? ")
        if not answer:
            answer = "no"
        return answer


class Tea(CaffeineBeverage):

    def brew(self) -> None:
        print("Steeping the tea")

    def add_condiments(self) -> None:
        print("Adding Lemon")

    def condiments_needed(self) -> bool:
        answer = self.get_user_input()
        return answer.lower().startswith("y")

    def get_user_input(self) -> str:
        answer = input("Would you like milk and sugar with your coffee (y/n)? ")
        if not answer:
            answer = "no"
        return answer