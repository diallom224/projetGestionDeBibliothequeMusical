using System;
using System.IO;
using System.Xml.Serialization;

namespace BibliothequeMusicale
{
    public class XMLSerialiser
    {
        private readonly string _filepath;

        // Constructeur : chemin du fichier XML
        public XMLSerialiser(string filepath)
        {
            _filepath = filepath;
        }


        /// Désérialise le fichier XML en objet Bibliotheque

        public Bibliotheque LireBibliotheque()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Bibliotheque));

            using (FileStream fs = new FileStream(_filepath, FileMode.Open))
            {
                return (Bibliotheque)serializer.Deserialize(fs);
            }
        }

        // Sérialise un objet Bibliotheque vers un fichier XML
     
        public void EcrireBibliotheque(Bibliotheque bibliotheque, string outputPath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Bibliotheque));

            using (FileStream fs = new FileStream(outputPath, FileMode.Create))
            {
                serializer.Serialize(fs, bibliotheque);
            }
        }
        
       
    }
}