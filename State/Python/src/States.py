from random import randint
from typing import Protocol


class State(Protocol):
    def insert_quarter(self) -> None:...
    def eject_quarter(self) -> None:...
    def turn_crank(self) -> None:...
    def dispense(self) -> None:...
    def refill(self) -> None:...


from .GumballMachine import GumballMachine


class NoQuarterState:
    def __init__(self, gumball_machine: GumballMachine) -> None:
        self.gumball_machine = gumball_machine

    def __str__(self) -> None:
        return "Machine is waiting for quarter"

    def insert_quarter(self) -> None:
        print("You inserted a quarter")
        self.gumball_machine.state = self.gumball_machine.has_quarter_state

    def eject_quarter(self) -> None:
        print("You haven't inserted a quarter")

    def turn_crank(self) -> None:
        print("You turned, but there's no quarter")

    def dispense(self) -> None:
        print("You need to pay first")

    def refill(self) -> None:...


class HasQuarterState:
    def __init__(self, gumball_machine: GumballMachine) -> None:
        self.gumball_machine = gumball_machine

    def __str__(self) -> None:
        return "Machine is waiting for action: turn crank or eject quarter"

    def insert_quarter(self) -> None:
        print("You can't insert another quarter")

    def eject_quarter(self) -> None:
        print("Quarter returned")
        self.gumball_machine.State = self.gumball_machine.no_quarter_state

    def turn_crank(self) -> None:
        print("You turned...")
        winner = randint(0, 9)

        if winner == 0 and self.gumball_machine.count > 1:
            self.gumball_machine.state = self.gumball_machine.winner_state
        else:
            self.gumball_machine.state = self.gumball_machine.sold_state

    def dispense(self) -> None:
        print("No gumball dispense(self) -> None:d")

    def refill(self) -> None:...


class SoldState:
    def __init__(self, gumball_machine: GumballMachine) -> None:
        self.gumball_machine = gumball_machine

    def __str__(self) -> None:
        return "Machine is dispensing gumball"

    def insert_quarter(self) -> None:
        print("Please wait, we're already giving you a gumball")

    def eject_quarter(self) -> None:
        print("Sorry, you already turned the crank")

    def turn_crank(self) -> None:
        print("Turning twice doesn't get you another gumball!")
        self.gumball_machine.state = self.gumball_machine.sold_state

    def dispense(self) -> None:
        self.gumball_machine.release_ball()
        if self.gumball_machine.count > 0:
            self.gumball_machine.state = self.gumball_machine.no_quarter_state
        else:
            print("Oops, out of gumballs!")
            self.gumball_machine.state = self.gumball_machine.sold_out_state

    def refill(self) -> None:...


class SoldOutState:
    def __init__(self, gumball_machine: GumballMachine) -> None:
        self.gumball_machine = gumball_machine

    def __str__(self) -> None:
        return "Machine is sold out"

    def insert_quarter(self) -> None:
        print("Sorry we're are sold out")

    def eject_quarter(self) -> None:
        print("You haven't inserted a quarter yet")

    def turn_crank(self) -> None:
        print("There are no gumballs left")

    def dispense(self) -> None:
        self.gumball_machine.release_ball()
        if self.gumball_machine.count > 0:
            self.gumball_machine.state = self.gumball_machine.no_quarter_state
        else:
            print("Oops, out of gumballs!")
            self.gumball_machine.state = self.gumball_machine.sold_out_state

    def refill(self) -> None:
        self.gumball_machine.state = self.gumball_machine.no_quarter_state


class WinnerState:
    def __init__(self, gumball_machine: GumballMachine) -> None:
        self.gumball_machine = gumball_machine

    def insert_quarter(self) -> None:
        print("Please wait, we're already giving you a gumball")

    def eject_quarter(self) -> None:
        print("Sorry, you already turned the crank")

    def turn_crank(self) -> None:
        print("Turning twice doesn't get you another gumball!")
        self.gumball_machine.state = self.gumball_machine.sold_state

    def dispense(self) -> None:
        self.gumball_machine.release_ball()
        if self.gumball_machine.count == 0:
            self.gumball_machine.state = self.gumball_machine.sold_out_state
            return

        self.gumball_machine.release_ball()
        print("YOU'RE A WINNER! You got two gumballs for your quarter")
        if self.gumball_machine.count > 0:
            self.gumball_machine.state = self.gumball_machine.no_quarter_state
        else:
            print("Oops, out of gumballs!")
            self.gumball_machine.state = self.gumball_machine.sold_out_state

    def refill(self) -> None:...