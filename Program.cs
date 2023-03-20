namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat semsem= new Cat();
            Bird tweety= new Bird();

            Console.WriteLine(semsem.Sound);
            Console.WriteLine(semsem.FlyType);
            semsem.Scratch();
            semsem.FlyType = new FlyHigh();
            Console.WriteLine(semsem.FlyType);
            
            Console.WriteLine();
            Console.WriteLine(tweety.Sound);
            Console.WriteLine(tweety.FlyType);
        }
    }
}