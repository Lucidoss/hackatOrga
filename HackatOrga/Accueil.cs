namespace HackatOrga
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }
        private void lbl_accueil_Click(object sender, EventArgs e)
        {

        }

        private void btn_hackathons_Click(object sender, EventArgs e)
        {
            this.Hide();
            Hackathons f = new Hackathons();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btn_atelier_Click(object sender, EventArgs e)
        {
            this.Hide();
            Atelier f = new Atelier();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void btn_conferences_Click(object sender, EventArgs e)
        {
            this.Hide();
            Conference f = new Conference();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}