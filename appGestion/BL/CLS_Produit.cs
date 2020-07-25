using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appGestion
{
    class CLS_Produit
    {
        private DbStockContext db = new DbStockContext();
        private Produit P; // table Produit 

        // Fonction pour Ajouter Produit dans la Base de donneés 
        public bool Ajouter_Produit (string Nom , string Reference , string Quantite , string Rayon , string Designation)
        {
            P = new Produit(); // nouveau produit 
            P.Nom_Produit = Nom;
            P.Reference_Produit = Reference;
            P.Quantite_Produit = Quantite;
            P.Rayon_Produit = Rayon;
            P.Designation_Produit = Designation;
        // verifier le nom et la Reference est deja existe dans la base de donneés 
        if(db.Produits.SingleOrDefault(s=>s.Nom_Produit==Nom && P.Reference_Produit==Reference)==null) // si n'existe pas
            {
                db.Produits.Add(P); // Ajouter dans la table Produit
                db.SaveChanges(); // Enregistrer dans la base de donneé
                return true;
            } else // si il existe dans la base de doneé 
            {
                return false; 
            }
           

        }
        // Fonction pour Modifier Produit dans la Base de donneés 

        public void Modifier_Produit(int id , string Nom, string Reference, string Quantite, string Rayon, string Designation)
        {

            P = new Produit(); // nouveau produit 
            P = db.Produits.SingleOrDefault(s => s.ID_Produit == id); // verifier si id de produit s il existe 
            if (P!=null) // existe 
            {
                P.Nom_Produit = Nom;
                P.Reference_Produit = Reference;
                P.Quantite_Produit = Quantite;
                P.Rayon_Produit = Rayon;
                P.Designation_Produit = Designation;
                db.SaveChanges(); // Enregistrer dans la base de donneé

            }


        }
        // Fonction Sup Produit 
        public void suprimer_Produit (int id)
        {
            P = new Produit();
            P = db.Produits.SingleOrDefault(s => s.ID_Produit == id);
            if (P!=null) // existe 
            {
                db.Produits.Remove(P); // pour supprimer le Produit 
                db.SaveChanges();
            }
        }



    }
}
