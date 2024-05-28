
namespace jpo
{
    partial class frmInscriptionMembres
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.lbNActivite = new System.Windows.Forms.Label();
            this.lbNCreneau = new System.Windows.Forms.Label();
            this.lbNMembre = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxMembreNonInscris = new System.Windows.Forms.ComboBox();
            this.cbxCreneau = new System.Windows.Forms.ComboBox();
            this.cbxActivite = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.dvgInscriptions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgInscriptions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Inscription membres";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(421, 263);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(308, 263);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 25);
            this.btnModify.TabIndex = 29;
            this.btnModify.Text = "Modifier";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // lbNActivite
            // 
            this.lbNActivite.AutoSize = true;
            this.lbNActivite.Location = new System.Drawing.Point(305, 215);
            this.lbNActivite.Name = "lbNActivite";
            this.lbNActivite.Size = new System.Drawing.Size(42, 13);
            this.lbNActivite.TabIndex = 21;
            this.lbNActivite.Text = "Activité";
            // 
            // lbNCreneau
            // 
            this.lbNCreneau.AutoSize = true;
            this.lbNCreneau.Location = new System.Drawing.Point(305, 175);
            this.lbNCreneau.Name = "lbNCreneau";
            this.lbNCreneau.Size = new System.Drawing.Size(50, 13);
            this.lbNCreneau.TabIndex = 20;
            this.lbNCreneau.Text = "Créneau:";
            // 
            // lbNMembre
            // 
            this.lbNMembre.AutoSize = true;
            this.lbNMembre.Location = new System.Drawing.Point(243, 136);
            this.lbNMembre.Name = "lbNMembre";
            this.lbNMembre.Size = new System.Drawing.Size(112, 13);
            this.lbNMembre.TabIndex = 19;
            this.lbNMembre.Text = "Membre(s) non inscris:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 353);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxMembreNonInscris
            // 
            this.cbxMembreNonInscris.FormattingEnabled = true;
            this.cbxMembreNonInscris.Location = new System.Drawing.Point(375, 133);
            this.cbxMembreNonInscris.Name = "cbxMembreNonInscris";
            this.cbxMembreNonInscris.Size = new System.Drawing.Size(120, 21);
            this.cbxMembreNonInscris.TabIndex = 31;
            // 
            // cbxCreneau
            // 
            this.cbxCreneau.FormattingEnabled = true;
            this.cbxCreneau.Location = new System.Drawing.Point(375, 172);
            this.cbxCreneau.Name = "cbxCreneau";
            this.cbxCreneau.Size = new System.Drawing.Size(121, 21);
            this.cbxCreneau.TabIndex = 32;
            // 
            // cbxActivite
            // 
            this.cbxActivite.FormattingEnabled = true;
            this.cbxActivite.Location = new System.Drawing.Point(375, 212);
            this.cbxActivite.Name = "cbxActivite";
            this.cbxActivite.Size = new System.Drawing.Size(120, 21);
            this.cbxActivite.TabIndex = 33;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(421, 263);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 25);
            this.btnAnnuler.TabIndex = 37;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(308, 263);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 25);
            this.btnValider.TabIndex = 36;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // dvgInscriptions
            // 
            this.dvgInscriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgInscriptions.Location = new System.Drawing.Point(17, 55);
            this.dvgInscriptions.Name = "dvgInscriptions";
            this.dvgInscriptions.Size = new System.Drawing.Size(195, 290);
            this.dvgInscriptions.TabIndex = 38;
            this.dvgInscriptions.SelectionChanged += new System.EventHandler(this.dvgInscriptions_SelectionChanged);
            // 
            // frmInscriptionMembres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvgInscriptions);
            this.Controls.Add(this.cbxActivite);
            this.Controls.Add(this.cbxCreneau);
            this.Controls.Add(this.cbxMembreNonInscris);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.lbNActivite);
            this.Controls.Add(this.lbNCreneau);
            this.Controls.Add(this.lbNMembre);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Name = "frmInscriptionMembres";
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmInscriptionMembres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgInscriptions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label lbNActivite;
        private System.Windows.Forms.Label lbNCreneau;
        private System.Windows.Forms.Label lbNMembre;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxMembreNonInscris;
        private System.Windows.Forms.ComboBox cbxCreneau;
        private System.Windows.Forms.ComboBox cbxActivite;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DataGridView dvgInscriptions;
    }
}