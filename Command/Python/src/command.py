from typing import (
    Any, Callable
)


from src.executors import (
    Fan,
    Light,
    GarageDoor,
    Stereo
)


Action = Callable[[bool], None]
Command = Callable[[Any], Action]


def null_command() -> Action:
    def execute(undo: bool) -> None:
        return

    execute.__name__ = "null_command"
    return execute

def light_on_command(light: Light) -> Action:
    def execute(undo: bool=False) -> None:
        if not undo:
            light.on()

        else:
            light.off()
    execute.__name__ = "light_on_command"

    return execute

def light_off_command(light: Light) -> None:
    def execute(undo: bool=False) -> None:
        if not undo:
            light.off()

        else:
            light.on()

    execute.__name__ = "light_off_command"
    return execute


def _fan_undo(previous_speed: Fan.Speeds, fan: Fan) -> None:
    match previous_speed:
        case Fan.Speeds.HIGH:
            fan.high()

        case Fan.Speeds.MEDIUM:
            fan.medium()

        case Fan.Speeds.LOW:
            fan.low()

        case Fan.Speeds.OFF:
            fan.off()

def fan_high_command(fan: Fan) -> None:
    previous_speed: Fan.Speeds

    def execute(undo: bool=False) -> None:
        nonlocal previous_speed

        if not undo:
            previous_speed = fan.speed
            fan.high()

        else:
            _fan_undo(previous_speed, fan)

    execute.__name__ = "fan_high_command"
    return execute

def fan_medium_command(fan: Fan) -> None:
    previous_speed: Fan.Speeds

    def execute(undo: bool=False) -> None:
        nonlocal previous_speed

        if not undo:
            previous_speed = fan.speed
            fan.medium()

        else:
            _fan_undo(previous_speed, fan)

    execute.__name__ = "fan_medium_command"
    return execute

def fan_low_command(fan: Fan) -> None:
    previous_speed: Fan.Speeds

    def execute(undo: bool=False) -> None:
        nonlocal previous_speed

        if not undo:
            previous_speed = fan.speed
            fan.low()

        else:
            _fan_undo(previous_speed, fan)

    execute.__name__ = "fan_low_command"
    return execute

def fan_off_command(fan: Fan) -> None:
    previous_speed: Fan.Speeds

    def execute(undo: bool=False) -> None:
        nonlocal previous_speed

        if not undo:
            previous_speed = fan.speed
            fan.off()

        else:
            _fan_undo(previous_speed, fan)

    execute.__name__ = "fan_off_command"
    return execute