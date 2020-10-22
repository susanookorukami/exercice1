using excercie_1.agent;
using excercie_1.service;
using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace excercie_1
{
    class Stuff
    {
        private static DemandeUtilisateur _DemandeUtilisateur = new DemandeUtilisateur();
        private static DemandeVoiture _DemandeVoiture = new DemandeVoiture(_DemandeUtilisateur);
        private static ServiceLocataire _ServiceLocataire = new ServiceLocataire(_DemandeUtilisateur, _DemandeVoiture);
        static void Main(string[] args)
        {
            List<Voiture> voitures = new List<Voiture>();
            List<Locataire> locataires = new List<Locataire>();
            while (true)
            {
                string choix = Menu();
                if (choix == "1")
                {
                    Voiture v = _DemandeVoiture.CreePVoiture();
                    voitures.Add(v);
                    // _DemandeVoiture.CreePVoiture(voitures);
                }
                else if    (choix == "2")
                {
                    Voiture v = _DemandeVoiture.CreerVoiture();
                    voitures.Add(v);
                }
                else if (choix == "3")
                {
                    _DemandeVoiture.AfficheVoiture(voitures);
                }
                else if (choix == "4")
                {
                    Locataire l = _ServiceLocataire.creeLocataire();
                    locataires.Add(l);
                }
               /* else if (choix == "2")
                {
                    _DemandeVoiture.AfficheVoiture(voitures);
                }*/
                else
                {
                    Console.WriteLine("commande non exsitant");
                }
            }
            
           

        }

        public static string Menu()
        {
            Console.WriteLine("1.affiche vehicule pré renregistrer");
            Console.WriteLine("2.créé un vehicule");
            Console.WriteLine("3.afficher la liste des véhicule");
            Console.WriteLine("4.creé un locataire");
            string choix = Console.ReadLine();
            return choix;
        }
    }
}
