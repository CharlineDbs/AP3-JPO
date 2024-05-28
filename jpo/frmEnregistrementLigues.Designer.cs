
namespace jpo
{
    partial class frmEnregistrementLigues
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLigues = new System.Windows.Forms.DataGridView();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.tbxDiscipline = new System.Windows.Forms.TextBox();
            this.tbxVille = new System.Windows.Forms.TextBox();
            this.tbxCp = new System.Windows.Forms.TextBox();
            this.tbxAdresse = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lblDiscipline = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblCp = new System.Windows.Forms.Label();
            this.lblAdresse = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigues)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLigues
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLigues.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLigues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLigues.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLigues.Location = new System.Drawing.Point(45, 81);
            this.dgvLigues.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLigues.Name = "dgvLigues";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLigues.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLigues.RowHeadersWidth = 51;
            this.dgvLigues.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLigues.Size = new System.Drawing.Size(263, 356);
            this.dgvLigues.TabIndex = 69;
            this.dgvLigues.SelectionChanged += new System.EventHandler(this.dgvLigues_SelectionChanged);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(520, 406);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(100, 31);
            this.btnAnnuler.TabIndex = 68;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(412, 406);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(100, 31);
            this.btnEnregistrer.TabIndex = 67;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(412, 406);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(100, 31);
            this.btnModifier.TabIndex = 66;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // tbxDiscipline
            // 
            this.tbxDiscipline.Location = new System.Drawing.Point(528, 351);
            this.tbxDiscipline.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDiscipline.Name = "tbxDiscipline";
            this.tbxDiscipline.Size = new System.Drawing.Size(196, 22);
            this.tbxDiscipline.TabIndex = 65;
            // 
            // tbxVille
            // 
            this.tbxVille.Location = new System.Drawing.Point(528, 295);
            this.tbxVille.Margin = new System.Windows.Forms.Padding(4);
            this.tbxVille.Name = "tbxVille";
            this.tbxVille.Size = new System.Drawing.Size(196, 22);
            this.tbxVille.TabIndex = 64;
            // 
            // tbxCp
            // 
            this.tbxCp.Location = new System.Drawing.Point(528, 240);
            this.tbxCp.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCp.Name = "tbxCp";
            this.tbxCp.Size = new System.Drawing.Size(196, 22);
            this.tbxCp.TabIndex = 63;
            // 
            // tbxAdresse
            // 
            this.tbxAdresse.Location = new System.Drawing.Point(528, 185);
            this.tbxAdresse.Margin = new System.Windows.Forms.Padding(4);
            this.tbxAdresse.Name = "tbxAdresse";
            this.tbxAdresse.Size = new System.Drawing.Size(196, 22);
            this.tbxAdresse.TabIndex = 62;
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(528, 129);
            this.tbxNom.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(196, 22);
            this.tbxNom.TabIndex = 61;
            // 
            // lblDiscipline
            // 
            this.lblDiscipline.AutoSize = true;
            this.lblDiscipline.Location = new System.Drawing.Point(405, 354);
            this.lblDiscipline.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDiscipline.Name = "lblDiscipline";
            this.lblDiscipline.Size = new System.Drawing.Size(72, 16);
            this.lblDiscipline.TabIndex = 60;
            this.lblDiscipline.Text = "Discipline :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(405, 295);
            this.lblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(39, 16);
            this.lblVille.TabIndex = 59;
            this.lblVille.Text = "Ville :";
            // 
            // lblCp
            // 
            this.lblCp.AutoSize = true;
            this.lblCp.Location = new System.Drawing.Point(405, 244);
            this.lblCp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCp.Name = "lblCp";
            this.lblCp.Size = new System.Drawing.Size(87, 16);
            this.lblCp.TabIndex = 58;
            this.lblCp.Text = "Code Postal :";
            // 
            // lblAdresse
            // 
            this.lblAdresse.AutoSize = true;
            this.lblAdresse.Location = new System.Drawing.Point(405, 185);
            this.lblAdresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAdresse.Name = "lblAdresse";
            this.lblAdresse.Size = new System.Drawing.Size(64, 16);
            this.lblAdresse.TabIndex = 57;
            this.lblAdresse.Text = "Adresse :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(405, 133);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(107, 16);
            this.lblNom.TabIndex = 56;
            this.lblNom.Text = "Nom de la ligue :";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(517, 406);
            this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(100, 31);
            this.btnSupprimer.TabIndex = 55;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(45, 457);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 31);
            this.btnAjouter.TabIndex = 54;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(403, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 29);
            this.label1.TabIndex = 53;
            this.label1.Text = "Enregistrement ligues";
            // 
            // frmEnregistrementLigues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgvLigues);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.tbxDiscipline);
            this.Controls.Add(this.tbxVille);
            this.Controls.Add(this.tbxCp);
            this.Controls.Add(this.tbxAdresse);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblDiscipline);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCp);
            this.Controls.Add(this.lblAdresse);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEnregistrementLigues";
            this.Text = "Enregistrement ligues";
            this.Load += new System.EventHandler(this.frmEnregistrementLigues_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLigues;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox tbxDiscipline;
        private System.Windows.Forms.TextBox tbxVille;
        private System.Windows.Forms.TextBox tbxCp;
        private System.Windows.Forms.TextBox tbxAdresse;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label lblDiscipline;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblCp;
        private System.Windows.Forms.Label lblAdresse;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label label1;
    }
}