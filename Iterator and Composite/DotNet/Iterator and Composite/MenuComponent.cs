namespace Iterator_and_Composite;

public abstract class MenuComponent
{
    public virtual string Name { get => throw new NotImplementedException(); }
    public virtual string Description { get => throw new NotImplementedException(); }
    public virtual double Price { get => throw new NotImplementedException(); }
    public virtual bool Vegetarian { get => throw new NotImplementedException(); }

    public virtual void Add(MenuComponent menuComponent)
    {
        throw new NotImplementedException();
    }

    public void Remove(MenuComponent menuComponent)
    {
        throw new NotImplementedException();
    }

    public virtual MenuComponent GetChild(int index)
    {
        throw new NotImplementedException();
    }

    public abstract void Print();
}