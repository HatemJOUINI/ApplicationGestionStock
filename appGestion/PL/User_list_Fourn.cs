using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appGestion
{
    public partial class User_list_Fourn : UserControl
    {
        private static User_list_Fourn UserProduit;
        private DbStockContext db;
        // creé un instance pour le user control 
        public static User_list_Fourn Instance
        {
            get
            {
                if (UserProduit == null)
                {
                    UserProduit = new User_list_Fourn();
                }
                return UserProduit;
            }
        }
        public User_list_Fourn()
        {
            InitializeComponent();
            db = new DbStockContext();
            // desactiver text box de recherche 
            //txtrecherche.Enabled = false;
        }
        // Ajouter dans Datagridview 
        public void Actualiserdatagrid1()
        {
            db = new DbStockContext();
            dvgFourn.Rows.Clear(); // vider datagrid view 
            foreach (var S in db.Fournisseurs)
            {
                // Ajouter des lignes dans data grid view 
                dvgFourn.Rows.Add(false, S.ID_Fournisseur, S.Nom_Fournisseur, S.Adresse_Fournisseur, S.Téléphone_Fournisseur);

            }
        }
        // verifier combien de ligne est sélectionner 
        public string SelectVerif()
        {
            int nombreligneSelect = 0;
            for (int i = 0; i < dvgFourn.Rows.Count; i++)
            {
                if ((bool)dvgFourn.Rows[i].Cells[0].Value == true) // si la ligne est selectionner 
                {
                    nombreligneSelect++; // Nombre de ligne +1
                }
            }
            if (nombreligneSelect == 0)
            {
                return " Selectionner le Produit que vous-voulez modifier";

            }
            if (nombreligneSelect > 1)
            {
                return " Selectionner seulement 1 seul produit pour modifier";

            }
            return null;
        }

        private void User_list_Fourn_Load(object sender, EventArgs e)
        {
            Actualiserdatagrid1();
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
           
        }

        //private void txtrecherche_Enter(object sender, EventArgs e)
      //  {

         //   if (txtrecherche.Text == "Recherche")
          //  {
           //     txtrecherche.Text = "";
              //  txtrecherche.ForeColor = Color.Black;
            //}
       // }

        private void btnajout_Click(object sender, EventArgs e)
        {
            Ajouter_Modifier_Fournisseur fournisseur = new Ajouter_Modifier_Fournisseur(this);
            fournisseur.ShowDialog();
        }

        private void btnmodifierproduit_Click(object sender, EventArgs e)
        {
            Ajouter_Modifier_Fournisseur frm = new Ajouter_Modifier_Fournisseur(this);
            if (SelectVerif() == null)
            {
                for (int i = 0; i < dvgFourn.Rows.Count; i++)
                {
                    if ((bool)dvgFourn.Rows[i].Cells[0].Value == true) // si le checkBox est vrai affichier les informations dans le formulaire Client 
                    {
                        frm.idSelect = (int)dvgFourn.Rows[i].Cells[1].Value;
                        frm.txtNom.Text = dvgFourn.Rows[i].Cells[2].Value.ToString();
                        frm.txtAdd.Text = dvgFourn.Rows[i].Cells[3].Value.ToString();
                        frm.txtTel.Text = dvgFourn.Rows[i].Cells[4].Value.ToString();
                        
                    }
                }

                frm.lbltitre.Text = "Modifier Produit";
                frm.btnactualiser.Visible = false;
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnsuppProduit_Click(object sender, EventArgs e)
        {
            BL.CLS_Fournisseur fournisseur = new BL.CLS_Fournisseur();
            // pour supprimer tous les Produit Selectionner 
            int select = 0;
            for (int i = 0; i < dvgFourn.Rows.Count; i++)
            {
                if ((bool)dvgFourn.Rows[i].Cells[0].Value == true)
                {
                    select++; // Combien de ligne Selectionnez 
                }
            }
            if (select == 0)
            {
                MessageBox.Show("Aucun Fournisseur Selectionner", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult R =

                     MessageBox.Show("Vous-Voulez vraiment Supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    //  pour supprimer Produit selectionner
                    for (int i = 0; i < dvgFourn.Rows.Count; i++)
                    {
                        if ((bool)dvgFourn.Rows[i].Cells[0].Value == true)
                        {
                            fournisseur.suprimer_Fourn(int.Parse(dvgFourn.Rows[i].Cells[1].Value.ToString())); // id Produit 
                        }
                    }
                    // actualiser datagridview 
                    Actualiserdatagrid1();

                    MessageBox.Show("Supression avec succées", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Supression est annulé ", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void txtrecherche_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
