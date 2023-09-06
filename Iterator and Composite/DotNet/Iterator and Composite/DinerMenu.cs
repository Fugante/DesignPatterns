//namespace Iterator_and_Composite;

//public class DinerMenu : Menu
//{
//    private static int MAX_ITEMS = 6;
//    public int NumberOfItems { get; set; } = 0;
//    private MenuItem[] MenuItems;

//    public DinerMenu()
//    {
//        MenuItems = new MenuItem[MAX_ITEMS];
//        AddItem(
//            "Vegetarian BLT",
//            "(Fakin') Bacon with lettuce & tomato on whole wheat",
//            true,
//            2.99
//        );
//        AddItem(
//            "BLT",
//            "Bacon with lettuce & tomato on whole wheat",
//            false,
//            2.99
//         );
//        AddItem(
//            "Soup of the day",
//            "Soup of the day, with a side of potato salad",
//            false,
//            3.29
//         );
//        AddItem(
//            "Hotdog",
//            "A hot dog, with sauerkraut, relish, onions, topped with cheese",
//            false,
//            3.05
//         );
//        // a couple of other Diner Menu items added here
//    }

//    public Iterator<MenuItem> CreateIterator()
//    {
//        return new DinerMenuIterator(MenuItems);
//    }

//    public void AddItem(string name, string description, bool vegetarian, double price)
//    {
//        MenuItem menuItem = new(name, description, vegetarian, price);
//        if (NumberOfItems >= MAX_ITEMS)
//        {
//            Console.Error.WriteLine("Sorry , menu is full! Can't add item to menu");
//        }
//        else
//        {
//            MenuItems[NumberOfItems] = menuItem;
//            NumberOfItems = NumberOfItems + 1;
//        }
//    }
//    // other menu methods here
//}