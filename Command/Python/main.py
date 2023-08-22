from src import command
from src.executors import (
    Fan,
    GarageDoor,
    Light,
    Stereo
)
from src.remote_control import RemoteControl


def main() -> None:
    remote_control = RemoteControl()

    living_room_light = Light("Living Room")
    ceiling_fan = Fan("Livin Room")

    remote_control.set_command(
        0,
        command.light_on_command(living_room_light),
        command.light_off_command(living_room_light)
    )
    remote_control.set_command(
        1,
        command.fan_high_command(ceiling_fan),
        command.fan_off_command(ceiling_fan)
    )
    remote_control.set_command(
        2,
        command.fan_medium_command(ceiling_fan),
        command.fan_off_command(ceiling_fan)
    )

    print(remote_control)
    remote_control.press_on_button(0)
    remote_control.press_off_button(0)
    remote_control.press_on_button(1)
    remote_control.press_off_button(1)
    print(remote_control)
    remote_control.press_undo_button()
    remote_control.press_on_button(2)
    print(remote_control)
    remote_control.press_undo_button()


if __name__ == "__main__":
    main()