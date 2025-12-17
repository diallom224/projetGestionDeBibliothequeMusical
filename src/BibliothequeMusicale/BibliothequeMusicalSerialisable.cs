using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BibliothequeMusicale
{
    [Serializable]
    [XmlRoot("BibliothequeMusical", Namespace = "http://www.univ-grenoble-alpes.fr/l3miage/BibliothequeMusical")]
    public class Bibliotheque
    {
        [XmlElement("album")]
        public List<Album> Albums { get; set; } = new List<Album>();

        public override string ToString()
        {
            string s = "";
            int i = 1;
            foreach (var album in Albums)
            {
                s += $"Album #{i} : {album.Titre} par {album.Artiste} ({album.Genre})\n";
                int j = 1;
                foreach (var chanson in album.Chansons.ChansonList)
                {
                    s += $"   {j}. {chanson.Titre} ({chanson.DateSortie:yyyy-MM-dd})\n";
                    j++;
                }
                i++;
            }
            return s;
        }
    }

    [Serializable]
    public class Album
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlElement("titre")]
        public string Titre { get; set; }

        [XmlElement("artiste")]
        public string Artiste { get; set; }

        [XmlElement("genre")]
        public string Genre { get; set; }

        [XmlElement("chansons")]
        public ListeChansons Chansons { get; set; } = new ListeChansons();
    }

    [Serializable]
    public class ListeChansons
    {
        [XmlElement("chanson")]
        public List<Chanson> ChansonList { get; set; } = new List<Chanson>();
    }

    [Serializable]
    public class Chanson
    {
        [XmlElement("titre")]
        public string Titre { get; set; }

        [XmlElement("dateSortie")]
        public DateTime DateSortie { get; set; }
    }
}
