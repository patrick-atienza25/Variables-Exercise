namespace VariablesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName; //declaration syntax

            dogName = "Ollie"; //Initialized syntax -- assigned value

            int dogAge = 5; //declaring and initializing

            char firstInitial = 'O'; //declaring and initialzing

            bool isHungry = true; //declaring

            double dogWeight = 32.4; //declaring

            decimal dogHeight = 12.3m; //declaring


            Console.WriteLine($" My dog's name is {dogName}. He is about {dogAge} years old.");
            Console.WriteLine($"His name starts with {firstInitial}");
            Console.WriteLine($"He is very heavy, about {dogWeight} and he is pretty small {dogHeight}");
            Console.WriteLine($"It is {isHungry} he is always hungry.");
        }
    }
}