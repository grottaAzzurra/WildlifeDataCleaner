string[] animals = {"Peregrine Falcon","Polar Bear","Black Panther","Sea Otter","Monarch Butterfly","White Wolf","Red Dragon","Golden Retriever","Spanish Bull"};

/*
for (int i=0; i < animals.Length; i++)
{
    //Console.WriteLine(animals[i]);
}
*/

Console.WriteLine(GreetAnimal("Peregrine Falcon"));

static string GreetAnimal(string animalName)
{
    return "Hello, " + animalName + ". Welcome to the Wildlife Data Cleaner.";
}

public class AnimalRecord
{
    public string Name { get; set; }
    public string Species { get; set; }
    public string Location { get; set; }
}