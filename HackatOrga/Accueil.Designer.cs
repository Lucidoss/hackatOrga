﻿namespace HackatOrga
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_accueil = new System.Windows.Forms.Label();
            this.btn_conferences = new System.Windows.Forms.Button();
            this.btn_hackathons = new System.Windows.Forms.Button();
            this.btn_atelier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // lbl_accueil
            // 
            this.lbl_accueil.AutoSize = true;
            this.lbl_accueil.Font = new System.Drawing.Font("Amiri Quran", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_accueil.Location = new System.Drawing.Point(402, 99);
            this.lbl_accueil.Name = "lbl_accueil";
            this.lbl_accueil.Size = new System.Drawing.Size(289, 113);
            this.lbl_accueil.TabIndex = 0;
            this.lbl_accueil.Text = "Accueil";
            // 
            // btn_conferences
            // 
            this.btn_conferences.Font = new System.Drawing.Font("DejaVu Sans Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_conferences.Location = new System.Drawing.Point(696, 289);
            this.btn_conferences.Name = "btn_conferences";
            this.btn_conferences.Size = new System.Drawing.Size(246, 78);
            this.btn_conferences.TabIndex = 3;
            this.btn_conferences.Text = "Acceder aux conférences";
            this.btn_conferences.UseVisualStyleBackColor = true;
            // 
            // btn_hackathons
            // 
            this.btn_hackathons.Font = new System.Drawing.Font("DejaVu Sans Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_hackathons.Location = new System.Drawing.Point(131, 289);
            this.btn_hackathons.Name = "btn_hackathons";
            this.btn_hackathons.Size = new System.Drawing.Size(246, 78);
            this.btn_hackathons.TabIndex = 4;
            this.btn_hackathons.Text = "Acceder aux hackathons";
            this.btn_hackathons.UseVisualStyleBackColor = true;
            // 
            // btn_atelier
            // 
            this.btn_atelier.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_atelier.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_atelier.FlatAppearance.BorderSize = 10;
            this.btn_atelier.Font = new System.Drawing.Font("DejaVu Sans Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_atelier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_atelier.Location = new System.Drawing.Point(417, 289);
            this.btn_atelier.Name = "btn_atelier";
            this.btn_atelier.Size = new System.Drawing.Size(246, 78);
            this.btn_atelier.TabIndex = 5;
            this.btn_atelier.Text = "Acceder aux Atelier";
            this.btn_atelier.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1040, 622);
            this.Controls.Add(this.btn_atelier);
            this.Controls.Add(this.btn_hackathons);
            this.Controls.Add(this.btn_conferences);
            this.Controls.Add(this.lbl_accueil);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lbl_accueil;
        private Button btn_conferences;
        private Button btn_hackathons;
        private Button btn_atelier;
    }
}