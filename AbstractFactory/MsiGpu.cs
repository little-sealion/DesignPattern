namespace DesignPattern.AbstractFactory
{
    internal class MsiGpu : IGpu
    {
        public MsiGpu()
        {
            System.Console.WriteLine("creating a MSI GPU");
        }
    }
}