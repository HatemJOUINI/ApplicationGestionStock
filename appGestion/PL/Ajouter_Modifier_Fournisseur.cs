using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using appGestion;

namespace appGestion
{
    public partial class Ajouter_Modifier_Fournisseur : Form

    {
        private DbStockContext db;
        private UserControl userFourni;
        public Ajouter_Modifier_Fournisseur(UserControl user)
        {
            InitializeComponent();
            db = new DbStockContext();
            this.userFourni = user;
        }
        // les champs obligatoire 
        string testobligatoire1()
        {
            if (txtNom.Text == "" || txtNom.Text == "Nom Fournisseur")
            {
                return "Entrer le Nom";
            }
            if (txtAdd.Text == "" || txtAdd.Text == "Addresse")
            {
                return "Entrer L'Addresse ";
            }
            if (txtTel.Text == "" || txtTel.Text == "Téléphone")
            {
                return "Entrer le numéro de téléphone";
            }
            return null;
        }
        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom de Fournisseur")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.White;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom Fournisseur";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtAdd_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Addresse")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.White;
            }
        }

        private void txtAdd_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Addresse";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtTel_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Téléphone")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.White;
            }
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Téléphone";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // text box numerique 
            if (e.KeyChar < 48 || e.KeyChar > 57) // code asci des numero 
            {
                e.Handled = true;

            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;

            }
        }

        private void Ajouter_Modifier_Fournisseur_Load(object sender, EventArgs e)
        {

        }

        private void btnEnreg_Click(object sender, EventArgs e)
        {


        }

        private void btnActua_Click(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            // vider les textBox 
            txtNom.Text = "Nom Fournisseur"; txtNom.ForeColor = Color.Silver;
            txtAdd.Text = "Addresse"; txtAdd.ForeColor = Color.Silver;
            txtTel.Text = "Téléphone"; txtTel.ForeColor = Color.Silver;
        }
        public int idSelect;
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoire1() != null)
            {
                MessageBox.Show(testobligatoire1(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                if (lbltitre.Text == "Ajouter Fournisseur")
                {
                    BL.CLS_Fournisseur clsFour = new BL.CLS_Fournisseur();
                    if (clsFour.Ajouter_Fournisseur(txtNom.Text, txtAdd.Text, txtTel.Text) == true)
                    {
                        MessageBox.Show("Fournisseur Ajouter avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userFourni as User_list_Fourn).Actualiserdatagrid1();
                    } else
                    {
                        MessageBox.Show("Nom et Addresse Fournisseur est deja existant ", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // si lbltitre=Modifier 
                {
                    BL.CLS_Fournisseur F_Four = new BL.CLS_Fournisseur();
                    User_list_Fourn user = new User_list_Fourn();
                    DialogResult R = MessageBox.Show("vous-voulez vraiment Modifier le Fournisseur", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        F_Four.Modifier_Fourni(idSelect, txtNom.Text, txtAdd.Text, txtTel.Text);

                        // pour actualiser datagridview 
                        (userFourni as User_list_Fourn).Actualiserdatagrid1();
                        MessageBox.Show("Fournisseur Modifier avec succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Modification est annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                }

            }
        }

    }
}

namespace PL
{
    class Ajouter_Modifier_Fournisseur
    {
        public Ajouter_Modifier_Fournisseur(User_list_Fourn user_list_Fourn)
        {
        }
    }
}
