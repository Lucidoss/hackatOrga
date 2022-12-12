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

        private void btn_accueil3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil f = new Accueil();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }

        private void Hackathons_Load(object sender, EventArgs e)
        {
            hackatonsContext cnx = new hackatonsContext(); // Connexion à la BD
            dataGridHackathons.DataSource = cnx.Hackathons.ToList();  // Charge la liste des hackathons
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            hackatonsContext cnx = new hackatonsContext(); // Connexion à la BD

            if (tb_ville_A.Text != "" && tb_rue_A.Text != "" && tb_cp_A.Text != "" && tb_lieu_A.Text != "" && tb_theme_A.Text != "" && tb_description_A.Text != "")
            {
                Hackathon newHackathon = new Hackathon();
                {
                    newHackathon.Datedebut = DateOnly.FromDateTime(dateTimePicker_dateDebut_A.Value);
                    newHackathon.Datefin = DateOnly.FromDateTime(dateTimePicker_dateFin_A.Value);
                    newHackathon.Datelimite = DateOnly.FromDateTime(dateTimePicker_dateDebut_A.Value).AddMonths(-1); //date début - 1 mois
                    newHackathon.Heuredebut = TimeOnly.FromDateTime(dateTimePicker_heureDebut_A.Value);
                    newHackathon.Heurefin = TimeOnly.FromDateTime(dateTimePicker_heureFin_A.Value);
                    newHackathon.Ville = tb_ville_A.Text;
                    newHackathon.Rue = tb_rue_A.Text;
                    newHackathon.Cp = tb_cp_A.Text;
                    newHackathon.Lieu = tb_lieu_A.Text;
                    newHackathon.Theme = tb_theme_A.Text;
                    newHackathon.Description = tb_description_A.Text;

                    bool isNumeric(string Nombre) // Fonction pour savoir si un la valeur entrée est numérique
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

                    if (isNumeric(tb_cp_A.Text) && tb_cp_A.Text.Length == 5)
                    {
                        if (isNumeric(tb_nbPlaces_A.Text) == true)
                        {
                            newHackathon.Nbplaces = (long)Convert.ToDouble(tb_nbPlaces_A.Text);

                            cnx.Hackathons.Add(newHackathon); // Ajoute la donnée dans la BDD
                            cnx.SaveChanges();

                            dataGridHackathons.DataSource = cnx.Hackathons.ToList(); // Actualise la liste des hackathons sur la page Lister les hackathons
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

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(pageModifier); // Permet d'aller sur la page du formulaire pour modifier

            //  Préremplie les dateTimePicker et les textBox avec les valeurs de la row sélectionné
            dateTimePicker_dateDebut_M.Value = DateTime.Parse(dataGridHackathons[1, dataGridHackathons.CurrentRow.Index].Value.ToString());
            dateTimePicker_dateFin_M.Value = DateTime.Parse(dataGridHackathons[2, dataGridHackathons.CurrentRow.Index].Value.ToString());
            dateTimePicker_heureDebut_M.Value = DateTime.Parse(dataGridHackathons[3, dataGridHackathons.CurrentRow.Index].Value.ToString());
            dateTimePicker_heureFin_M.Value = DateTime.Parse(dataGridHackathons[4, dataGridHackathons.CurrentRow.Index].Value.ToString());
            tb_lieu_M.Text = dataGridHackathons[5, dataGridHackathons.CurrentRow.Index].Value.ToString();
            tb_rue_M.Text = dataGridHackathons[6, dataGridHackathons.CurrentRow.Index].Value.ToString();
            tb_ville_M.Text = dataGridHackathons[7, dataGridHackathons.CurrentRow.Index].Value.ToString();
            tb_cp_M.Text = dataGridHackathons[8, dataGridHackathons.CurrentRow.Index].Value.ToString();
            tb_theme_M.Text = dataGridHackathons[9, dataGridHackathons.CurrentRow.Index].Value.ToString();
            tb_description_M.Text = dataGridHackathons[10, dataGridHackathons.CurrentRow.Index].Value.ToString();
            tb_nbPlaces_M.Text = dataGridHackathons[13, dataGridHackathons.CurrentRow.Index].Value.ToString();
        }

        private void btn_validerModification_Click(object sender, EventArgs e)
        {
            hackatonsContext cnx = new hackatonsContext(); // Connexion à la BD

            if (tb_ville_M.Text != "" && tb_rue_M.Text != "" && tb_cp_M.Text != "" && tb_lieu_M.Text != "" && tb_theme_M.Text != "" && tb_description_M.Text != "")
            {
                int id = Int32.Parse(dataGridHackathons[0, dataGridHackathons.CurrentRow.Index].Value.ToString());
                MessageBox.Show("id : " + id);
                Hackathon updateHackathon = cnx.Hackathons.Find(id);
                {
                    updateHackathon.Datedebut = DateOnly.FromDateTime(dateTimePicker_dateDebut_M.Value);
                    updateHackathon.Datefin = DateOnly.FromDateTime(dateTimePicker_dateFin_M.Value);
                    updateHackathon.Datelimite = DateOnly.FromDateTime(dateTimePicker_dateDebut_M.Value).AddMonths(-1); //date début - 1 mois
                    updateHackathon.Heuredebut = TimeOnly.FromDateTime(dateTimePicker_heureDebut_M.Value);
                    updateHackathon.Heurefin = TimeOnly.FromDateTime(dateTimePicker_heureFin_M.Value);
                    updateHackathon.Ville = tb_ville_M.Text;
                    updateHackathon.Rue = tb_rue_M.Text;
                    updateHackathon.Cp = tb_cp_M.Text;
                    updateHackathon.Lieu = tb_lieu_M.Text;
                    updateHackathon.Theme = tb_theme_M.Text;
                    updateHackathon.Description = tb_description_M.Text;

                    bool isNumeric(string Nombre) // Fonction pour savoir si un la valeur entrée est numérique
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

                    if (isNumeric(tb_cp_M.Text) && tb_cp_M.Text.Length == 5)
                    {
                        if (isNumeric(tb_nbPlaces_M.Text) == true)
                        {
                            updateHackathon.Nbplaces = (long)Convert.ToDouble(tb_nbPlaces_M.Text);

                            cnx.Hackathons.Update(updateHackathon); // Ajoute la donnée dans la BDD
                            cnx.SaveChanges();

                            dataGridHackathons.DataSource = cnx.Hackathons.ToList(); // Actualise la liste des hackathons sur la page Lister les hackathons
                            MessageBox.Show("Le hackathon a bien été modifié");
                        }
                        else
                        {
                            MessageBox.Show("Veuillez insérer un bon nombre de place pour le hackathon");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Veuillez insérer un code postal au bon format");
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs");
            }
        }
    }
}
