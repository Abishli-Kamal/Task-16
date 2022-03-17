using System;

namespace task_modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User user = new User("kaamal","kamal1238");
            //Console.WriteLine(user.Username);

            Admin admin = new Admin(true, "datalari qebul etmek", "Hasbulla", "O dediyine");
            Console.Write(" Username Enter:");
            admin.Username = Console.ReadLine();
            Console.Write("Password Enter:");
            admin.Password = Console.ReadLine();
            admin.All();
        }
    }
}
