using System;
using Övningsprov;

List<Dinosaur> dinosaurs = new List<Dinosaur>();
List<Zombies> zombie = new List<Zombies>();

int number = 0;
bool success = false;

while (success == false) //Tar in antalet zombis och dinosaurier dom väljer
{
    Console.WriteLine("Type in how many zombies and dinosaurs you want in the teams");
    string input = Console.ReadLine();

    success = int.TryParse(input, out number);

    if (success && number < 1)
    {
        success = false;
    }

for(int i = 0; i < number; i++) //Skapar anatlet zombies och dinosaurier som skrevs in
{
    Zombies Zom = new Zombies();
    Dinosaur Dino = new Dinosaur();

    zombie.Add(Zom);
    dinosaurs.Add(Dino);
}

Console.WriteLine("You created " +  zombie.Count() + " zombies.");
Console.WriteLine("Created " + dinosaurs.Count() + " dinosaurs." );

}

Console.ReadLine();








