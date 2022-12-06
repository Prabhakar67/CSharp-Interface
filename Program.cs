// Interface
interface IAnimal
{
    void animalSound(); // interface method (does not have a body)
}

// Cat "implements" the IAnimal interface
class Cat : IAnimal
{
    public void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The cat says: meyav meyav");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cat Kitti = new Cat();  // Create a Cat object
        Kitti.animalSound();
    }
}