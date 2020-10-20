using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace excercie_1.service
{
    public class DemandeUtilisateur
    {
        public int DemandeEntier(string message)
        {
            Console.WriteLine(message);
            string Nb = Console.ReadLine();
            int intvalue;
            while(!int.TryParse(Nb,out intvalue))
            {
                Console.WriteLine("la saissie est invalide");
                Nb = Console.ReadLine();
            }
            return intvalue;
        }

        public string DemandeLettre(string message)
        {
            Console.WriteLine(message);
            string lettre = Console.ReadLine();
            bool ok = false;
            int valeurconvertie;

            while (ok == false)
            {
                if (string.IsNullOrEmpty(lettre))
                {
                    Console.WriteLine("Saisie incorrecte: veuillez saisir quelque chose");
                    lettre = Console.ReadLine();
                }
                else if (int.TryParse(lettre, out valeurconvertie))
                {
                    Console.WriteLine("Saisie incorrecte: le nom ne peut pas être un nombre");
                    lettre = Console.ReadLine();
                }
                else if (lettre[0] < 65 || lettre[0] > 90)
                {
                    Console.WriteLine("Saisie incorrecte: veuillez commencer le nom par une majuscule");
                    lettre = Console.ReadLine();
                }
                else
                {
                    ok = true;
                }
            }
            return lettre;
        }

        public string DemandeVF(string message)
        {
            Console.WriteLine(message);
            string vf = Console.ReadLine();
            bool permit = false;
            int valeurconvertie;
            while (permit  == false)
            {
                string valeur= vf;
                if (vf == "Oui")
                {
                    
                    return vf;
                }
                else if (string.IsNullOrEmpty(vf))
                {
                    Console.WriteLine("Saisie incorrecte: veuillez saisir quelque chose");
                    vf = Console.ReadLine();
                }
                else if (int.TryParse(vf, out valeurconvertie))
                {
                    Console.WriteLine("Saisie incorrecte: le nom ne peut pas être un nombre");
                    vf = Console.ReadLine();
                }
                else if (vf[0] < 65 || vf[0] > 90)
                {
                    Console.WriteLine("Saisie incorrecte: veuillez commencer le nom par une majuscule");
                    vf = Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("permis obligatoire");
                    break;
                }
               
            }
            
            
            return vf;
            
        }
    }
}
