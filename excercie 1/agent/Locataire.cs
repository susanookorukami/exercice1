using System;
using System.Collections.Generic;
using System.Text;

namespace excercie_1.agent
{
    public class Locataire
    {
        public string Nom;
        public string Prenom;
        public int age;
        public string permit;

        public List<Voiture> voitures { get; set; }
    }
}
