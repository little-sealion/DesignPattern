namespace DesignPattern.FactoryMethod
{
    internal class BeefBurger : IBurger
    {

        public void Prepare()
        {
            System.Console.WriteLine("preparing beef burger");
        }
    }
}