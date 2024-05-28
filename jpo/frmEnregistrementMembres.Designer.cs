
namespace jpo
{
    partial class frmEnregistrementMembres
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.tbxTel = new System.Windows.Forms.TextBox();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lbNLigue = new System.Windows.Forms.Label();
            this.lbNMail = new System.Windows.Forms.Label();
            this.lbNTel = new System.Windows.Forms.Label();
            this.lbNPrenom = new System.Windows.Forms.Label();
            this.lbNNom = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dvgMembres = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbxLigue = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMembres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enregistrement membres";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(438, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 25);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(338, 308);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 25);
            this.btnModify.TabIndex = 29;
            this.btnModify.Text = "Modifier";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // tbxMail
            // 
            this.tbxMail.Location = new System.Drawing.Point(367, 226);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(157, 20);
            this.tbxMail.TabIndex = 27;
            // 
            // tbxTel
            // 
            this.tbxTel.Location = new System.Drawing.Point(367, 186);
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(157, 20);
            this.tbxTel.TabIndex = 26;
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(367, 146);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(157, 20);
            this.tbxPrenom.TabIndex = 25;
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(367, 107);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(157, 20);
            this.tbxNom.TabIndex = 24;
            // 
            // lbNLigue
            // 
            this.lbNLigue.AutoSize = true;
            this.lbNLigue.Location = new System.Drawing.Point(297, 269);
            this.lbNLigue.Name = "lbNLigue";
            this.lbNLigue.Size = new System.Drawing.Size(33, 13);
            this.lbNLigue.TabIndex = 23;
            this.lbNLigue.Text = "Ligue";
            // 
            // lbNMail
            // 
            this.lbNMail.AutoSize = true;
            this.lbNMail.Location = new System.Drawing.Point(297, 229);
            this.lbNMail.Name = "lbNMail";
            this.lbNMail.Size = new System.Drawing.Size(26, 13);
            this.lbNMail.TabIndex = 22;
            this.lbNMail.Text = "Mail";
            // 
            // lbNTel
            // 
            this.lbNTel.AutoSize = true;
            this.lbNTel.Location = new System.Drawing.Point(297, 189);
            this.lbNTel.Name = "lbNTel";
            this.lbNTel.Size = new System.Drawing.Size(58, 13);
            this.lbNTel.TabIndex = 21;
            this.lbNTel.Text = "Téléphone";
            // 
            // lbNPrenom
            // 
            this.lbNPrenom.AutoSize = true;
            this.lbNPrenom.Location = new System.Drawing.Point(297, 149);
            this.lbNPrenom.Name = "lbNPrenom";
            this.lbNPrenom.Size = new System.Drawing.Size(46, 13);
            this.lbNPrenom.TabIndex = 20;
            this.lbNPrenom.Text = "Prénom:";
            // 
            // lbNNom
            // 
            this.lbNNom.AutoSize = true;
            this.lbNNom.Location = new System.Drawing.Point(297, 110);
            this.lbNNom.Name = "lbNNom";
            this.lbNNom.Size = new System.Drawing.Size(32, 13);
            this.lbNNom.TabIndex = 19;
            this.lbNNom.Text = "Nom:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(17, 352);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 25);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Ajouter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(338, 308);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 25);
            this.btnValider.TabIndex = 31;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(438, 308);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 25);
            this.btnAnnuler.TabIndex = 32;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // dvgMembres
            // 
            this.dvgMembres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMembres.Location = new System.Drawing.Point(17, 53);
            this.dvgMembres.Name = "dvgMembres";
            this.dvgMembres.Size = new System.Drawing.Size(195, 290);
            this.dvgMembres.TabIndex = 33;
            this.dvgMembres.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMembres_CellContentClick);
            this.dvgMembres.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgMembres_CellContentClick_1);
            this.dvgMembres.SelectionChanged += new System.EventHandler(this.dvgMembres_SelectionChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cbxLigue
            // 
            this.cbxLigue.FormattingEnabled = true;
            this.cbxLigue.Location = new System.Drawing.Point(367, 266);
            this.cbxLigue.Name = "cbxLigue";
            this.cbxLigue.Size = new System.Drawing.Size(157, 21);
            this.cbxLigue.TabIndex = 34;
            // 
            // frmEnregistrementMembres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.cbxLigue);
            this.Controls.Add(this.dvgMembres);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.tbxTel);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lbNLigue);
            this.Controls.Add(this.lbNMail);
            this.Controls.Add(this.lbNTel);
            this.Controls.Add(this.lbNPrenom);
            this.Controls.Add(this.lbNNom);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnValider);
            this.Name = "frmEnregistrementMembres";
            this.Text = "Enregistrement membres";
            this.Load += new System.EventHandler(this.frmEnregistrementMembres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgMembres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.TextBox tbxTel;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label lbNLigue;
        private System.Windows.Forms.Label lbNMail;
        private System.Windows.Forms.Label lbNTel;
        private System.Windows.Forms.Label lbNPrenom;
        private System.Windows.Forms.Label lbNNom;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DataGridView dvgMembres;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cbxLigue;
    }
}