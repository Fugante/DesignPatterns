from src.GumballMachine import GumballMachine


def main() -> None:
    gumball_machine = GumballMachine(5)
    print(gumball_machine)

    gumball_machine.insert_quarter()
    gumball_machine.turn_crank()
    print(gumball_machine)

    gumball_machine.insert_quarter()
    gumball_machine.turn_crank()
    gumball_machine.insert_quarter()
    gumball_machine.turn_crank()
    print(gumball_machine)


if __name__ == "__main__":
    main()