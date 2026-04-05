using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

/*
string[] animals = {"Peregrine Falcon","Polar Bear","Black Panther","Sea Otter","Monarch Butterfly","White Wolf","Red Dragon","Golden Retriever","Spanish Bull"};

for (int i=0; i < animals.Length; i++)
{
    //Console.WriteLine(animals[i]);
}
*/

Console.WriteLine(GreetAnimal("Peregrine Falcon"));

static string GreetAnimal(string animalName)
{
    return "Hello, " + animalName + ". Welcome to the Wildlife Data Cleaner.";
};

List<AnimalRecord> animals = new List<AnimalRecord>
{
    new AnimalRecord { Name = "Luna", Species = "Sea Otter", Location = "Pacific Northwest"},
    new AnimalRecord { Name = "Sage", Species = "Peregrine Falcon", Location = "Tundra" },
    new AnimalRecord { Name = "Finn", Species = "White Wolf", Location = " Tundra"}
};

foreach (AnimalRecord animal in animals)
{
    Console.WriteLine(animal.Name + " - " + animal.Species + " - " + animal.Location);
};