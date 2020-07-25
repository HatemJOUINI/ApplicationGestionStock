using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appGestion
{
    public partial class FRM_Ajouter_Modifier_Produit : Form
    {
        private UserControl usrProduit;
        public FRM_Ajouter_Modifier_Produit(UserControl userP)
        {
            InitializeComponent();
            this.usrProduit = userP;
        }
        // les champs obligatoire 
        string testobligatoire ()
        { 
            if (txtNom.Text==""|| txtNom.Text=="Nom Produit" )
            {
                return "Entrer le Nom";
            }
            if (txtRef.Text == "" || txtRef.Text == "Référence ")
            {
                return "Entrer Référence ";
            }
            if (txtQantite.Text == "" || txtQantite.Text == "Quantité")
            {
                return "Entrer Quantité";
            }
            if (txtRay.Text == "" || txtRay.Text == "Rayonnage")
            {
                return "Entrer num Rayon";
            }
            
            return null;
        }
        private void txtNom_Enter(object sender, EventArgs e)
        {
            if(txtNom.Text== "Nom Produit")
            {
                txtNom.Text = "";
                txtNom.ForeColor=Color.Black;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom Produit";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close(); // quitter Formulaire 
        }

        private void txtRef_Enter(object sender, EventArgs e)
        {
            if (txtRef.Text == "Référence")
            {
                txtRef.Text = "";
                txtRef.ForeColor = Color.Black;
            }
        }

        private void txtRef_Leave(object sender, EventArgs e)
        {
            if (txtRef.Text == "")
            {
                txtRef.Text = "Référence";
                txtRef.ForeColor = Color.Silver;
            }
        }

        private void txtQantite_Enter(object sender, EventArgs e)
        {
            if (txtQantite.Text == "Quantité")
            {
                txtQantite.Text = "";
                txtQantite.ForeColor = Color.Black;
            }
        }

        private void txtQantite_Leave(object sender, EventArgs e)
        {
            if (txtQantite.Text == "")
            {
                txtQantite.Text = "Quantité";
                txtQantite.ForeColor = Color.Silver;
            }
        }

        private void txtRay_Enter(object sender, EventArgs e)
        {

            if (txtRay.Text == "Rayonnage")
            {
                txtRay.Text = "";
                txtRay.ForeColor = Color.Black;
            }
        }

        private void txtRay_Leave(object sender, EventArgs e)
        {
            if (txtRay.Text == "")
            {
                txtRay.Text = "Rayonnage";
                txtRay.ForeColor = Color.Silver;
            }
        }

        private void txtDes_Enter(object sender, EventArgs e)
        {
            if (txtDes.Text == "Désignation")
            {
                txtDes.Text = "";
                txtDes.ForeColor = Color.Black;
            }
        }

        private void txtDes_Leave(object sender, EventArgs e)
        {
            if (txtDes.Text == "")
            {
                txtDes.Text = "Désignation";
                txtDes.ForeColor = Color.Silver;
            }
        }

        private void txtQantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            // control de saisie : textBox numeric 
            if (e.KeyChar<48 || e.KeyChar>58) // le code asci de numéro 
            {
                e.Handled = true; 
            }
            if (e.KeyChar==8)
            {
                e.Handled = false; 
            }
        }

     
        public int idSelect;

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if(testobligatoire()!=null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire" , MessageBoxButtons.OK,MessageBoxIcon.Error);
            } else
            if (lbltitre.Text=="Ajouter Produit")
            {
                CLS_Produit P_Produit = new CLS_Produit();
                if (P_Produit.Ajouter_Produit(txtNom.Text, txtRef.Text, txtQantite.Text, txtRay.Text, txtDes.Text) == true)
                {
                    MessageBox.Show("Produit Ajouter avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (usrProduit as User_liste_Produit).Actualiserdatagrid();
                } else
                {
                    MessageBox.Show("Nom et Reference de Produit est deja existant ", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            } else // si lbltitre=Modifier 
            {
              CLS_Produit P_Produit = new CLS_Produit();
                User_liste_Produit user = new User_liste_Produit();
                DialogResult R = MessageBox.Show("vous-voulez vraiment Modifier le Produit", "Modification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (R==DialogResult.Yes)
                {
                    P_Produit.Modifier_Produit(idSelect, txtNom.Text, txtRef.Text, txtQantite.Text, txtRay.Text, txtDes.Text);

                    // pour actualiser datagridview 
                    (usrProduit as User_liste_Produit).Actualiserdatagrid();
                    MessageBox.Show("Produit Modifier avec succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                } else
                {
                    MessageBox.Show("Modification est annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
             


            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            // vider les textBox 
            txtNom.Text = "Nom Produit"; txtNom.ForeColor = Color.Silver;
            txtRef.Text = "Référence "; txtRef.ForeColor = Color.Silver;
            txtQantite.Text ="Quantité"; txtQantite.ForeColor = Color.Silver;
            txtRay.Text = "Rayonnage"; txtRay.ForeColor = Color.Silver;
            txtDes.Text = "Désignation"; txtDes.ForeColor = Color.Silver;

        }

        private void txtQantite_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRay_TextChanged(object sender, EventArgs e)
        {
            if (txtRay.Text != "")
            {
                try
                {
                    int a = Convert.ToInt32(txtRay.Text);
                    if (a > 64)
                    {
                        MessageBox.Show("Entre un nombre moins que 192", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRay.Text = "";
                    }
                }
                catch (Exception)
                {
                    //MessageBox.Show("Error");
                }
            }
        }
    }
}
