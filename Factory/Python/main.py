from src.Pizza import Pizza
from src.Store import NYPizzaStore


def main() -> None:
    nyStore = NYPizzaStore()

    pizza: Pizza = nyStore.order_pizza("cheese")
    print(f"Ethan ordered a {pizza.name}\n")


if __name__ == "__main__":
    main()