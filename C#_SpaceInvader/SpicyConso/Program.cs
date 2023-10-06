using Model;
using Display;
using System.Numerics;
using Storage;

uint frameNumber = 0; // count the number of frames displayed
Console.WindowHeight = Playground.SHEIGHT;
Console.WindowWidth = Playground.SWIDTH;

Alien alain = new Alien();
List<Alien> Alienlist = new List<Alien>();
Canon joueur = new Canon();
Playground.Init();

for(int i = 0;i < 10 ; i++) 
{
    Alien al = new Alien();
    Alienlist.Add(al);
}

while (true)
{
    // Actions de l'utilisateur
    while (Console.KeyAvailable) // L'utilisateur a pressé une touche
    {
        ConsoleKeyInfo keyPressed = Console.ReadKey(false);
        switch (keyPressed.Key)
        {
            case ConsoleKey.RightArrow:
                joueur.MoveRight();
                break;
            case ConsoleKey.LeftArrow:
                joueur.MoveLeft();
                break;
            case ConsoleKey.Escape:
                Environment.Exit(0);
                break;
        }
    }

    // Déplacement au niveau du modèle (état)
    alain.Move();

    // Affichage
    Playground.Clear();
    alain.Draw();
    frameNumber++;

    joueur.Draw();

    // Autosave
    if (frameNumber % 1000 == 0)
    {
        Store.StoreAlien(alain);
    }

    // Timing
    Thread.Sleep(3);
}