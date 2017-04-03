namespace RapportVisite
{
    partial class frmModifierFrais
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_modifier = new System.Windows.Forms.DataGridView();
            this.bsModifierFrais = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.cbMois = new System.Windows.Forms.ComboBox();
            this.textBox_MontantValide = new System.Windows.Forms.TextBox();
            this.cbEtat = new System.Windows.Forms.ComboBox();
            this.textBox_NbJustificatif = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modifier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModifierFrais)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(60, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(33, 13);
            label2.TabIndex = 46;
            label2.Text = "Mois";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(214, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(91, 13);
            label1.TabIndex = 48;
            label1.Text = "Montant validé";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(487, 60);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(30, 13);
            label3.TabIndex = 50;
            label3.Text = "Etat";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(780, 24);
            this.menuStrip1.TabIndex = 0;
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
            // dgv_modifier
            // 
            this.dgv_modifier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_modifier.Location = new System.Drawing.Point(63, 179);
            this.dgv_modifier.Name = "dgv_modifier";
            this.dgv_modifier.Size = new System.Drawing.Size(645, 153);
            this.dgv_modifier.TabIndex = 1;
            // 
            // bsModifierFrais
            // 
            this.bsModifierFrais.DataSource = typeof(RapportVisite.GSB_EQ3Entities);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(659, 428);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(98, 31);
            this.btn_Modifier.TabIndex = 2;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // cbMois
            // 
            this.cbMois.FormattingEnabled = true;
            this.cbMois.Items.AddRange(new object[] {
            "Janvier",
            "Fevrier",
            "Mars",
            "Avril",
            "Mai",
            "Juin",
            "Juillet",
            "Aout",
            "Septembre",
            "Octobre",
            "Novembre",
            "Decembre"});
            this.cbMois.Location = new System.Drawing.Point(63, 92);
            this.cbMois.Name = "cbMois";
            this.cbMois.Size = new System.Drawing.Size(114, 21);
            this.cbMois.TabIndex = 34;
            // 
            // textBox_MontantValide
            // 
            this.textBox_MontantValide.Location = new System.Drawing.Point(217, 92);
            this.textBox_MontantValide.Name = "textBox_MontantValide";
            this.textBox_MontantValide.Size = new System.Drawing.Size(100, 20);
            this.textBox_MontantValide.TabIndex = 47;
            // 
            // cbEtat
            // 
            this.cbEtat.FormattingEnabled = true;
            this.cbEtat.Location = new System.Drawing.Point(490, 93);
            this.cbEtat.Name = "cbEtat";
            this.cbEtat.Size = new System.Drawing.Size(155, 21);
            this.cbEtat.TabIndex = 49;
            this.cbEtat.SelectedIndexChanged += new System.EventHandler(this.cbEtat_SelectedIndexChanged);
            // 
            // textBox_NbJustificatif
            // 
            this.textBox_NbJustificatif.Location = new System.Drawing.Point(343, 93);
            this.textBox_NbJustificatif.Name = "textBox_NbJustificatif";
            this.textBox_NbJustificatif.Size = new System.Drawing.Size(66, 20);
            this.textBox_NbJustificatif.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(340, 60);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(88, 13);
            label4.TabIndex = 52;
            label4.Text = "Nb justificatifs";
            // 
            // frmModifierFrais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RapportVisite.Properties.Resources.blue_image_012;
            this.ClientSize = new System.Drawing.Size(780, 471);
            this.Controls.Add(label4);
            this.Controls.Add(this.textBox_NbJustificatif);
            this.Controls.Add(label3);
            this.Controls.Add(this.cbEtat);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox_MontantValide);
            this.Controls.Add(label2);
            this.Controls.Add(this.cbMois);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.dgv_modifier);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmModifierFrais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmModifierFrais";
            this.Load += new System.EventHandler(this.frmModifierFrais_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_modifier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsModifierFrais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_modifier;
        private System.Windows.Forms.BindingSource bsModifierFrais;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.ComboBox cbMois;
        private System.Windows.Forms.TextBox textBox_MontantValide;
        private System.Windows.Forms.ComboBox cbEtat;
        private System.Windows.Forms.TextBox textBox_NbJustificatif;
    }
}