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
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(237, 522);
            panelParametre.Visible = false;

        }
        // désactivier Formulaire 
        
        // activier Formulaire 
       

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnProduit_Click(object sender, EventArgs e)
        {
            if (!pnlaficher.Controls.Contains(User_liste_Produit.Instance))
            {
                pnlaficher.Controls.Add(User_liste_Produit.Instance);
                User_liste_Produit.Instance.Dock = DockStyle.Fill;
                User_liste_Produit.Instance.BringToFront();
                
            } else
            {
                User_liste_Produit.Instance.BringToFront();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!pnlaficher.Controls.Contains(User_list_Fourn.Instance))
            {
                pnlaficher.Controls.Add(User_list_Fourn.Instance);
                User_list_Fourn.Instance.Dock = DockStyle.Fill;
                User_list_Fourn.Instance.BringToFront();

            }
            else
            {
                User_list_Fourn.Instance.BringToFront();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            if(panel1.Width ==237)
            {
                panel1.Size = new Size(72, 522); // 237; 124
            } else
            {
                panel1.Size = new Size(237, 522);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelParametre.Size = new Size(237, 124);
            panelParametre.Visible = !panelParametre.Visible;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            panelParametre.Size = new Size(237, 124);
            panelParametre.Visible = !panelParametre.Visible;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // afficher formulaire de connexion 
            FRM_Conn frmC = new FRM_Conn();
            frmC.ShowDialog();

        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {
        }

        private void btnClient_Click(object sender, EventArgs e)
        {

            if (!pnlaficher.Controls.Contains(PL.User_list_Client.Instance))
            {
                pnlaficher.Controls.Add(PL.User_list_Client.Instance);
                PL.User_list_Client.Instance.Dock = DockStyle.Fill;
                PL.User_list_Client.Instance.BringToFront();

            }
            else
            {
                PL.User_list_Client.Instance.BringToFront();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
          
        }
    }
}
