class Amplifier:

    def __init__(self) -> None:
        self.tuner: Tuner = None
        self.player: StreamingPlayer = None
        self.volume: int = None
 
    def __repr__(self) -> str:
        return f"{self.__class__.__name__}()"

    def on(self) -> None:
        print("Amplifier on")

    def off(self) -> None:
        print("Amplifier off")

    def set_stereo_sound(self) -> None:
        print("Stereo sound")

    def set_surround_sound() -> None:
        print("Surround sound")


class Tuner:
 
    def __init__(self, amplifier: Amplifier) -> None:
        self.amplifier = amplifier

    def __repr__(self) -> str:
        return f"{self.__class__.__name__}({self.amplifier})"

    def on(self) -> None:
        print("Tuner on")

    def off(self) -> None:
        print("Tuner off")

    def set_am(self) -> None:
        print("AM mode")

    def set_fm(self) -> None:
        print("FM mode")

    def set_frequency(self) -> None:
        print("Setting frequency...")


class StreamingPlayer:

    def __init__(self, amplifier: Amplifier) -> None:
        self.amplifier = amplifier

    def __repr__(self) -> str:
        return f"{self.__class__.__name__}({self.amplifier})"

    def on(self) -> None:
        print("StreamingPlayer on")

    def off(self) -> None:
        print("StreamingPlayer off")

    def pause(self) -> None:
        print("StreamingPlayer paused")

    def play(self, movie: str) -> None:
        print(f"Playing {movie}")

    def set_surround_audio(self) -> None:
        print("StreamingPlayer audio set")

    def set_two_channel_audio(self) -> None:
        print("Two channed audio set")

    def stop(self)-> None:
        print("StreamingPlayer stopped")


class Projector:
    def __init__(self, player: StreamingPlayer) -> None:
        self.player = player

    def __repr__(self) -> str:
        return f"{self.__class__.__name__}({self.player})"

    def on() -> None:
        print("Proyector on")

    def off() -> None:
        print("Proyector off")

    def tv_mode() -> None:
        print("TV mode")

    def wide_screen_mode() -> None:
        print("Wide screen mode")