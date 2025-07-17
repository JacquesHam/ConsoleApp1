using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class clsMaClasse
    {
        private string message;
        // Constructeur
        public clsMaClasse()
        {
            message = string.Empty;
            message = "MaClasse est initialisée";
        }

        // Méthode pour afficher le message
        public void AfficherMessage()
        {
            Console.WriteLine("Message : " + message);
        }
    }
}
