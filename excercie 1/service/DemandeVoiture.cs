using excercie_1.agent;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace excercie_1.service
{
    public class DemandeVoiture
    {
        private DemandeUtilisateur _DemandeUtilisateur;

        public DemandeVoiture(DemandeUtilisateur demandeUtilisateur)
        {
            this._DemandeUtilisateur = demandeUtilisateur;
        }

        public Voiture CreerVoiture()
        {
            Voiture v = new Voiture();
            v.NOmV = _DemandeUtilisateur.DemandeLettre("entrer le nom du véhicule souhaiter");
            v.NbPlace = _DemandeUtilisateur.DemandeEntier("entrer le nombre de place que vous souhaiter");
            v.TypeV = _DemandeUtilisateur.DemandeLettre("entrer le type de vehicule que vous souhaiter");
            return v;
        }
        public Voiture CreePVoiture()
        {
            Voiture v = new Voiture();
            for(int i =0; i < 5; i++)
            {
                string nom = "Tesla";
                int nombre = 2;
                string type = "sport";
                v.NOmV = _DemandeUtilisateur.DemandeLettre("entrer le nom du véhicule souhaiter");
                v.NOmV = nom;
                v.NbPlace = _DemandeUtilisateur.DemandeEntier("entrer le nombre de place que vous souhaiter");
                v.NbPlace = nombre;
                v.TypeV = _DemandeUtilisateur.DemandeLettre("entrer le type de vehicule que vous souhaiter");
                v.TypeV = type;
               
                /*Console.WriteLine("voiture: Tesla");
               Console.WriteLine("nombre de place 2");
               Console.WriteLine("type de voiture: Sport");

               Console.ReadLine();*/


            }
            return v;
        }

        public void  AfficheVoiture(List<Voiture>voitures)
        {
            Console.WriteLine("voiture: ");

                foreach (Voiture v in voitures)
                { 
                  string message = "Voiture : " + v.NOmV + " Nombre de place : " + v.NbPlace + " Type de voiture : " + v.TypeV;
                  Console.WriteLine(message);
                } 
        }
    }
}
