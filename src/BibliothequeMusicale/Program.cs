using System;
using BibliothequeMusicale; // ton namespace

namespace BibliothequeMusicaleApp
{
    public class Program
    {
        public static void Main()
        {
            // ==========================
            // Partie 1 : XMLReader
            // ==========================
            XMLReader reader = new XMLReader();

            // Titres de Booba
            Console.WriteLine("--------------- Titres de Booba (XmlReader) ---------------------------");
            reader.LireElements("../xml/BibliothequeMusical.xml");

            // Nombre d'artistes
            Console.WriteLine("--------------- Nombre d'artistes (XmlReader) ---------------------------");
            int nbArtistes = reader.getArtiste("../xml/BibliothequeMusical.xml");
            Console.WriteLine("Le nombre d'artistes : " + nbArtistes);

            // ==========================
            // Partie 2 : XMLSerialiser
            // ==========================
            XMLSerialiser serialiser = new XMLSerialiser("../xml/BibliothequeMusical.xml");

            // Lire la bibliothèque
            Bibliotheque bibliotheque = serialiser.LireBibliotheque();

            // Affichage complet
            Console.WriteLine("\n=============== Bibliothèque complète (XmlSerializer) ===============");
            Console.WriteLine(bibliotheque.ToString());
        }
    }
}