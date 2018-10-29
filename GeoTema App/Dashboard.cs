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

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {


            if (BrugernavnBox.Text == "Administrator" && KodeordBox.Text == "Passw0rd!")
            {


                this.Hide();
                Form AdminMenu = new Form();
                AdminMenu.Show();
            }
            else if (BrugernavnBox.Text == "Superbruger" && KodeordBox.Text == "Passw0rd!")
            {


                this.Hide();
                Form SuperbrugerMenu = new Form();
                SuperbrugerMenu.Show();
            }
            else if (BrugernavnBox.Text == "Standardbruger" && KodeordBox.Text == "Passw0rd!")
            {


                this.Hide();
                Form StandardbrugerMenu = new Form();
                StandardbrugerMenu.Show();
            }
            else
            {
                MessageBox.Show("Forkert brugernavn eller kodeord - prøv igen!");
            }

        }
    }
}
