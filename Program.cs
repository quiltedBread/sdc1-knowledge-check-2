Console.WriteLine("How many Fruits do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine() ?? "0");

var recordList = new List<Fruit>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()

    Console.WriteLine("What's the name of your Fruit?");
    string fruitName = Console.ReadLine() ?? "";
    Console.WriteLine("Is your Fruit a banana? (Y/N)");
    bool isBanana = Console.ReadLine() == "Y" ? true : false;
    var fruit = new Fruit(isBanana, fruitName);

    recordList.Add(fruit);
}

recordList.ForEach(x => Console.WriteLine(x));

// Print out the list of records using Console.WriteLine()
