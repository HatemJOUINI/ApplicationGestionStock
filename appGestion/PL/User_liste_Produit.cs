using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace appGestion
{
    public partial class User_liste_Produit : UserControl
    {
        private static User_liste_Produit UserProduit;
        private DbStockContext db;
        // creé un instance pour le user control 
        public static User_liste_Produit Instance
        {
            get
            {
                if (UserProduit==null)
                {
                    UserProduit = new User_liste_Produit();
                }
                return UserProduit;
            }
        }

        public User_liste_Produit()
        {
            InitializeComponent();
            db = new DbStockContext();
            // desactiver text box de recherche 
            txtrecherche.Enabled = false; 
        }
        // Ajouter dans Datagridview 
        public void Actualiserdatagrid ()
        {
            db = new DbStockContext();
            dvgProduit.Rows.Clear(); // vider datagrid view 
            foreach(var S in db.Produits)
            {
                // Ajouter des lignes dans data grid view 
                dvgProduit.Rows.Add(false, S.ID_Produit, S.Nom_Produit, S.Reference_Produit, S.Quantite_Produit, S.Rayon_Produit, S.Designation_Produit);

            }
        }
        // verifier combien de ligne est sélectionner 
        public string SelectVerif ()
        {
            int nombreligneSelect = 0;
            for ( int i=0; i<dvgProduit.Rows.Count;i++)
            {
                if ((bool)dvgProduit.Rows[i].Cells[0].Value==true) // si la ligne est selectionner 
                {
                    nombreligneSelect++; // Nombre de ligne +1
                }
            }
            if (nombreligneSelect==0)
            {
                return " Selectionner le Produit que vous-voulez modifier"; 

            }
            if (nombreligneSelect >1)
            {
                return " Selectionner seulement 1 seul produit pour modifier";

            }
            return null; 
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text=="Recherche")
            {
                txtrecherche.Text = "";
                txtrecherche.ForeColor = Color.Black;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void User_liste_Produit_Load(object sender, EventArgs e)
        {
            Actualiserdatagrid();
        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            // afficher formulaire de saisie 
            FRM_Ajouter_Modifier_Produit frmproduit = new FRM_Ajouter_Modifier_Produit(this) ;
            frmproduit.ShowDialog();
        }
        private void btnmodifierproduit_Click(object sender, EventArgs e)
        {
            FRM_Ajouter_Modifier_Produit frmproduit = new FRM_Ajouter_Modifier_Produit(this);
            if(SelectVerif()==null)
            {
                for(int i=0; i<dvgProduit.Rows.Count;i++)
                {
                    if ((bool)dvgProduit.Rows[i].Cells[0].Value==true) // si le checkBox est vrai affichier les informations dans le formulaire Client 
                    {
                        frmproduit.idSelect = (int)dvgProduit.Rows[i].Cells[1].Value;
                        frmproduit.txtNom.Text = dvgProduit.Rows[i].Cells[2].Value.ToString();
                        frmproduit.txtRef.Text = dvgProduit.Rows[i].Cells[3].Value.ToString();
                        frmproduit.txtQantite.Text = dvgProduit.Rows[i].Cells[4].Value.ToString();
                        frmproduit.txtRay.Text = dvgProduit.Rows[i].Cells[5].Value.ToString();
                        frmproduit.txtDes.Text = dvgProduit.Rows[i].Cells[6].Value.ToString();
                    }
                }

                frmproduit.lbltitre.Text = "Modifier Produit";
                frmproduit.btnactualiser.Visible = false;
                frmproduit.ShowDialog();

            } else
            {
                MessageBox.Show(SelectVerif(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnsuppProduit_Click(object sender, EventArgs e)
        {
            CLS_Produit P_Produit = new CLS_Produit();
            // pour supprimer tous les Produit Selectionner 
            int select = 0;
            for (int i=0; i<dvgProduit.Rows.Count;i++)
            {
                if ((bool)dvgProduit.Rows[i].Cells[0].Value==true)
                {
                    select++; // Combien de ligne Selectionnez 
                }
            }
            if (select==0)
            {
                MessageBox.Show("Aucun Produit Selectionner", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            } else
            {
                DialogResult R =

                     MessageBox.Show("Vous-Voulez vraiment Supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R==DialogResult.Yes)
                {
                    //  pour supprimer Produit selectionner
                    for (int i = 0; i < dvgProduit.Rows.Count; i++)
                    {
                        if ((bool)dvgProduit.Rows[i].Cells[0].Value == true)
                        {
                            P_Produit.suprimer_Produit(int.Parse(dvgProduit.Rows[i].Cells[1].Value.ToString())); // id Produit 
                        }
                    }
                    // actualiser datagridview 
                    Actualiserdatagrid();

                    MessageBox.Show("Supression avec succées", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                } else
                {
                    MessageBox.Show("Supression est annulé ", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void comborecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            // activer le textbox recherche si j'ai choisie un champs 
            txtrecherche.Enabled = true;
            txtrecherche.Text = ""; // vider le textbox de recherche 
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new DbStockContext();
            var listrecherche = db.Produits.ToList(); // liste recherche = liste des produits 
            if (txtrecherche.Text != "") // pas vide 
            {
                switch (comborecherche.Text)
                {
                   // case "ID":
                      // listrecherche = listrecherche.Where(s => s.ID_Produit.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        // string comparis.currentCultutrignorecase == sois j'ecris la 1er lettre en majus ou minuscule 
                        // !=-1 existe dans la base de donnees
                       // break;
                    case "Nom":
                        listrecherche = listrecherche.Where(s => s.Nom_Produit.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;



                }
            }
            // vider datagrid 
            dvgProduit.Rows.Clear();
            // ajouter liste recherche dans la data gride view Produit 
            foreach(var l in  listrecherche )
                {

                dvgProduit.Rows.Add(false, l.ID_Produit , l.Nom_Produit);
            }

        }

        private void btnRAP_Click(object sender, EventArgs e)
        {
            db = new DbStockContext();
            int idselect=0;
            // String NomProduit=null;
            String idProduit = null;
            RAP.FRM_Rapport frmpt = new RAP.FRM_Rapport () ;
            Produit Pr = new Produit();
            if (SelectVerif()!=null)
            {
                MessageBox.Show(SelectVerif(), "Imprimer Produit", MessageBoxButtons.OK, MessageBoxIcon.Error); // verifier si l'utilisateur cocher plusieur ligne 
            } 
            else
            {
                for (int i=0; i<dvgProduit.Rows.Count;i++)
                {
                    if ((bool)dvgProduit.Rows[i].Cells[0].Value==true) // si la ligne est cocher 
                    {
                        idselect = (int)dvgProduit.Rows[i].Cells[1].Value; // id de ligne selectionner 
                    // NomProduit = dvgProduit.Rows[i].Cells[6].Value.ToString();
                        idProduit = dvgProduit.Rows[i].Cells[6].Value.ToString();
                    }
                }
                //////////////////// 
                Pr = db.Produits.SingleOrDefault(s => s.ID_Produit == idselect);
                if(Pr!=null) // si produit existe 
                {
                    // donner le rapport 
                    frmpt.RPAfichier.LocalReport.ReportEmbeddedResource = "appGestion.RAP.RPT_Produit.rdlc";
                    ReportParameter PID  = new ReportParameter("RPID", idProduit );
                    ReportParameter PNom = new ReportParameter("RPNOM", Pr.Nom_Produit);
                    ReportParameter PRef = new ReportParameter("RPRéference", Pr.Reference_Produit );
                    ReportParameter PQuantite = new ReportParameter("RPQuantite", Pr.Quantite_Produit);
                    ReportParameter PDes = new ReportParameter("RP_Désigna", Pr.Designation_Produit);
                    ReportParameter PRay = new ReportParameter("RPRay", Pr.Rayon_Produit);
                    // sauvegarder les nouveau parametre de rapport 
                    frmpt.RPAfichier.LocalReport.SetParameters(new ReportParameter[] { PID, PNom, PRef, PQuantite, PDes, PRay });
                    frmpt.RPAfichier.RefreshReport();
                    frmpt.ShowDialog(); // afficher formulaire de rapport



                }
            }
        }    
    }
}
