namespace Weather.Interfaces;


public interface Subject
{
    void RegisterObserver(Observer observer);
    void RemoveObserver(Observer observer);
    void NotifyObservers();
}

public interface Observer
{
    void Update();
}

public interface DisplayElement
{
    void Display();
}