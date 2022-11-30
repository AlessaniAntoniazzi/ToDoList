List<string> toDoList = new List<string>();
while (true) 
{

Console.Clear();
Console.WriteLine("What do you want to do? \n1 - Show a list of all to do's \n2 - Add a to do \n3 - delete a to do");
string userInput = Console.ReadLine();


if (userInput == "1")
{
    Console.Clear();
    foreach (string value in toDoList)
    {
        System.Console.WriteLine(value);

    }
    Console.ReadLine();
    
}
else if (userInput == "2")
{
    Console.Clear();
    toDoList.Add(Console.ReadLine()); 
    Console.Clear();

}
else if (userInput == "3")
{
    Console.Clear();
    toDoList.RemoveAt(int.Parse(Console.ReadLine())-1);

}
    
}
      
