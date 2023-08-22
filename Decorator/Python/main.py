from src import Coffee


def main() -> None:
    beverage = Coffee.Espresso()
    print(f"{beverage.description} ${beverage.cost}")

    beverage = Coffee.DarkRoast()
    beverage = Coffee.Mocha(beverage)
    beverage = Coffee.Mocha(beverage)
    beverage = Coffee.Whip(beverage)
    print(f"{beverage.description} ${beverage.cost}")

    beverage = Coffee.HouseBlend()
    beverage = Coffee.Soy(beverage)
    beverage = Coffee.Mocha(beverage)
    beverage = Coffee.Whip(beverage)
    print(f"{beverage.description} ${beverage.cost}")


if __name__ == "__main__":
    main()