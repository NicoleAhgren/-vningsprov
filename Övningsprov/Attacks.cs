using System;
namespace Övningsprov;

public class Attacks
{
    Random generator = new Random();
    public int intelligence = 0;
    public int strength = 0;
    public int stamina = 0;
public int schackSpel() //Intelligens
{
    int resultat = Random.Shared.Next(0, 10) + intelligence;

    if (resultat > 20)
    {
        return 20;
    }
    else 
    {
        return resultat;
    }
}

public int brottningsMatch() //Tålighet och styrka
{
        int resultat = Random.Shared.Next(0, 10) + strength + stamina;

    if (resultat > 20)
    {
        return 20;
    }
    else 
    {
        return resultat;
    }
}

public int armbrytningsMatch() //Styrka
{
        int resultat = Random.Shared.Next(0, 10) + strength;

    if (resultat > 20)
    {
        return 20;
    }
    else 
    {
        return resultat;
    }
}

}
