using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace GeoTema_App
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            panelAdmin.Visible = false;
            panelDashboard.Visible = true;
        }

        private void LogIndKnap_Click(object sender, EventArgs e)
        {
            if (BrugernavnBox.Text == "Administrator" && KodeordBox.Text == "Passw0rd!")
            {


                panelAdmin.Visible = true;


            }
            else if (BrugernavnBox.Text == "Superbruger" && KodeordBox.Text == "Passw0rd!")
            {



            }
            else if (BrugernavnBox.Text == "Standardbruger" && KodeordBox.Text == "Passw0rd!")
            {



            }
            else
            {
                MessageBox.Show("Forkert brugernavn eller kodeord - prøv igen!");
            }
        }
    }
}
