using PatternMatching.Models;
namespace PatternMatching.Lessons;
public class Lesson1 : ILesson
{
    public void Execute()
    {
        var cat = new Cat("Whiskers", 3, CatBreed.MainCoon);

        //the most basic way to check for a pattern is to use simple if statements.

        if(cat.Age > 5) //Check if its older than 5
        {
            Console.WriteLine("The cat is older than 5");
        }
        if(cat.Name == "Whiskers") //checking its name
        {
            Console.WriteLine("The cat is named whiskers");
        }

        //You can obviously use multiple boolean operations as well

        if(cat.Name == "Jamey" && cat.Age > 2 && cat.Breed == CatBreed.Siamese) // you can always combine many && and || operations
        {
            Console.WriteLine("Found a 2 year old siamese Jamy! :)");
        }
        else
        {
            Console.WriteLine("Not jamy :(");
        }

        // a problem with this approach is when you have very specific and large patterns.
        // this causes a huge mess of spaghetti code blocks and sad confused developers
        // the example below demonstartes this problem:

        if(cat.Name.Length < 9 || cat.Name == "johnathan")
        {
            if(cat.Breed == CatBreed.Persian && cat.Age <= 7)
            {
                Console.WriteLine("Found persian under 6");
            }
            else if(cat.Age >= 7 || cat.Name == "bob")
            {
                Console.WriteLine("Found older than 7 years or bob");
            }
            else
            {
                if((cat.Breed == CatBreed.Bengal && cat.Age == 4) || cat.Name == "jojo")
                {
                    Console.WriteLine("Found 4 year old bengal or jojo");
                }
                else if(cat.Name == "sunshine" && cat.Age == 1)
                {
                    Console.WriteLine("Found sunshine!");
                }
            }
        }
        else
        {
            if(cat == null || cat.Breed == CatBreed.Siamese)
            {
                Console.WriteLine("Found above 6 years none johnney siamese!");
            }
            else
            {
                Console.WriteLine("Found nothing");
            }
        }

        //Be honest, you have NO idea what is happenning up there and even trying to
        //predict the outcome will give you a headache
        // lets find some better ways to make a developer's life easier in the next lesson.
    }
}

