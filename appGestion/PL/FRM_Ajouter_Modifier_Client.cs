using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appGestion.PL
{
    public partial class FRM_Ajouter_Modifier_Client : Form
    {
        private DbStockContext db;
        private UserControl userClient;
        public FRM_Ajouter_Modifier_Client(UserControl user)
        {
            InitializeComponent();
            db = new DbStockContext();
            this.userClient = user;
        }
        // les champs obligatoire 
        string testobligatoire2()
        {
            if (txtNom.Text == "" || txtNom.Text == "Nom Client")
            {
                return "Entrer le Nom";
            }
            if (txtAdd.Text == "" || txtAdd.Text == "Adresse")
            {
                return "Entrer L'Adresse ";
            }
            if (txtTel.Text == "" || txtTel.Text == "Telephone")
            {
                return "Entrer le numéro de téléphone";
            }
            return null;
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Nom Client")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.Black;
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom Client";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtAdd_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Adresse";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtAdd_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Adresse")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.Black;
            }
        }

        private void txtTel_Enter(object sender, EventArgs e)
        {
            if (txtNom.Text == "Telephone")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.Black;
            }
        }

        private void txtTel_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Telephone";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            // control de saisie : textBox numeric 
            if (e.KeyChar < 48 || e.KeyChar > 58) // le code asci de numéro 
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        public int idSelect;

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (testobligatoire2() != null)
            {
                MessageBox.Show(testobligatoire2(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (lbltitre.Text == "Ajouter Client")
                {
                    BL.CLS_Client clsFour = new BL.CLS_Client();
                    if (clsFour.Ajouter_Client(txtNom.Text, txtAdd.Text, txtTel.Text) == true)
                    {
                        MessageBox.Show("Client Ajouter avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userClient as User_list_Client).Actualiserdatagrid2();
                    }
                    else
                    {
                        MessageBox.Show("Nom  est deja existant ", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else // si lbltitre=Modifier 
                {
                    BL.CLS_Client F_Four = new BL.CLS_Client();
                    User_list_Client user = new User_list_Client();
                    DialogResult R = MessageBox.Show("vous-voulez vraiment Modifier le Client", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (R == DialogResult.Yes)
                    {
                        F_Four.Modifier_Client(idSelect, txtNom.Text, txtAdd.Text, txtTel.Text);

                        // pour actualiser datagridview 
                        (userClient as User_list_Client).Actualiserdatagrid2();
                        MessageBox.Show("Fournisseur Modifier avec succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Modification est annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }



                }

            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            // vider les textBox 
            txtNom.Text = "Nom Client"; txtNom.ForeColor = Color.Silver;
            txtAdd.Text = "Adresse"; txtAdd.ForeColor = Color.Silver;
            txtTel.Text = "Telephone"; txtTel.ForeColor = Color.Silver;
        }
    }
}
