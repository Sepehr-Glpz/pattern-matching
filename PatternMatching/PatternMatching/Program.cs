using System.Reflection;
namespace PatternMatching;
public class Program
{
    //Dont be distracted by this code, simply study the Lesson classes and run the project to see the output!
    public static void Main()
    {
        //scan assembly for all ILesson implementations that can be instantiated.
        var classes = Assembly.GetAssembly(typeof(Program)).DefinedTypes
            .Where(c => typeof(ILesson).IsAssignableFrom(c) && c.IsInterface == false && c.IsAbstract == false);

        foreach(var lesson in classes) //create and run those classes.
        {
            ILesson currentLesson = null;
            try
            {
                currentLesson = Activator.CreateInstance(lesson) as ILesson;
            }
            catch //activator failed, possibly because of a missing constructor.
            {
                Console.WriteLine($"An Error occured while attempting to create the class: {lesson.FullName}!");
                Console.WriteLine("Please make sure all lesson classes have a default constructor!");
                continue;
            }
            Console.WriteLine($"\t{lesson.Name}:");
            currentLesson?.Execute();
            Console.ReadLine();
        }

        Console.WriteLine("Press Ctrl + C to terminate application");
        System.Threading.Thread.CurrentThread.Join(); //Blocks calling thread, keeps application open
    }
}


