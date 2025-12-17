using System;
using System.Xml;

namespace BibliothequeMusicale
{
    public class XMLReader
    {
        public void LireElements(string filepath)
        {
            using (XmlReader reader = XmlReader.Create(filepath))
            {
                string artisteCourant = "";

                while (reader.Read())
                {
                    // Lire l'artiste
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "artiste")
                    {
                        artisteCourant = reader.ReadElementContentAsString();
                    }

                    // Lire le titre si l'artiste est Booba
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "titre" && artisteCourant == "Booba")
                    {
                        string titreBooba = reader.ReadElementContentAsString();
                        Console.WriteLine(titreBooba);
                    }
                }
            }
        }

        public int getArtiste(string filepath)
        {
            int nbArtiste = 0;

            using (XmlReader reader = XmlReader.Create(filepath))
            {   
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        switch (reader.LocalName)
                        {
                            case "album":
                                Console.WriteLine("\nAlbum : youpi jai trouver un album .");
                                break;

                            case "artiste":
                                nbArtiste++;
                                Console.WriteLine("\nArtiste : youpi jai trouver un artiste .");
                                break;

                            case "chanson":
                                Console.WriteLine("\nChanson : Artiste : youpi jai trouver un chanson .");
                                break;
                        }
                    }
                }
            }

            return nbArtiste;
        }

        
    }
}