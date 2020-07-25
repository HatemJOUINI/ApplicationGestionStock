using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appGestion.PL
{
    public partial class User_list_Client : UserControl
    {
        private static User_list_Client UserClient;
        private DbStockContext db;
        // creé un instance pour le user control 
        public static User_list_Client Instance
        {
            get
            {
                if (UserClient == null)
                {
                    UserClient = new User_list_Client();
                }
                return UserClient;
            }
        }
        public User_list_Client()
        {
            InitializeComponent();
            db = new DbStockContext();
        }
        public void Actualiserdatagrid2()
        {
            db = new DbStockContext();
            dvgclient.Rows.Clear(); // vider datagrid view 
            foreach (var S in db.Clients)
            {
                // Ajouter des lignes dans data grid view 
                dvgclient.Rows.Add(false, S.ID_Client, S.Nom_Client, S.Adresse_Client, S.Téléphone_Client);

            }
        }
        public string SelectVerif()
        {
            int nombreligneSelect = 0;
            for (int i = 0; i < dvgclient.Rows.Count; i++)
            {
                if ((bool)dvgclient.Rows[i].Cells[0].Value == true) // si la ligne est selectionner 
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
        private void btnajout_Click(object sender, EventArgs e)
        {
            FRM_Ajouter_Modifier_Client fournisseur = new FRM_Ajouter_Modifier_Client(this);
            fournisseur.ShowDialog();
        }
       

        private void btnmodifierclient_Click(object sender, EventArgs e)
        { 
            FRM_Ajouter_Modifier_Client frm = new FRM_Ajouter_Modifier_Client(this);
            if (SelectVerif() == null)
            {
                for (int i = 0; i < dvgclient.Rows.Count; i++)
                {
                    if ((bool)dvgclient.Rows[i].Cells[0].Value == true) // si le checkBox est vrai affichier les informations dans le formulaire Client 
                    {
                        frm.idSelect = (int)dvgclient.Rows[i].Cells[1].Value;
                        frm.txtNom.Text = dvgclient.Rows[i].Cells[2].Value.ToString();
                        frm.txtAdd.Text = dvgclient.Rows[i].Cells[3].Value.ToString();
                        frm.txtTel.Text = dvgclient.Rows[i].Cells[4].Value.ToString();

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

        private void btnsuppClient_Click(object sender, EventArgs e)
        {
            BL.CLS_Client Client = new BL.CLS_Client();
            // pour supprimer tous les Produit Selectionner 
            int select = 0;
            for (int i = 0; i < dvgclient.Rows.Count; i++)
            {
                if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                {
                    select++; // Combien de ligne Selectionnez 
                }
            }
            if (select == 0)
            {
                MessageBox.Show("Aucun Client Selectionner", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                DialogResult R =

                     MessageBox.Show("Vous-Voulez vraiment Supprimer", "Suppresion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    //  pour supprimer Produit selectionner
                    for (int i = 0; i < dvgclient.Rows.Count; i++)
                    {
                        if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                        {
                            Client.suprimer_Client(int.Parse(dvgclient.Rows[i].Cells[1].Value.ToString())); // id Produit 
                        }
                    }
                    // actualiser datagridview 
                    Actualiserdatagrid2();

                    MessageBox.Show("Supression avec succées", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Supression est annulé ", "Suppresion", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        }

        private void User_list_Client_Load(object sender, EventArgs e)
        {
            Actualiserdatagrid2();

        }
    }
}
