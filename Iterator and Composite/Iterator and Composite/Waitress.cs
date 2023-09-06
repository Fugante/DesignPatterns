namespace Iterator_and_Composite;

public class Waitress
{
    private MenuComponent Menus;

    public Waitress(MenuComponent menus)
    {
        Menus = menus;
    }

    public void PrintMenu()
    {
        Menus.Print();
    }
}
