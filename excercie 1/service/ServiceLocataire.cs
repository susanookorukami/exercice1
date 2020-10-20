using excercie_1.agent;
using System;
using System.Collections.Generic;
using System.Text;

namespace excercie_1.service
{
    
    public class ServiceLocataire
    {
        private DemandeUtilisateur _DemandeUtilisateur;
        private DemandeVoiture _DemandeVoiture;

        public ServiceLocataire(DemandeUtilisateur demandeUtilisateur, DemandeVoiture demandeVoiture)
        {
            this._DemandeUtilisateur = demandeUtilisateur;
            this._DemandeVoiture = demandeVoiture;
        }
            
        public Locataire creeLocataire()
        {
            Locataire l = new Locataire();

            l.Nom = _DemandeUtilisateur.DemandeLettre("quel est votre Nom?");
            l.Prenom = _DemandeUtilisateur.DemandeLettre("quel est votre prenom?");
            l.age = _DemandeUtilisateur.DemandeEntier("quel est votre age?");
            l.permit =_DemandeUtilisateur.DemandeVF("avez vous le permit?");
            return l;
        }
    }
}
