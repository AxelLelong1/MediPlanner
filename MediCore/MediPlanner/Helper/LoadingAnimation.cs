using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MediPlanner.Helper
{
    class LoadingAnimation
    {
        // Fonction pour afficher l'animation de chargement (spinner)
        static public void loading(CancellationToken token, string message = "data")
        {
            string[] spinner = { "|", "/", "-", "\\" };
            int counter = 0;

            while (!token.IsCancellationRequested)
            {
                Console.Write("Fetching {1} {0}", spinner[counter % spinner.Length], message);
                Console.SetCursorPosition(Console.CursorLeft - 11 - message.Length, Console.CursorTop); // Garde le curseur à sa position
                counter++;
                Thread.Sleep(200);  // Vitesse de l'animation
            }
        }
    }
}
