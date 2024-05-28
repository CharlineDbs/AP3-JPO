
namespace jpo
{
    partial class frmInscriptionLigues
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
            this.btnValiderEquip = new System.Windows.Forms.Button();
            this.btnModifierEquipement = new System.Windows.Forms.Button();
            this.cbxEquipement = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEquip = new System.Windows.Forms.DataGridView();
            this.dgvLigues = new System.Windows.Forms.DataGridView();
            this.tbxQuantite = new System.Windows.Forms.TextBox();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEquipement = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.tbxStandLargeur = new System.Windows.Forms.TextBox();
            this.tbxStandLongueur = new System.Windows.Forms.TextBox();
            this.lblStand = new System.Windows.Forms.Label();
            this.btndésinscrire = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblLiguesNoInsc = new System.Windows.Forms.Label();
            this.cbxLigues = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigues)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValiderEquip
            // 
            this.btnValiderEquip.Location = new System.Drawing.Point(500, 368);
            this.btnValiderEquip.Name = "btnValiderEquip";
            this.btnValiderEquip.Size = new System.Drawing.Size(78, 25);
            this.btnValiderEquip.TabIndex = 79;
            this.btnValiderEquip.Text = "Valider";
            this.btnValiderEquip.UseVisualStyleBackColor = true;
            this.btnValiderEquip.Click += new System.EventHandler(this.btnValiderEquip_Click);
            // 
            // btnModifierEquipement
            // 
            this.btnModifierEquipement.Location = new System.Drawing.Point(584, 368);
            this.btnModifierEquipement.Name = "btnModifierEquipement";
            this.btnModifierEquipement.Size = new System.Drawing.Size(78, 25);
            this.btnModifierEquipement.TabIndex = 78;
            this.btnModifierEquipement.Text = "Modifier ";
            this.btnModifierEquipement.UseVisualStyleBackColor = true;
            this.btnModifierEquipement.Click += new System.EventHandler(this.btnModifierEquip_Click);
            // 
            // cbxEquipement
            // 
            this.cbxEquipement.FormattingEnabled = true;
            this.cbxEquipement.Location = new System.Drawing.Point(681, 135);
            this.cbxEquipement.Name = "cbxEquipement";
            this.cbxEquipement.Size = new System.Drawing.Size(130, 24);
            this.cbxEquipement.TabIndex = 77;
            this.cbxEquipement.SelectedIndexChanged += new System.EventHandler(this.cbxEquipement_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 76;
            this.label4.Text = "Equipements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 75;
            this.label3.Text = "Ligues inscrites";
            // 
            // dgvEquip
            // 
            this.dgvEquip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquip.Location = new System.Drawing.Point(492, 93);
            this.dgvEquip.Name = "dgvEquip";
            this.dgvEquip.RowHeadersWidth = 51;
            this.dgvEquip.Size = new System.Drawing.Size(183, 238);
            this.dgvEquip.TabIndex = 74;
            this.dgvEquip.SelectionChanged += new System.EventHandler(this.dgvEquip_SelectionChanged);
            // 
            // dgvLigues
            // 
            this.dgvLigues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLigues.Location = new System.Drawing.Point(22, 93);
            this.dgvLigues.Name = "dgvLigues";
            this.dgvLigues.RowHeadersWidth = 51;
            this.dgvLigues.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvLigues.Size = new System.Drawing.Size(183, 238);
            this.dgvLigues.TabIndex = 73;
            this.dgvLigues.SelectionChanged += new System.EventHandler(this.dgvLigues_SelectionChanged);
            // 
            // tbxQuantite
            // 
            this.tbxQuantite.Location = new System.Drawing.Point(572, 338);
            this.tbxQuantite.Name = "tbxQuantite";
            this.tbxQuantite.Size = new System.Drawing.Size(80, 22);
            this.tbxQuantite.TabIndex = 72;
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(497, 345);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(56, 16);
            this.lblQuantite.TabIndex = 71;
            this.lblQuantite.Text = "Quantité";
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(238, 274);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 25);
            this.btnEnregistrer.TabIndex = 70;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(319, 274);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 25);
            this.btnAnnuler.TabIndex = 69;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 32);
            this.label2.TabIndex = 68;
            this.label2.Text = "Taille Stand \r\nLargeur";
            // 
            // btnEquipement
            // 
            this.btnEquipement.Location = new System.Drawing.Point(681, 104);
            this.btnEquipement.Name = "btnEquipement";
            this.btnEquipement.Size = new System.Drawing.Size(130, 25);
            this.btnEquipement.TabIndex = 67;
            this.btnEquipement.Text = "Ajouter équipements";
            this.btnEquipement.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(238, 274);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 25);
            this.btnModifier.TabIndex = 66;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // tbxStandLargeur
            // 
            this.tbxStandLargeur.Location = new System.Drawing.Point(327, 212);
            this.tbxStandLargeur.Name = "tbxStandLargeur";
            this.tbxStandLargeur.Size = new System.Drawing.Size(120, 22);
            this.tbxStandLargeur.TabIndex = 65;
            // 
            // tbxStandLongueur
            // 
            this.tbxStandLongueur.Location = new System.Drawing.Point(327, 157);
            this.tbxStandLongueur.Name = "tbxStandLongueur";
            this.tbxStandLongueur.Size = new System.Drawing.Size(120, 22);
            this.tbxStandLongueur.TabIndex = 64;
            // 
            // lblStand
            // 
            this.lblStand.AutoSize = true;
            this.lblStand.Location = new System.Drawing.Point(235, 151);
            this.lblStand.Name = "lblStand";
            this.lblStand.Size = new System.Drawing.Size(82, 32);
            this.lblStand.TabIndex = 63;
            this.lblStand.Text = "Taille Stand \r\nLongueur";
            // 
            // btndésinscrire
            // 
            this.btndésinscrire.Location = new System.Drawing.Point(319, 274);
            this.btndésinscrire.Name = "btndésinscrire";
            this.btndésinscrire.Size = new System.Drawing.Size(75, 25);
            this.btndésinscrire.TabIndex = 62;
            this.btndésinscrire.Text = "Désinscrire";
            this.btndésinscrire.UseVisualStyleBackColor = true;
            this.btndésinscrire.Click += new System.EventHandler(this.btndésinscrire_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(31, 337);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 25);
            this.btnAjouter.TabIndex = 61;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblLiguesNoInsc
            // 
            this.lblLiguesNoInsc.AutoSize = true;
            this.lblLiguesNoInsc.Location = new System.Drawing.Point(235, 103);
            this.lblLiguesNoInsc.Name = "lblLiguesNoInsc";
            this.lblLiguesNoInsc.Size = new System.Drawing.Size(75, 32);
            this.lblLiguesNoInsc.TabIndex = 60;
            this.lblLiguesNoInsc.Text = "Ligues non \r\ninscrites";
            // 
            // cbxLigues
            // 
            this.cbxLigues.FormattingEnabled = true;
            this.cbxLigues.Location = new System.Drawing.Point(327, 100);
            this.cbxLigues.Name = "cbxLigues";
            this.cbxLigues.Size = new System.Drawing.Size(120, 24);
            this.cbxLigues.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 58;
            this.label1.Text = "Inscription ligues";
            // 
            // frmInscriptionLigues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 448);
            this.Controls.Add(this.btnValiderEquip);
            this.Controls.Add(this.btnModifierEquipement);
            this.Controls.Add(this.cbxEquipement);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvEquip);
            this.Controls.Add(this.dgvLigues);
            this.Controls.Add(this.tbxQuantite);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEquipement);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.tbxStandLargeur);
            this.Controls.Add(this.tbxStandLongueur);
            this.Controls.Add(this.lblStand);
            this.Controls.Add(this.btndésinscrire);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblLiguesNoInsc);
            this.Controls.Add(this.cbxLigues);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmInscriptionLigues";
            this.Text = "Inscription ligues";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValiderEquip;
        private System.Windows.Forms.Button btnModifierEquipement;
        private System.Windows.Forms.ComboBox cbxEquipement;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEquip;
        private System.Windows.Forms.DataGridView dgvLigues;
        private System.Windows.Forms.TextBox tbxQuantite;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEquipement;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox tbxStandLargeur;
        private System.Windows.Forms.TextBox tbxStandLongueur;
        private System.Windows.Forms.Label lblStand;
        private System.Windows.Forms.Button btndésinscrire;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblLiguesNoInsc;
        private System.Windows.Forms.ComboBox cbxLigues;
        private System.Windows.Forms.Label label1;
    }
}