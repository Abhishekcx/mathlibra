namespace ABSTARCTCLASS
{
    abstract class animals
    {
        public abstract void animalhabits();

    }
    class carnivore : animals
    {
        public override void animalhabits()
        {
            Console.WriteLine("plant eating animals kkj");

        }
    }
    class herbivore : animals
    {
        public override void animalhabits()
        {
            Console.WriteLine("animal eating animals");

        }
    }
    class program
    {
        static void Main(string[] args)
        {
            herbivore a = new herbivore(); 
            a.animalhabits();
            carnivore b = new carnivore();  
            b.animalhabits();
            Console.WriteLine(a);

            Console.ReadKey();  

        }
    }
}