namespace Display
{
    public class Menu
    {
        public static int SousMenu = 2;

        /// <summary>
        /// Titre du jeu 
        /// </summary>
        public static string[] TITRE =
        {
            "Space invader"
        };
        /// <summary>
        /// sous titre Jouer 
        /// </summary>
        public static string[] JOUER =
        {
            " 1.jouer"
        };
        /// <summary>
        /// sous titre Score 
        /// </summary>
        public static string[] SCORE =
        {
            " 2.Score "
        };
        /// <summary>
        /// sous titre quitter 
        /// </summary>
        public static string[] QUITTER =
        {
            " 3.Quitter "
        };


        /// <summary>
        /// Ca affiche le titre en haut au milieu de la fenetre 
        /// </summary>
        public static void DrawTitre()
        {

            for (int i = 0; i < TITRE.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 3 + 16, 0 + i);
                Console.WriteLine(TITRE[i]);

            }

        }

        /// <summary>
        /// Ca affiche le sous titre jouer en dessous du titre 
        /// </summary>
        public static void DrawJouer()
        {

            for (int i = 0; i < JOUER.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 3 + 18, 2 + i);
                Console.WriteLine(JOUER[i]);

            }

        }

        /// <summary>
        /// Ca affche le sous titre score  en dessous de Jouer 
        /// </summary>
        public static void DrawScore()
        {

            for (int i = 0; i < SCORE.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 3 + 18, 4 + i);
                Console.WriteLine(SCORE[i]);

            }

        }

        /// <summary>
        /// permet d'afficher le choix quittez en dessous de score 
        /// </summary>
        public static void DrawQuitter()
        {
            for (int i = 0; i < QUITTER.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 3 + 18, 6 + i);
                Console.WriteLine(QUITTER[i]);

            }
        }
    }
}
