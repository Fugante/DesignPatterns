//namespace Iterator_and_Composite;

//public class PancakeHouseMenu : Menu
//{
//    private List<MenuItem> MenuItems = new();

//    public PancakeHouseMenu()
//    {
//        AddItem(
//            "K&B's Pancake Breakfast",
//            "Pancakes with scrambled eggs and toast",
//            true,
//            2.99
//        );
//        AddItem(
//            "Regular Pancake Breakfast",
//            "Pancakes with fried eggs, sausage",
//            false,
//            2.99
//        );
//        AddItem(
//            "Blueberry Pancakes",
//            "Pancakes made with fresh blueberries",
//            true,
//            3.49
//        );
//        AddItem(
//            "Waffles",
//            "Waffles with your choice of blueberries or strawberries",
//            true,
//            3.59
//        );
//    }

//    public Iterator<MenuItem> CreateIterator()
//    {
//        MenuItem[] menuItems = MenuItems.ToArray();
//        return new DinerMenuIterator(menuItems);
//    }

//    public void AddItem(string name, string description, bool vegetarian, double price)
//    {
//        MenuItem menuItem = new MenuItem(name, description, vegetarian, price);
//        MenuItems.Add(menuItem);
//    }
//    // other menu methods here
//}