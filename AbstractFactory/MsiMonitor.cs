namespace DesignPattern.AbstractFactory
{
    internal class MsiMonitor : IMonitor
    {
        public MsiMonitor()
        {
            System.Console.WriteLine("Creating a MSI Monitor");
        }
    }
}