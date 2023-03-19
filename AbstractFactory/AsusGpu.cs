namespace DesignPattern.AbstractFactory
{
    internal class AsusGpu : IGpu
    {
        public AsusGpu()
        {
            System.Console.WriteLine("creating a ASUS GPU");
        }
    }
}