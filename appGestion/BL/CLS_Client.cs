using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appGestion.BL
{
    class CLS_Client
    {
        private DbStockContext db = new DbStockContext();
        private Client C;
        // Fonction pour Ajouter Fournissuer dans la Base de donneés 
        public bool Ajouter_Client(string Nom, string Addresse, string Tel)
        {
            C = new Client(); // nouveau Client
        
            C.Nom_Client = Nom;
            C.Adresse_Client = Addresse;
            C.Téléphone_Client = Tel;
            // verifier le nom et la Reference est deja existe dans la base de donneés
            if (db.Clients.SingleOrDefault(a => a.Nom_Client == Nom) == null)  // si n'existe pas
            {
                db.Clients.Add(C);
                db.SaveChanges(); // Enregistrer dans la base de donneé
                return true;

            }
            else // si il existe dans la base de doneé 
            {
                return false;
            }
        }
        // Fonction pour Modifier Produit dans la Base de donneés 

        public void Modifier_Client(int id, string Nom, string Addresse, string Téléphone)
        {

            C = new Client(); // nouveau client 
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id); // verifier si id de produit s il existe 
            if (C != null) // existe 
            {
                C.Nom_Client = Nom;
                C.Adresse_Client = Addresse;
                C.Téléphone_Client= Téléphone;
                db.SaveChanges(); // Enregistrer dans la base de donneé

            }


        }
        // Fonction Sup Produit 
        public void suprimer_Client(int id)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id);
            if (C != null) // existe 
            {
                db.Clients.Remove(C); // pour supprimer le Produit 
                db.SaveChanges();
            }
        }

    }
}
