class GumballMachine:
    def __init__(self, gumballs_num: int) -> None:
        from . import States

        self.sold_out_state = States.SoldOutState(self)
        self.no_quarter_state = States.NoQuarterState(self)
        self.has_quarter_state = States.HasQuarterState(self)
        self.sold_state = States.SoldState(self)
        self.winner_state = States.WinnerState(self)
        self.count = gumballs_num
        if gumballs_num > 0:
            self.state = self.no_quarter_state
        else:
            self.state = self.sold_out_state

    def __str__(self) -> str:
        string = "Mighty Gumball, Inc.\n"
        string += "Standing Gumball Model #2004\n"
        string += f"Inventory: {self.count} gumballs\n"
        string += f"{str(self.state)}\n"
        return string

    def insert_quarter(self) -> None:
        self.state.insert_quarter()

    def eject_quarter(self) -> None:
        self.state.eject_quarter()

    def turn_crank(self) -> None:
        self.state.turn_crank()
        self.state.dispense()

    def refill(self, count: int) -> None:
        self.count += count
        print(f"The gumball machine was just refilled its new count is: {self.count}")
        self.state.refill()

    def release_ball(self) -> None:
        print("A gumball comes rolling out the slot...")
        if self.count > 0:
            self.count -= 1