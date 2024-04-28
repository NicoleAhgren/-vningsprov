namespace Övningsprov;
public class Zombies: Attacks
{
    Random generator = new Random();
    public int intelligence = 0;
    public int strength = 0;
    public int stamina = 0;
public void TickZ() //Ger dom random värden
{
    intelligence += generator.Next(16);
    strength += generator.Next(11);
    stamina += generator.Next(6);

    Console.WriteLine("New zombie crated with intelligence" + intelligence + "snd the strength" + strength +"and the stamina" + stamina);
}

}