from src.AdapterAndFacade import (
    TurkeyAdapter,
    HomeTheaterFacade
)
from src.Turkey import WildTurkey
from src.Duck import MallardDuck
from src.HomeTheater import (
    Tuner,
    Amplifier,
    PopcornPopper,
    Screen,
    StreamingPlayer,
    TheaterLights,
    Projector
)


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

    amplifier = Amplifier()
    tuner = Tuner(amplifier)
    player = StreamingPlayer(amplifier)
    amplifier.tuner = tuner
    amplifier.player = player
    projector = Projector(player)
    screen = Screen()
    lights = TheaterLights()
    popper = PopcornPopper()
 
    home_theater = HomeTheaterFacade(
        amplifier,
        tuner,
        player,
        projector,
        screen,
        lights,
        popper
    )
    home_theater.watch_movie("Raiders of the Lost Ark")
    home_theater.end_movie()


if __name__ == "__main__":
    main()