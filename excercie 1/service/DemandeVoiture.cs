using excercie_1.agent;
using System;
using System.Collections.Generic;
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
