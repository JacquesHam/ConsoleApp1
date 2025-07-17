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

        #region Constructeur
        public clsMaClasse()
        {
            message = string.Empty;
            message = "MaClasse est initialisée";
        }
        public clsMaClasse(string mess)
        {
            message = string.Empty;
            message = mess;
        }
        #endregion


        // Méthode pour afficher le message
        public void AfficherMessage()
        {
            Console.WriteLine("Message : " + message);
        }

        
    }
}
