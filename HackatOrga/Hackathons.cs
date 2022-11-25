using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using HackatOrga.Models;

namespace HackatOrga
{
    public partial class Hackathons : Form
    {
        public Hackathons()
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

        private void btn_accueil2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil f = new Accueil();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void Hackathons_Load(object sender, EventArgs e)
        {
            //connexion à la BD
            hackatonsContext cnx = new hackatonsContext();
            dataGridHackathons.DataSource = cnx.Hackathons.ToList();  //dataGridHackathons est le nom de la grille
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            //connexion à la BD
            hackatonsContext cnx = new hackatonsContext();

            if (tb_ville.Text != "" && tb_rue.Text != "" && tb_cp.Text != "" && tb_lieu.Text != "" && tb_theme.Text != "" && tb_description.Text != "")
            {
                Hackathon newHackathon = new Hackathon();
                {
                    newHackathon.Datedebut = DateOnly.FromDateTime(dateTimePicker_dateDebut.Value);
                    newHackathon.Datefin = DateOnly.FromDateTime(dateTimePicker_dateFin.Value);
                    newHackathon.Datelimite = DateOnly.FromDateTime(dateTimePicker_dateDebut.Value).AddMonths(-1); //date début - 1 mois
                    newHackathon.Heuredebut = TimeOnly.FromDateTime(dateTimePicker_heureDebut.Value);
                    newHackathon.Heurefin = TimeOnly.FromDateTime(dateTimePicker_heureFin.Value);
                    newHackathon.Ville = tb_ville.Text;
                    newHackathon.Rue = tb_rue.Text;
                    newHackathon.Cp = tb_cp.Text;
                    newHackathon.Lieu = tb_lieu.Text;
                    newHackathon.Theme = tb_theme.Text;
                    newHackathon.Description = tb_description.Text;

                    bool isNumeric(string Nombre)
                    {
                        try
                        {
                            int.Parse(Nombre);
                            return true;
                        }
                        catch
                        {
                            return false;
                        }
                    }

                    if (tb_cp.Text.Length == 5)
                    {
                        if (isNumeric(tb_nbPlaces.Text) == true)
                        {
                            newHackathon.Nbplaces = (long)Convert.ToDouble(tb_nbPlaces.Text);

                            cnx.Hackathons.Add(newHackathon);
                            cnx.SaveChanges();

                            MessageBox.Show("Le hackathon a bien été ajouté");
                        }
                        else
                        {
                            MessageBox.Show("Veuillez insérer un bon nombre de place pour le hackathon");
                        }
                    } else
                    {
                        MessageBox.Show("Veuillez insérer un code postal au bon format");
                    }
                }
            } else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }

        
    }
}
