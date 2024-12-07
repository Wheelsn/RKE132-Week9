string folderPath = "@ C:data";
string fileName = "shoppingList.txt";
string filePath = Path.Combine(folderPath, fileName);
List<string> myShoppingList = new List<string>();


if (File.Exists(filePath))
{
    myShoppingList = GetItemsFromUser();
    File.WriteAllLines(filePath, myShoppingList);
}
else
{
    File.Create(filePath).Close();
    Console.WriteLine($"File{fileName} has been created.");
    myShoppingList=GetItemsFromUser();
    File.WriteAllLines(filePath , myShoppingList);  
}
    


static List<string> GetItemsFromUser()
{
List<string> userList = new List<string>();

while (true)
{
    Console.WriteLine("Add an item (add)/ Exit (exit)");
    string UserChoice = Console.ReadLine();
    if (UserChoice == "add")
    {
        Console.WriteLine("Enter the item you want to add");
        string UserItem = Console.ReadLine();
        userList.Add(UserItem);
    }
    else
    {
Console.WriteLine("Bye!");
        break;
    }
}
    return userList;
}

static void ShowItems(List<string> someList)
{

    Console.Clear();    

int ListLength = someList.Count;
Console.WriteLine($"Your shopping list contains:{ListLength}");


int i = 1;
foreach (string item in someList)
{
    Console.WriteLine($"{i}. {item} ");
    i++;
}
}


