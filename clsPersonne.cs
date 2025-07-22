using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class clsPersonne
    {
        private string nom;
        private string prenom;
        private string ville;
        public clsPersonne()
        {
            this.nom = string.Empty;
            this.prenom = string.Empty;
            this.ville = string.Empty;
        }
        public clsPersonne(string nom, string prenom, string ville)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.ville = ville;
        }
        public string AssemblePersonne()
        { return this.prenom + " " +  this.nom + " viens de " + this.ville;}
    }
}
