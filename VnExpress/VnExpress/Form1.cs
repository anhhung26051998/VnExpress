using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VnExpress
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

      
        }
        public void showhidePanel()
        {
            panelNews.Visible = false;
            pannelWorld.Visible = false;
            panelBussines.Visible = false;
            panelEntertainment.Visible = false;
            panelEsport.Visible = false;
            panelLaw.Visible = false;
            panelHealth.Visible = false;
            panelLife.Visible = false;
            panelScience.Visible = false;

        }

        private void btnNews_MouseHover(object sender, EventArgs e)
        {
            showhidePanel();
            panelNews.Visible = true;
        }

        private void btnWorld_MouseHover(object sender, EventArgs e)
        {
            showhidePanel();
            pannelWorld.Visible = true;
        }

        private void btnBussines_MouseHover(object sender, EventArgs e)
        {
            showhidePanel();
            panelBussines.Visible = true;
        }

        private void btnEntertainment_MouseHover(object sender, EventArgs e)
        {
            showhidePanel();
            panelEntertainment.Visible = true;
        }

        private void btnEsport_MouseHover(object sender, EventArgs e)
        {
            showhidePanel();
            panelEsport.Visible = true;
        }

        private void btnLaw_MouseHover(object sender, EventArgs e)
        {

            showhidePanel();
            panelLaw.Visible = true;
        }

        private void btnStrong_MouseHover(object sender, EventArgs e)
        {
            showhidePanel();
            panelHealth.Visible = true;
        }

        private void btnLife_MouseHover(object sender, EventArgs e)
        {
            showhidePanel();
            panelLife.Visible = true;
        }

        private void btnScienc_MouseHover(object sender, EventArgs e)
        {
            showhidePanel();
            panelScience.Visible = true;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            showhidePanel();
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            showhidePanel();
        }

        private void panelHome_MouseHover(object sender, EventArgs e)
        {
            showhidePanel();
        }

        private void tableLayoutPanel4_MouseHover(object sender, EventArgs e)
        {

            showhidePanel();
            

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }
    }
}
