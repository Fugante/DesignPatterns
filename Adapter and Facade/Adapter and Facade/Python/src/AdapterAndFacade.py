import random

from .HomeTheater import (
    Tuner,
    Amplifier,
    PopcornPopper,
    Screen,
    StreamingPlayer,
    TheaterLights,
    Projector
)
from .Duck import Duck
from .Turkey import Turkey


class TurkeyAdapter:
 
    def __init__(self, turkey: Turkey) -> None:
        self.turkey = turkey

    def quack(self) -> None:
        self.turkey.gobble()

    def fly(self) -> None:
        for i in range(5):
            self.turkey.fly()


class DuckAdapter:

    def __init__(self, duck: Duck) -> None:
        self.duck = duck

    def gobble(self) -> None:
        self.duck.quack()

    def fly(self) -> None:
        if random.randint(0, 4) == 4:
            self.duck.fly()


class HomeTheaterFacade:
    def __init__(
            self,
            amplifier: Amplifier,
            tuner: Tuner,
            player: StreamingPlayer,
            projector: Projector,
            screen: Screen,
            lights: TheaterLights,
            popper: PopcornPopper
        ):
            self.amplifier = amplifier
            self.tuner = tuner
            self.player = player
            self.projector = projector
            self.screen = screen
            self.lights = lights
            self.popper = popper

    def watch_movie(self, movie: str) -> None:
        print("Get ready to watch a movie...")
        self.popper.on()
        self.popper.pop()
        self.lights.dim(10)
        self.screen.down()
        self.projector.on()
        self.projector.wide_screen_mode()
        self.amplifier.on()
        self.amplifier.player = self.player
        self.amplifier.set_surround_sound()
        self.amplifier.volume = 5
        self.player.on()
        self.player.play(movie)

    def end_movie(self) -> None:
        print("Shutting movie theater down...")
        self.popper.off()
        self.lights.on()
        self.screen.up()
        self.projector.off()
        self.amplifier.off()
        self.player.stop()
        self.player.off()