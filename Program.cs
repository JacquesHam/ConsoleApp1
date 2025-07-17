// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
clsMaClasse macls = new clsMaClasse();
macls.AfficherMessage();

clsMaClasse maclsss = new clsMaClasse("Initialisation on the fly");
maclsss.AfficherMessage();

Console.ReadKey();