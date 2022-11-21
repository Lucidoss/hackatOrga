namespace HackatOrga
{
    partial class Atelier
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
            this.btn_accueil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_accueil
            // 
            this.btn_accueil.Location = new System.Drawing.Point(0, 0);
            this.btn_accueil.Name = "btn_accueil";
            this.btn_accueil.Size = new System.Drawing.Size(75, 23);
            this.btn_accueil.TabIndex = 0;
            this.btn_accueil.Text = "button1";
            this.btn_accueil.UseVisualStyleBackColor = true;
            this.btn_accueil.Click += new System.EventHandler(this.btn_accueil_Click);
            // 
            // Atelier
            // 
            this.ClientSize = new System.Drawing.Size(723, 551);
            this.Controls.Add(this.btn_accueil);
            this.Name = "Atelier";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_accueil;
    }
}