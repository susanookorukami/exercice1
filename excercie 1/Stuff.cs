using excercie_1.agent;
using excercie_1.service;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace excercie_1
{
    class Stuff
    {
        private static DemandeUtilisateur _DemandeUtilisateur = new DemandeUtilisateur();
        private static DemandeVoiture _DemandeVoiture = new DemandeVoiture(_DemandeUtilisateur);
        static void Main(string[] args)
        {
            List<Voiture> voitures = new List<Voiture>();
            while (true)
            {
                string choix = Menu();
                if (choix == "1")
                {
                    Voiture v = _DemandeVoiture.CreerVoiture();
                }
                else if (choix == "2")
                {
                    _DemandeVoiture.AfficheVoiture(voitures);
                }
                else
                {
                    Console.WriteLine("commande non exsitant");
                }
            }
            
           

        }

        public static string Menu()
        {
            Console.WriteLine("1.créé un vehicule");
            Console.WriteLine("2.afficher la liste des véhicule");
            string choix = Console.ReadLine();
            return choix;
        }
    }
}
