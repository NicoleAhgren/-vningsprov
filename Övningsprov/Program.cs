using System;

List<string> texts = new List<string>();

for(int i = 0; i < 5; i++)
{
    string words = GetText(2, 7);
    texts.Add(words);
}
Console.WriteLine("");
texts.Reverse();

for(int i = 0; i < texts.Count; i++)
{
    Console.WriteLine(texts[i]);
}
Console.ReadLine();

static string GetText(int min, int max)
{
    string userinput = "";

    while(userinput.Length < min || userinput.Length > max)
    {
        Console.WriteLine($"Skrv ett ord som är mellan {min} - {max} bokstäver!");
        userinput = Console.ReadLine();

        if (userinput.Length < min)
        {
            Console.WriteLine("Det är för kort!");
        }
        else if (userinput.Length > max)
        {
            Console.WriteLine("Det är för långt");
        }
    }
    return userinput;
}