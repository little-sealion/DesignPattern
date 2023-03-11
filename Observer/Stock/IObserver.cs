namespace DesignPattern.Observer.Stock
{
    public interface IObserver
    {
        // all prmitive data types, such as int can be implicitly boxed into an object,
        void Update();
    }
}