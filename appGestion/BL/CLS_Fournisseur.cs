using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appGestion.BL
{
    class CLS_Fournisseur
    {
        private DbStockContext db = new DbStockContext();
        private Fournisseur F;
        // Fonction pour Ajouter Fournissuer dans la Base de donneés 
        public bool Ajouter_Fournisseur(string Nom, string Addresse, string Tel)
        {
            F = new Fournisseur(); // nouveau fournisseur
            F.Nom_Fournisseur = Nom;
            F.Adresse_Fournisseur = Addresse;
            F.Téléphone_Fournisseur = Tel;
            // verifier le nom et la Reference est deja existe dans la base de donneés
            if (db.Fournisseurs.SingleOrDefault(a => a.Nom_Fournisseur == Nom) == null)  // si n'existe pas
            {
                db.Fournisseurs.Add(F);
                db.SaveChanges(); // Enregistrer dans la base de donneé
                return true;

            }
            else // si il existe dans la base de doneé 
            {
                return false;
            }
        }
        // Fonction pour Modifier Produit dans la Base de donneés 

        public void Modifier_Fourni(int id, string Nom, string Addresse, string Téléphone)
        {

            F = new Fournisseur(); // nouveau produit 
            F = db.Fournisseurs.SingleOrDefault(s => s.ID_Fournisseur == id); // verifier si id de produit s il existe 
            if (F != null) // existe 
            {
                F.Nom_Fournisseur = Nom;
                F.Adresse_Fournisseur = Addresse;
                F.Téléphone_Fournisseur = Téléphone;
                db.SaveChanges(); // Enregistrer dans la base de donneé

            }


        }
        // Fonction Sup Produit 
        public void suprimer_Fourn(int id)
        {
            F = new Fournisseur();
            F = db.Fournisseurs.SingleOrDefault(s => s.ID_Fournisseur == id);
            if (F != null) // existe 
            {
                db.Fournisseurs.Remove(F); // pour supprimer le Produit 
                db.SaveChanges();
            }
        }

    }
}
