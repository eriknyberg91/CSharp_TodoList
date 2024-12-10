while (true)
{
    Console.WriteLine("--- TODOLIST ---");
    Console.WriteLine("[1] Add Todo");
    Console.WriteLine("[2] Show current Todos");
    Console.WriteLine("[3] Exit program");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "1":
            //Add Todo
            Console.WriteLine("Add Todos");
            Console.ReadKey();
            break;
        case "2":
            //Show Todos
            Console.WriteLine("Show Todos");
            Console.ReadKey(); 
            break;
        case "3":
            return;
    }
}
