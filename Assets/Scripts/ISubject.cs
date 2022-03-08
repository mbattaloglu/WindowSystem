
public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void UnregisterObserver(IObserver observer);
    void NotifyObservers(NotificationType type);
    void NotifyObserver(NotificationType type, IObserver observer);
}
