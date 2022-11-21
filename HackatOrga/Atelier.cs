using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HackatOrga
{
    public partial class Atelier : Form
    {
        public Atelier()
        {
            InitializeComponent();
        }

        private void btn_accueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil f = new Accueil();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
