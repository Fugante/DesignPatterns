from src import Duck, FlyBehavior


def main() -> None:
    mallard = Duck.MallardDuck()
    mallard.quack()
    mallard.fly()

    model = Duck.ModelDuck()
    model.quack()
    model.fly()
    model.fly = FlyBehavior.fly_rocket_powered
    model.fly()


if __name__ == "__main__":
    main()