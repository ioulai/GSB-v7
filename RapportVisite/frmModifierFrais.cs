using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace RapportVisite
{
    public partial class frmModifierFrais : Form
    {

        private GSB_EQ3Entities maConnexion;
        private Visiteur levisiteurConnecte;
        fichefrais ceFrais;
        private int montantValide, justificatif;
        private string idEtat;
        private Etat unEtat;

        public frmModifierFrais(GSB_EQ3Entities MaConnexion, Visiteur Levisiteur)
        {
            InitializeComponent();
            maConnexion = MaConnexion;
            levisiteurConnecte = Levisiteur;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmModifierFrais_Load(object sender, EventArgs e)
        {
            bsModifierFrais.DataSource = maConnexion.fichefrais;

            afficheRecap();
          
        

        }
        // Méthode pour affecter les valeurs saisies aux champs de l'enregistrement avant son ajout ou sa mise à jour
        public void Affecter()
        {
            justificatif = Convert.ToInt32(textBox_NbJustificatif.Text);
            justificatif = int.Parse(textBox_NbJustificatif.Text);

            montantValide = Convert.ToInt32(textBox_MontantValide.Text);
            montantValide = int.Parse(textBox_MontantValide.Text);

           

            ceFrais = (fichefrais)this.bsModifierFrais.Current;
            ceFrais.idVisiteur = levisiteurConnecte.idVisiteur;
            ceFrais.mois = cbMois.Text;
            ceFrais.montantValide = montantValide;
            ceFrais.nbJustificatifs = justificatif;
           // ceFrais.Etat = idEtat;


        }
        

        public void afficheRecap()
        {
            var reqFicheFrais = from f in maConnexion.fichefrais
                                select new { f.idVisiteur, f.mois, f.nbJustificatifs, f.montantValide, f.dateModif, f.idEtat };

            this.dgv_modifier.DataSource = ((ObjectQuery)(reqFicheFrais));

            dgv_modifier.Columns[0].HeaderText = "idVisiteur";
            dgv_modifier.Columns[1].HeaderText = "mois";
            dgv_modifier.Columns[2].HeaderText = "modifier";
            dgv_modifier.Columns[3].HeaderText = "montantValide";
            dgv_modifier.Columns[4].HeaderText = "dateModif";
            dgv_modifier.Columns[5].HeaderText = "idEtat";
        }

        private void btn_Modifier_Click(object sender, EventArgs e)
        {
            this.maConnexion.SaveChanges();
        }

        private void cbEtat_SelectedIndexChanged(object sender, EventArgs e)
        {
            unEtat = (Etat)this.cbEtat.SelectedItem;
            idEtat = Convert.ToString( unEtat.id);
        }

    }
}
