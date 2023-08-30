from src.AdapterAndFacade import TurkeyAdapter
from src.Turkey import WildTurkey
from src.Duck import MallardDuck


def main() -> None:
    duck = MallardDuck()

    turkey = WildTurkey()
    turkey_adapter = TurkeyAdapter(turkey)

    print("The turkey says...")
    turkey.gobble()
    turkey.fly()

    print("\nThe duck says...")
    duck.quack()
    duck.fly()

    print("\nThe TurkeyAdapter says...")
    turkey_adapter.quack()
    turkey_adapter.fly()


if __name__ == "__main__":
    main()