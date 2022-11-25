namespace HackatOrga
{
    partial class Hackathons
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hackathons));
            this.btn_accueil = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridHackathons = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker_dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dateDebut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_heureFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_heureDebut = new System.Windows.Forms.DateTimePicker();
            this.tb_nbPlaces = new System.Windows.Forms.TextBox();
            this.tb_description = new System.Windows.Forms.TextBox();
            this.tb_theme = new System.Windows.Forms.TextBox();
            this.tb_lieu = new System.Windows.Forms.TextBox();
            this.tb_cp = new System.Windows.Forms.TextBox();
            this.tb_rue = new System.Windows.Forms.TextBox();
            this.tb_ville = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_accueil2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHackathons)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_accueil
            // 
            this.btn_accueil.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_accueil.Font = new System.Drawing.Font("DejaVu Sans Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_accueil.Location = new System.Drawing.Point(0, 0);
            this.btn_accueil.Name = "btn_accueil";
            this.btn_accueil.Size = new System.Drawing.Size(96, 35);
            this.btn_accueil.TabIndex = 0;
            this.btn_accueil.Text = "Accueil";
            this.btn_accueil.UseVisualStyleBackColor = false;
            this.btn_accueil.Click += new System.EventHandler(this.btn_accueil_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1044, 671);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridHackathons
            // 
            this.dataGridHackathons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHackathons.Location = new System.Drawing.Point(93, 217);
            this.dataGridHackathons.Name = "dataGridHackathons";
            this.dataGridHackathons.RowTemplate.Height = 25;
            this.dataGridHackathons.Size = new System.Drawing.Size(561, 187);
            this.dataGridHackathons.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1030, 589);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_accueil);
            this.tabPage1.Controls.Add(this.dataGridHackathons);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1022, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateTimePicker_dateFin);
            this.tabPage2.Controls.Add(this.dateTimePicker_dateDebut);
            this.tabPage2.Controls.Add(this.dateTimePicker_heureFin);
            this.tabPage2.Controls.Add(this.dateTimePicker_heureDebut);
            this.tabPage2.Controls.Add(this.tb_nbPlaces);
            this.tabPage2.Controls.Add(this.tb_description);
            this.tabPage2.Controls.Add(this.tb_theme);
            this.tabPage2.Controls.Add(this.tb_lieu);
            this.tabPage2.Controls.Add(this.tb_cp);
            this.tabPage2.Controls.Add(this.tb_rue);
            this.tabPage2.Controls.Add(this.tb_ville);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_ajouter);
            this.tabPage2.Controls.Add(this.btn_accueil2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1022, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker_dateFin
            // 
            this.dateTimePicker_dateFin.Location = new System.Drawing.Point(592, 81);
            this.dateTimePicker_dateFin.Name = "dateTimePicker_dateFin";
            this.dateTimePicker_dateFin.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_dateFin.TabIndex = 39;
            // 
            // dateTimePicker_dateDebut
            // 
            this.dateTimePicker_dateDebut.Location = new System.Drawing.Point(131, 81);
            this.dateTimePicker_dateDebut.Name = "dateTimePicker_dateDebut";
            this.dateTimePicker_dateDebut.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_dateDebut.TabIndex = 38;
            // 
            // dateTimePicker_heureFin
            // 
            this.dateTimePicker_heureFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_heureFin.Location = new System.Drawing.Point(598, 134);
            this.dateTimePicker_heureFin.Name = "dateTimePicker_heureFin";
            this.dateTimePicker_heureFin.ShowUpDown = true;
            this.dateTimePicker_heureFin.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_heureFin.TabIndex = 37;
            this.dateTimePicker_heureFin.Value = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            // 
            // dateTimePicker_heureDebut
            // 
            this.dateTimePicker_heureDebut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker_heureDebut.Location = new System.Drawing.Point(139, 134);
            this.dateTimePicker_heureDebut.Name = "dateTimePicker_heureDebut";
            this.dateTimePicker_heureDebut.ShowUpDown = true;
            this.dateTimePicker_heureDebut.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker_heureDebut.TabIndex = 36;
            this.dateTimePicker_heureDebut.Value = new System.DateTime(2022, 11, 21, 0, 0, 0, 0);
            // 
            // tb_nbPlaces
            // 
            this.tb_nbPlaces.Location = new System.Drawing.Point(169, 417);
            this.tb_nbPlaces.Name = "tb_nbPlaces";
            this.tb_nbPlaces.Size = new System.Drawing.Size(100, 23);
            this.tb_nbPlaces.TabIndex = 30;
            // 
            // tb_description
            // 
            this.tb_description.AcceptsReturn = true;
            this.tb_description.Location = new System.Drawing.Point(458, 295);
            this.tb_description.MaxLength = 255;
            this.tb_description.Multiline = true;
            this.tb_description.Name = "tb_description";
            this.tb_description.Size = new System.Drawing.Size(401, 129);
            this.tb_description.TabIndex = 29;
            // 
            // tb_theme
            // 
            this.tb_theme.AcceptsReturn = true;
            this.tb_theme.Location = new System.Drawing.Point(458, 194);
            this.tb_theme.MaxLength = 255;
            this.tb_theme.Multiline = true;
            this.tb_theme.Name = "tb_theme";
            this.tb_theme.Size = new System.Drawing.Size(401, 78);
            this.tb_theme.TabIndex = 28;
            // 
            // tb_lieu
            // 
            this.tb_lieu.Location = new System.Drawing.Point(131, 342);
            this.tb_lieu.MaxLength = 255;
            this.tb_lieu.Name = "tb_lieu";
            this.tb_lieu.Size = new System.Drawing.Size(100, 23);
            this.tb_lieu.TabIndex = 27;
            // 
            // tb_cp
            // 
            this.tb_cp.Location = new System.Drawing.Point(131, 295);
            this.tb_cp.MaxLength = 5;
            this.tb_cp.Name = "tb_cp";
            this.tb_cp.Size = new System.Drawing.Size(100, 23);
            this.tb_cp.TabIndex = 26;
            // 
            // tb_rue
            // 
            this.tb_rue.Location = new System.Drawing.Point(131, 251);
            this.tb_rue.MaxLength = 255;
            this.tb_rue.Name = "tb_rue";
            this.tb_rue.Size = new System.Drawing.Size(100, 23);
            this.tb_rue.TabIndex = 25;
            // 
            // tb_ville
            // 
            this.tb_ville.Location = new System.Drawing.Point(131, 205);
            this.tb_ville.MaxLength = 255;
            this.tb_ville.Name = "tb_ville";
            this.tb_ville.Size = new System.Drawing.Size(100, 23);
            this.tb_ville.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(60, 420);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 15);
            this.label12.TabIndex = 23;
            this.label12.Text = "Nombre de places";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(385, 298);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Description";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(409, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Thème";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "CP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Rue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Lieu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Heure fin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Heure début";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Date fin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Date début";
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(355, 474);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(199, 46);
            this.btn_ajouter.TabIndex = 11;
            this.btn_ajouter.Text = "Ajouter un hackathon";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_accueil2
            // 
            this.btn_accueil2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_accueil2.Font = new System.Drawing.Font("DejaVu Sans Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_accueil2.Location = new System.Drawing.Point(0, 0);
            this.btn_accueil2.Name = "btn_accueil2";
            this.btn_accueil2.Size = new System.Drawing.Size(96, 35);
            this.btn_accueil2.TabIndex = 1;
            this.btn_accueil2.Text = "Accueil";
            this.btn_accueil2.UseVisualStyleBackColor = false;
            this.btn_accueil2.Click += new System.EventHandler(this.btn_accueil2_Click);
            // 
            // Hackathons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 585);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Hackathons";
            this.Text = "Hackathons";
            this.Load += new System.EventHandler(this.Hackathons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHackathons)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_accueil;
        private PictureBox pictureBox1;
        private DataGridView dataGridHackathons;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btn_accueil2;
        private Button btn_ajouter;
        private Label label12;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox tb_ville;
        private TextBox tb_nbPlaces;
        private TextBox tb_description;
        private TextBox tb_theme;
        private TextBox tb_lieu;
        private TextBox tb_cp;
        private TextBox tb_rue;
        private DateTimePicker dateTimePicker_heureFin;
        private DateTimePicker dateTimePicker_heureDebut;
        private DateTimePicker dateTimePicker_dateDebut;
        private DateTimePicker dateTimePicker_dateFin;
    }
}