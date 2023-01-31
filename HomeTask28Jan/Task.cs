using HomeTasksLogic;
namespace HomeTaskMain
{
    internal class Task
    {
        static void Main(string[] args)
        {
            Logic logic = new();
            logic.SetValueToArray();
            Console.WriteLine("\n Enter The Details To Login");
            Console.WriteLine("Enter a valid Id");
            string id = Console.ReadLine();
            Console.WriteLine("Enter a valid Password");
            string pass = Console.ReadLine();

            if (!logic.IsValidIdAndPass(id, pass))
                Console.WriteLine("Invalid Id or Password");

        }











    }
}
