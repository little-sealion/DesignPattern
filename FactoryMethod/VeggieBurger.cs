namespace DesignPattern.FactoryMethod
{
    internal class VeggieBurger : IBurger
    {

        public void Prepare()
        {
            System.Console.WriteLine("preparing veggie burger");
        }
    }
}