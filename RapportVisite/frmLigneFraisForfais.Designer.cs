namespace RapportVisite
{
    partial class frmLigneFraisForfais
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
            this.libelleLabel = new System.Windows.Forms.Label();
            this.libelleLabel1 = new System.Windows.Forms.Label();
            this.quantiteLabel = new System.Windows.Forms.Label();
            this.montantLabel = new System.Windows.Forms.Label();
            this.affichenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.afficheprenom = new System.Windows.Forms.TextBox();
            this.BSfraisForfait = new System.Windows.Forms.BindingSource(this.components);
            this.cbFrais = new System.Windows.Forms.ComboBox();
            this.textBox_libelle = new System.Windows.Forms.TextBox();
            this.BSligneFraisForfait = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_quantite = new System.Windows.Forms.TextBox();
            this.textBox_montant = new System.Windows.Forms.TextBox();
            this.textbox_total = new System.Windows.Forms.TextBox();
            this.btnTotal = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.BSrapport = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvRecapitulatif = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox_idVisiteur = new System.Windows.Forms.TextBox();
            this.textBox_mois = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.BSfraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSligneFraisForfait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSrapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecapitulatif)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // libelleLabel
            // 
            this.libelleLabel.AutoSize = true;
            this.libelleLabel.BackColor = System.Drawing.Color.Transparent;
            this.libelleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libelleLabel.Location = new System.Drawing.Point(24, 71);
            this.libelleLabel.Name = "libelleLabel";
            this.libelleLabel.Size = new System.Drawing.Size(56, 13);
            this.libelleLabel.TabIndex = 4;
            this.libelleLabel.Text = "Frais de:";
            // 
            // libelleLabel1
            // 
            this.libelleLabel1.AutoSize = true;
            this.libelleLabel1.BackColor = System.Drawing.Color.Transparent;
            this.libelleLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.libelleLabel1.Location = new System.Drawing.Point(136, 71);
            this.libelleLabel1.Name = "libelleLabel1";
            this.libelleLabel1.Size = new System.Drawing.Size(44, 13);
            this.libelleLabel1.TabIndex = 7;
            this.libelleLabel1.Text = "libelle:";
            // 
            // quantiteLabel
            // 
            this.quantiteLabel.AutoSize = true;
            this.quantiteLabel.BackColor = System.Drawing.Color.Transparent;
            this.quantiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantiteLabel.Location = new System.Drawing.Point(426, 72);
            this.quantiteLabel.Name = "quantiteLabel";
            this.quantiteLabel.Size = new System.Drawing.Size(57, 13);
            this.quantiteLabel.TabIndex = 11;
            this.quantiteLabel.Text = "quantite:";
            // 
            // montantLabel
            // 
            this.montantLabel.AutoSize = true;
            this.montantLabel.BackColor = System.Drawing.Color.Transparent;
            this.montantLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montantLabel.Location = new System.Drawing.Point(539, 71);
            this.montantLabel.Name = "montantLabel";
            this.montantLabel.Size = new System.Drawing.Size(56, 13);
            this.montantLabel.TabIndex = 13;
            this.montantLabel.Text = "montant:";
            // 
            // affichenom
            // 
            this.affichenom.Location = new System.Drawing.Point(217, 38);
            this.affichenom.Name = "affichenom";
            this.affichenom.Size = new System.Drawing.Size(100, 20);
            this.affichenom.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vous etes connecté en  tant que";
            // 
            // afficheprenom
            // 
            this.afficheprenom.Location = new System.Drawing.Point(339, 38);
            this.afficheprenom.Name = "afficheprenom";
            this.afficheprenom.Size = new System.Drawing.Size(100, 20);
            this.afficheprenom.TabIndex = 2;
            // 
            // BSfraisForfait
            // 
            this.BSfraisForfait.DataSource = typeof(RapportVisite.FraisForfait);
            // 
            // cbFrais
            // 
            this.cbFrais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSfraisForfait, "libelle", true));
            this.cbFrais.FormattingEnabled = true;
            this.cbFrais.Location = new System.Drawing.Point(12, 88);
            this.cbFrais.Name = "cbFrais";
            this.cbFrais.Size = new System.Drawing.Size(121, 21);
            this.cbFrais.TabIndex = 5;
            this.cbFrais.SelectedIndexChanged += new System.EventHandler(this.cbFrais_SelectedIndexChanged);
            // 
            // textBox_libelle
            // 
            this.textBox_libelle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSfraisForfait, "libelle", true));
            this.textBox_libelle.Location = new System.Drawing.Point(139, 87);
            this.textBox_libelle.Name = "textBox_libelle";
            this.textBox_libelle.Size = new System.Drawing.Size(100, 20);
            this.textBox_libelle.TabIndex = 8;
            // 
            // BSligneFraisForfait
            // 
            this.BSligneFraisForfait.DataMember = "LigneFraisForfait";
            this.BSligneFraisForfait.DataSource = this.BSfraisForfait;
            // 
            // textBox_quantite
            // 
            this.textBox_quantite.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSligneFraisForfait, "quantite", true));
            this.textBox_quantite.Location = new System.Drawing.Point(408, 88);
            this.textBox_quantite.Name = "textBox_quantite";
            this.textBox_quantite.Size = new System.Drawing.Size(100, 20);
            this.textBox_quantite.TabIndex = 12;
            this.textBox_quantite.TextChanged += new System.EventHandler(this.quantiteTextBox_TextChanged);
            // 
            // textBox_montant
            // 
            this.textBox_montant.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.BSfraisForfait, "montant", true));
            this.textBox_montant.Location = new System.Drawing.Point(533, 87);
            this.textBox_montant.Name = "textBox_montant";
            this.textBox_montant.Size = new System.Drawing.Size(100, 20);
            this.textBox_montant.TabIndex = 14;
            // 
            // textbox_total
            // 
            this.textbox_total.Location = new System.Drawing.Point(663, 87);
            this.textbox_total.Name = "textbox_total";
            this.textbox_total.Size = new System.Drawing.Size(100, 20);
            this.textbox_total.TabIndex = 15;
            // 
            // btnTotal
            // 
            this.btnTotal.AutoSize = true;
            this.btnTotal.BackColor = System.Drawing.Color.Transparent;
            this.btnTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotal.Location = new System.Drawing.Point(671, 71);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(40, 13);
            this.btnTotal.TabIndex = 16;
            this.btnTotal.Text = "Total:";
            // 
            // btn_valider
            // 
            this.btn_valider.BackColor = System.Drawing.Color.Silver;
            this.btn_valider.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_valider.Location = new System.Drawing.Point(651, 352);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 17;
            this.btn_valider.Text = "VALIDER";
            this.btn_valider.UseVisualStyleBackColor = false;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(702, 113);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(61, 25);
            this.btnAfficher.TabIndex = 18;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // BSrapport
            // 
            this.BSrapport.DataSource = typeof(RapportVisite.RAPPORT);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Recapitulatif";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(303, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mois";
            // 
            // dgvRecapitulatif
            // 
            this.dgvRecapitulatif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecapitulatif.Location = new System.Drawing.Point(139, 141);
            this.dgvRecapitulatif.Name = "dgvRecapitulatif";
            this.dgvRecapitulatif.Size = new System.Drawing.Size(494, 208);
            this.dgvRecapitulatif.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(774, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // textBox_idVisiteur
            // 
            this.textBox_idVisiteur.Location = new System.Drawing.Point(479, 43);
            this.textBox_idVisiteur.Name = "textBox_idVisiteur";
            this.textBox_idVisiteur.Size = new System.Drawing.Size(104, 20);
            this.textBox_idVisiteur.TabIndex = 26;
            // 
            // textBox_mois
            // 
            this.textBox_mois.AutoCompleteCustomSource.AddRange(new string[] {
            "janvier",
            "fevrier",
            "mars",
            "avril"});
            this.textBox_mois.Location = new System.Drawing.Point(306, 87);
            this.textBox_mois.Name = "textBox_mois";
            this.textBox_mois.Size = new System.Drawing.Size(93, 20);
            this.textBox_mois.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "janvier",
            "fevrier",
            "mars"});
            this.comboBox1.Location = new System.Drawing.Point(306, 113);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(93, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // frmLigneFraisForfais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RapportVisite.Properties.Resources.blue_image_012;
            this.ClientSize = new System.Drawing.Size(774, 400);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_idVisiteur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_mois);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.textbox_total);
            this.Controls.Add(this.montantLabel);
            this.Controls.Add(this.textBox_montant);
            this.Controls.Add(this.quantiteLabel);
            this.Controls.Add(this.textBox_quantite);
            this.Controls.Add(this.libelleLabel1);
            this.Controls.Add(this.textBox_libelle);
            this.Controls.Add(this.dgvRecapitulatif);
            this.Controls.Add(this.libelleLabel);
            this.Controls.Add(this.cbFrais);
            this.Controls.Add(this.afficheprenom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.affichenom);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmLigneFraisForfais";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSaisieFrais";
            this.Load += new System.EventHandler(this.frmLigneFraisForfais_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.BSfraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSligneFraisForfait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BSrapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecapitulatif)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox affichenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox afficheprenom;
        private System.Windows.Forms.BindingSource BSfraisForfait;
        private System.Windows.Forms.ComboBox cbFrais;
        private System.Windows.Forms.TextBox textBox_libelle;
        private System.Windows.Forms.BindingSource BSligneFraisForfait;
        private System.Windows.Forms.TextBox textBox_quantite;
        private System.Windows.Forms.TextBox textBox_montant;
        private System.Windows.Forms.TextBox textbox_total;
        private System.Windows.Forms.Label btnTotal;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.BindingSource BSrapport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvRecapitulatif;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox_idVisiteur;
        private System.Windows.Forms.TextBox textBox_mois;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label libelleLabel;
        private System.Windows.Forms.Label libelleLabel1;
        private System.Windows.Forms.Label quantiteLabel;
        private System.Windows.Forms.Label montantLabel;



    }
}