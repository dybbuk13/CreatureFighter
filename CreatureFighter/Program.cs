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
                        UserActions.ListAliveCreatures(creatures);
                        nameInput = Console.ReadLine();
                        UserActions.AttackCreature(nameInput, creatures);
                        break;

                    case "LIST":
                        UserActions.ListAllCreatures(creatures);
                        break;

                    case "QUIT":
                        menuCondition = false;
                        break;
                }
                Console.Write("Please enter another command: ");
            }

            // TODO - Clean up Main method, move Menu to another method.

            // TODO - Add comments and summaries.

            // TODO - Allow multiple user input arguments. (Create <name>, Attack <name>, etc.)

            // TODO - Implement error handling

            // TODO - Wire up a database for creatures, players, and stats.

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