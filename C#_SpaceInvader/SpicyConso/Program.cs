using Model;  // Importe les classes du modèle
using Display;  // Importe les classes pour l'affichage
using System.Numerics;  // Importe le support pour les vecteurs
using Storage;  // Importe les classes de stockage
using System;  // Importe le support pour les fonctions générales
using System.Collections.Generic;  // Importe les classes pour les listes
using System.Threading;  // Importe le support pour les opérations asynchrones

uint frameNumber = 0;  // Compteur du nombre de trames affichées

Console.WindowHeight = Playground.SHEIGHT;  // Définit la hauteur de la fenêtre de la console
Console.WindowWidth = Playground.SWIDTH;  // Définit la largeur de la fenêtre de la console
Alien alain = new Alien();  // Crée une instance d'un Alien
List<MissileCanon> missileJoueur = new List<MissileCanon>();  // Liste pour les missiles du joueur
List<Alien> Alienlist = new List<Alien>();  // Liste pour les aliens
Canon joueur = new Canon();  // Crée une instance d'un Canon
Playground.Init();  // Initialise le terrain de jeu

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
            case ConsoleKey.Escape:
                Environment.Exit(0);  // Quitte le jeu
                break;
            case ConsoleKey.Spacebar:
                if (missileJoueur.Count < 50)  // Vérifie que le nombre de missiles ne dépasse pas 50
                {
                    MissileCanon missileJoueurDefault = new MissileCanon(100);  // Crée un missile de base
                    missileJoueur.Add(missileJoueurDefault);  // Ajoute le missile à la liste
                    joueur.chargement(missileJoueurDefault);  // Charge le missile dans le canon du joueur
                    joueur.dropMissile();  // Lance le missile
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
        // Boucle pour mettre à jour la position des missiles
        for (int i = missileJoueur.Count - 1; i >= 0; i--)
        {
            MissileCanon missileDefault = missileJoueur[i];

            if (frameNumber % 1 == 0)  // Vitesse du missile (1 indique la fréquence de mise à jour)
            {
                missileDefault.UpdateMisille();  // Met à jour la position du missile
                if (!missileDefault.missileIsLaunched)
                {
                    missileJoueur.RemoveAt(i);  // Supprime le missile s'il n'est plus en jeu
                }
            }
        }
    }

  

    // Autosave
    if (frameNumber % 1000 == 0)
    {
        Store.StoreAlien(alain);  // Sauvegarde l'état de l'alien
    }

    // Timing (pause pour contrôler la vitesse du jeu)
      Thread.Sleep (150);  // Pause de 150 millisecondes entre chaque trame
}
