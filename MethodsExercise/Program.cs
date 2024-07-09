namespace MethodsExercise
{
    public class Program
    {
        public static void StoryInput()
        {
        Console.WriteLine("What is your name?)");
        string name = Console.ReadLine();
        
        Console.WriteLine("What is your favorite color?");
        string color = Console.ReadLine();

        Console.WriteLine("What is your favorite animal?");
        string animal = Console.ReadLine();

        Console.WriteLine("What is your favorite band?");
        string band = Console.ReadLine();
        
        Console.WriteLine($"Once upon a time {name} was walking through the art museum listening to {band}. {name} stopped at a {color} painting and was staring at it for some time before noticing that a {animal} was blended into the background. She jumped when she saw the {animal} and, as she clutched her chest, she thought to herself {name}, if it has been a snake it would have bitten you");
        }   
        
        static void Main(string[] args)
        {
         StoryInput();
        }
    }
}



