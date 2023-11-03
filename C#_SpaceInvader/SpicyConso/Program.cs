using Model;
using Display;
using System.Numerics;
using Storage;
using System;
using System.Collections.Generic;
using System.Threading;


Console.WindowHeight = Playground.SHEIGHT;  // Définit la hauteur de la fenêtre de la console
Console.WindowWidth = Playground.SWIDTH;  // Définit la largeur de la fenêtre de la console

Playground.Init();  // Initialise le terrain de jeu


//Menu principale
while (true)
{
    // Affichage du Menu principal
    Menu.DrawTitre();


    Menu.DrawJouer();


    Menu.DrawScore();

    Menu.DrawQuitter();

    ConsoleKeyInfo keyPressed = Console.ReadKey(true);

    //permet de choisir quel page on veut aller depuis le menu 
    switch (keyPressed.Key)
    {
        case ConsoleKey.NumPad1:
            Game();
            break;
        case ConsoleKey.NumPad2:
            Classement();
            break;
        case ConsoleKey.NumPad3:
            Environment.Exit(0);  // Quitte le jeu
            break;
    }
}

static void Game()
{


    uint frameNumber = 0;  // Compteur du nombre de trames affichées
    Alien alain = new Alien();  // Crée une instance d'un Alien
    List<MissileCanon> missileJoueur = new List<MissileCanon>();  // Liste pour les missiles du joueur
    List<Alien> Alienlist = new List<Alien>();  // Liste pour les aliens
    Canon joueur = new Canon();  // Crée une instance d'un Canon


    while (true)
    {
        // Actions de l'utilisateur
        while (Console.KeyAvailable)  // Vérifie si l'utilisateur a pressé une touche
        {
            ConsoleKeyInfo keyPressed = Console.ReadKey(false);
            switch (keyPressed.Key)
            {
                case ConsoleKey.RightArrow:
                    joueur.MoveRight();  // Déplace le canon vers la droite
                    break;
                case ConsoleKey.LeftArrow:
                    joueur.MoveLeft();  // Déplace le canon vers la gauche
                    break;

                case ConsoleKey.Spacebar:
                    if (missileJoueur.Count < 5000)  // Vérifie que le nombre de missiles ne dépasse pas 50
                    {
                        MissileCanon missileJoueurs = new MissileCanon(100);  // Crée un missile de base
                        missileJoueur.Add(missileJoueurs);  // Ajoute le missile à la liste
                        joueur.chargement(missileJoueurs);  // Charge le missile dans le canon du joueur
                        joueur.shotMissile();  // Lance le missile
                    }
                    break;
            }
        }
        // Limite le nombre d'alien créé
        if (Alienlist.Count < 10)
        {
            Alien al = new Alien();  // Crée un nouvel Alien
            Alienlist.Add(al);  // Ajoute l'alien à la liste
        }

        // Déplacement au niveau du modèle (état)

        Playground.Clear();  // Efface le terrain de jeu

        // Affichage des aliens et mise à jour de leur position
        foreach (Alien al in Alienlist)
        {
            al.Draw();  // Affiche l'alien
            al.Move();  // Met à jour la position de l'alien

        }
        frameNumber++;  // Incrémente le compteur de trames

        joueur.Draw();  // Affiche le canon du joueur

        // Affichage des missiles du joueur

        foreach (Alien invader in Alienlist)
        {
            foreach (MissileCanon missileDefault in missileJoueur)
            {
                Missile.DrawMissileJoueur(missileDefault, invader);  // Affiche le missile du joueur
            }
        }

        // Boucle pour mettre à jour la position des missiles 
        for (int i = missileJoueur.Count - 1; i >= 0; i--)
        {
            MissileCanon missileD = missileJoueur[i];

            if (frameNumber % 1 == 0)  // Vitesse du missile (1 indique la fréquence de m   ise à jour)
            {
                missileD.UpdateMisille();  // Met à jour la position du missile

            }
        }


        // Autosave
        if (frameNumber % 1000 == 0)
        {
            Store.StoreAlien(alain);  // Sauvegarde l'état de l'alien
        }

        // Timing (pause pour contrôler la vitesse du jeu)
        Thread.Sleep(100);  // Pause de 150 millisecondes entre chaque trame
    }
}
static void Classement()
{
    Console.Clear();
    Console.ReadLine();
}