﻿// See https://aka.ms/new-console-template for more information

string[] PreferiteFoods = { "pizza", "bbq", "lasagne", "tiramisu", "pasta", "fried fish", "arancino", "wow" };

/*
 * Console.WriteLine($"Il totale dei miei cibi preferiti è: {PreferiteFoods.Length}");

for (int i = 0; i < PreferiteFoods.Length; i++)
{
    Console.WriteLine($"Alla posizione n.{i+1} {PreferiteFoods[i]}");
}

Console.WriteLine($"Il mio cibo preferito è: {PreferiteFoods[0]}");

Console.WriteLine($"Il cibo meno preferito è: {PreferiteFoods[PreferiteFoods.Length-1]}");


int MediaFoods = PreferiteFoods.Length/2;

if (PreferiteFoods.Length%2 == 0)
{
    Console.WriteLine(PreferiteFoods[MediaFoods - 1]);
    Console.WriteLine(PreferiteFoods[MediaFoods]);
} else
{
    Console.WriteLine(PreferiteFoods[MediaFoods]);
}
*/

string ciboUtente = "";


Console.WriteLine("Qual'è il tuo cibo preferito?");
ciboUtente = Console.ReadLine();

var rand = new Random();
int ciboComputer = rand.Next(0, PreferiteFoods.Length);

for (int i = 0; i < PreferiteFoods.Length; i++)
{
    if(ciboUtente == PreferiteFoods[i])
    {
        PreferiteFoods[i] = $"{PreferiteFoods[i]} <-- Il tuo cibo preferito è {ciboUtente}";
    }
    if(ciboComputer == i)
    {
        PreferiteFoods[i] = $"{PreferiteFoods[i]} <-- Il mio cibo preferito è {PreferiteFoods[i]}";
    }
    Console.WriteLine(PreferiteFoods[i]);
        
}
