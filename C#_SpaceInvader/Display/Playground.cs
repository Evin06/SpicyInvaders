using Model;

namespace Display
{
    public class Playground
    {
        //enlever le curseur
        public static void Init()
        {
            Console.CursorVisible = false;
        }

        /// <summary>
        /// super ce qui ce trouve sur l'écran 
        /// </summary>
        public static void Clear()
        {
            Console.Clear();
        }
        // taille de l'écran
        public const int SHEIGHT = 50;
        public const int SWIDTH = 150;

    }
}