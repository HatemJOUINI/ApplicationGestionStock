using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appGestion
{
    class CLS_Connexion
    {
        // function pour verifier la connexion 
        public bool ConnexionValide(DbStockContext Db,string Nom , string Mot_de_pass)
        {
            utilisateur U = new utilisateur(); // table utilisateur 
            U.NomUtilisateur = Nom;
            U.MotdePasse = Mot_de_pass; 
            // si le nom et le mot de passe existe dans la base de donneé 
            if (Db.utilisateurs.SingleOrDefault(s=>s.NomUtilisateur==Nom && s.MotdePasse==Mot_de_pass)!=null)
            {
                return true; 
            
            } else // si n'existe pas 
            {
                return false; 
            }
        }
    }
}
