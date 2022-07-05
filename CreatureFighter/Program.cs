namespace CreatureFighter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Creature> creatures = new List<Creature>();

            Console.WriteLine("Hello, please enter a command.");
            Console.WriteLine("(current commands: 'Create', 'List', 'Quit')");

            bool menuCondition = true;
            string cmd = "";
            string nameInput = "";

            while (menuCondition)
            {
                cmd = Console.ReadLine().ToUpper();

                switch (cmd)
                {
                    case "CREATE":
                        Console.Write("Please enter the creature's name: ");
                        nameInput = Console.ReadLine();
                        creatures.Add(new Creature(nameInput));
                        Console.WriteLine($"{ nameInput } was created!");
                        break;

                    case "ATTACK":
                        Console.WriteLine("Which creature would you like to attack?");
                        Creature.ListAliveCreatures(creatures);
                        nameInput = Console.ReadLine();
                        Creature.AttackCreature(nameInput, creatures);
                        break;

                    case "LIST":
                        Creature.ListAllCreatures(creatures);
                        break;

                    case "QUIT":
                        menuCondition = false;
                        break;
                }
                Console.Write("Please enter another command: ");
            }

            //Console.WriteLine("Hello, let's start by creating a few creatures.");

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write($"Please enter a name for Creature {i}:");
            //    nameInput = Console.ReadLine();
            //    creatures.Add(new Creature(nameInput));
            //}

            //Creature.AttackCreature("Lock", creatures);
        }
    }
}