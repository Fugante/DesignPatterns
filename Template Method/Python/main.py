from src.CaffeineBeverages import (
    Coffee,
    Tea
)


def main() -> None:
    tea = Tea()
    coffee = Coffee()

    print("\nMaking Tea...")
    tea.prepare_recipe()

    print("\nMaking Coffee...")
    coffee.prepare_recipe()


if __name__ == "__main__":
    main()