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
        
        Console.WriteLine($"Once upon a time {name} was walking through the art museum listening to {band}. {name} stopped at a {color} painting and was staring at it for some time before noticing that a {animal} was blended into the background. {name} jumped when she saw the {animal} and, as she clutched her chest, she thought to herself {name}, if it has been a snake it would have bitten you!");
        }

        public static int CalculatesSum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }
        
        public static int SubInt(params int[] numbers)
        {
            int subtract = numbers[0];
            foreach (int number in numbers.Skip(1))
            {
                subtract -= number;
            }
            return subtract;
        }
        
        public static int Times(params int[] numbers)
        {
            int multiply = numbers[0];
            foreach (int number in numbers.Skip(1))
            {
                multiply *= number;
            }
            return multiply;
        }
        
        public static int Division(params int[] numbers)
        {
            int divide = numbers[0];
            foreach (int number in numbers.Skip(1))
            {
                divide /= number;
            }
            return divide;
        }
        static void Main(string[] args)
        {
         StoryInput();
         
         int sum = CalculatesSum(5, 4, 6);
         Console.WriteLine(sum);
         
         int subtract = SubInt(5, 4, 1);
         Console.WriteLine(subtract);

         int multiply = Times(5, 4, 5);
         Console.WriteLine(multiply);

         int divide = Division(20, 4, 1);
         Console.WriteLine(divide);
        }
    }
}



