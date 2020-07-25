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
    public partial class FRM_Conn : Form
    {
        private DbStockContext db;
      //  private Form frmmenu;
        // classe Connexion 
        CLS_Connexion C = new CLS_Connexion(); 
        public FRM_Conn()
        {
            InitializeComponent();
          //  this.frmmenu = menu;
            // inisialiser Base de donneé
            db = new DbStockContext();
        }

        // pour verifier les champ obligatoires 
        string testobligatoire()
        {
            if (txtNom.Text == " " || txtNom.Text == "Nom d'utilisateur") // si le nom d'utilisateur est vide ou le text de textbox est le nom d'utilisateur
            {
                return "Entrer votre Nom ";
            }
            if (txtMotdePasse.Text == "" || txtMotdePasse.Text == "Mot de Passe")
            {
                return " Entrer votre Mot de Passe";
            }
            // si l'utilisateur est entrer son nom et son mot de passe 
            return null;
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            // pour vider le textBox
            if (txtNom.Text == "Nom d'utilisateur")
            {
                txtNom.Text = "";
                txtNom.ForeColor = Color.Black; // changer couleur de text
            }
        }

        private void txtMotdePasse_Enter(object sender, EventArgs e)
        {
            // pour vider le textBox
            if (txtMotdePasse.Text == "Mot de Passe")
            {
                txtMotdePasse.Text = "";
                txtMotdePasse.UseSystemPasswordChar = false;
                txtMotdePasse.PasswordChar = '*';
                txtMotdePasse.ForeColor = Color.Black; // changer couleur de text
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if (txtNom.Text == "")
            {
                txtNom.Text = "Nom d'utilisateur";
                txtNom.ForeColor = Color.Silver;
            }
        }

        private void txtMotdePasse_Leave(object sender, EventArgs e)
        {

            if (txtNom.Text == "")
            {
                txtMotdePasse.Text = "Mot de Passe";
                txtMotdePasse.UseSystemPasswordChar = true; // desactivier passwordchar
                txtMotdePasse.ForeColor = Color.Silver;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (testobligatoire() == null)
            {
                if (C.ConnexionValide(db, txtNom.Text, txtMotdePasse.Text) == true) // utilisateur existe 
                {
                    MessageBox.Show("Connexion a réussi", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close();
                    FRM_Menu frm = new FRM_Menu();
                    frm.ShowDialog();
                    //FRM_Ajouter_Modifier_Produit frm = new FRM_Ajouter_Modifier_Produit();
                    //frm.ShowDialog();
                }
                else // false n'existe pas 
                {
                    MessageBox.Show("Connexion a échoué ", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show(testobligatoire(), "obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRM_Conn_Load(object sender, EventArgs e)
        {

        }
    }
}
