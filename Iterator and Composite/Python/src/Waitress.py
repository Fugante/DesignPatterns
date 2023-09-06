from .Menu import MenuComponent


class Waitress:
    def __init__(self, menus: MenuComponent) -> None:
        self._menus = menus

    def print_menu(self) -> None:
        self._menus.print()