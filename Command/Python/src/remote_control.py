from . import command
from .command import Action


class RemoteControl:

    def __init__(self):
        self.undo_command: Action = command.null_command()
        self._on_commands: list[Action] = [command.null_command() for _ in range(7)]
        self._off_commands: list[Action] = [command.null_command() for _ in range(7)]

    def __repr__(self) -> str:
        return f"{self.__class__.__name__}"

    def __str__(self) -> str:
        string: str = "\n------ Remote Control -------\n"
        for i in range(7):
            string += ( f"[slot {i}] {self._on_commands[i].__name__} "
                        f"{self._off_commands[i].__name__} \n" )
        string += f"[undo] {self.undo_command.__name__} \n"
        return string

    @property
    def on_commands(self) -> list[Action]:
        return self._on_commands

    @on_commands.setter
    def on_commands(self) -> None:
        raise AttributeError("'on_commands' is read only")

    @property
    def off_commands(self) -> list[Action]:
        return self._off_commands

    @off_commands.setter
    def off_commands(self) -> None:
        raise AttributeError("'off_commands' is read only")

    def set_command(self, slot: int, on_command: Action, off_command: Action) -> None:
        self._on_commands[slot] = on_command
        self._off_commands[slot] = off_command

    def press_on_button(self, slot: int) -> None:
        self._on_commands[slot]()
        self.undo_command = self._on_commands[slot]

    def press_off_button(self, slot: int) -> None:
        self._off_commands[slot]()
        self.undo_command = self._off_commands[slot]

    def press_undo_button(self) -> None:
        self.undo_command(undo=True)