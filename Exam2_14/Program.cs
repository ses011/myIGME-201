using System;

namespace StructToClass
{
    public class Friend
    {
        public string name;
        public string greeting;
        public DateTime birthdate;
        public string address;

        public Friend(string name, string greeting, DateTime birthdate, string address)
        {
            this.name = name;
            this.greeting = greeting;
            this.birthdate = birthdate;
            this.address = address;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Friend friend = new Friend("Charlie Sheen", "Dear Charlie", DateTime.Parse("1967-12-25"), "123 Any Street, NY NY 12202");
            Friend enemy;

            // now he has become my enemy
            enemy = new Friend(friend.name, friend.greeting, friend.birthdate, friend.address);

            // set the enemy greeting and address without changing the friend variable
            enemy.greeting = "Sorry Charlie";
            enemy.address = "Return to sender.  Address unknown.";

            Console.WriteLine($"friend.greeting => enemy.greeting: {friend.greeting} => {enemy.greeting}");
            Console.WriteLine($"friend.address => enemy.address: {friend.address} => {enemy.address}");
        }
    }
}
