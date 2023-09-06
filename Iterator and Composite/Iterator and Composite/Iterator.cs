namespace Iterator_and_Composite;

public interface Iterator<T>
{
    bool HasNext();
    MenuItem Next();
}

public class DinerMenuIterator : Iterator<MenuItem>
{
    public MenuItem[] Items;
    private int Position { get; set; } = 0;

    public DinerMenuIterator(MenuItem[] items)
    {
        Items = items;
    }

    public MenuItem Next()
    {
        MenuItem menuItem = Items[Position];
        Position++;
        return menuItem;
    }

    public bool HasNext()
    {
        return Position < Items.Length && Items[Position] != null;
    }
}