namespace Display
{
    public class Menu
    {
        public static int SousMenu = 2;

        public static string[] TITRE =
        {
            "Space invader"
        };
        public static string[] JOUER =
        {
            " 1.jouer"
        };
        public static string[] SCORE =
        {
            " 2.Score "
        };
        public static string[] QUITTER=
     {
            " 3.Quitter "
        };


        /// <summary>
        /// On affiche le Titre
        /// </summary>
        public static void DrawTitre()
        {

            for (int i = 0; i < TITRE.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 3+15, 0 + i);
                Console.WriteLine(TITRE[i]);

            }

        }

        /// <summary>
        /// On affiche le sous menu Jouer
        /// </summary>
        public static void DrawJouer()
        {

            for (int i = 0; i < JOUER.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 3 + 18, 6 + i);
                Console.WriteLine(JOUER[i]);

            }

        }

        /// <summary>
        /// On affiche le sous menu Score
        /// </summary>
        public static void DrawScore()
        {

            for (int i = 0; i < SCORE.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 3 + 18, 12 + i);
                Console.WriteLine(SCORE[i]);

            }

        }

        public static void DrawQuitter() 
        {
            for (int i = 0; i < QUITTER.Length; i++)
            {
                Console.SetCursorPosition(Console.WindowWidth / 3 + 18, 18 + i);
                Console.WriteLine(QUITTER[i]);

            }
        }
    }
}
