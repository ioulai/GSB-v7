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
    public partial class frmFicheFrais : Form
    {
        private GSB_EQ3Entities maConnexion;
        private Visiteur levisiteurConnecte;
        private Etat unEtat;
        private fichefrais uneNewFicheFrais;
        private int montantValide, justificatif;
        public frmFicheFrais(GSB_EQ3Entities MaConnexion, Visiteur Levisiteur)
        {

            InitializeComponent();
            maConnexion = MaConnexion;
            levisiteurConnecte = Levisiteur;
        }

        private void frmFicheFrais_Load_1(object sender, EventArgs e)
        {
            // chargement de l'utilisateur courant 
            lbl_nom.Text = levisiteurConnecte.nom;
            lbl_prenom.Text = levisiteurConnecte.prenom;
          
            //id visiteur
            textBox_recap_idVisiteur.Text = levisiteurConnecte.idVisiteur;
            //date counrante
            textBox_Date.Text = Convert.ToString(DateTime.Today);


            // chargement de cbo Etat
            var reqEtat = from E in maConnexion.Etat
                          orderby E.id
                          select E;
            try
            {
                this.cbEtat.DisplayMember = "libelle";
                this.cbEtat.DataSource = ((ObjectQuery)(reqEtat)).Execute(MergeOption.AppendOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
               

        private void textBox_NbJustificatif_TextChanged_1(object sender, EventArgs e)
        {
            justificatif = Convert.ToInt32(textBox_NbJustificatif.Text);
            justificatif = int.Parse(textBox_NbJustificatif.Text);

            textBox_recap_nbJustificatif.Text = Convert.ToString(justificatif);
        }

        private void textBox_MontantValide_TextChanged_1(object sender, EventArgs e)
        {
            montantValide = Convert.ToInt32(textBox_MontantValide.Text);
            montantValide = int.Parse(textBox_MontantValide.Text);

            textBox_recap_montantValide.Text = Convert.ToString(montantValide);
        }

        private void cbEtat_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //affectation à l'objet un Etat de l'enregistrement selectionner dans la zone de liste cbEtat
            unEtat = (Etat)this.cbEtat.SelectedItem;
            textBox_recap_idEtat.Text = Convert.ToString(unEtat.id);
        }
                

        private void cbMois_SelectedIndexChanged(object sender, EventArgs e)
        {
            //recap Mois
            textBox_recap_mois.Text = Convert.ToString(cbMois.SelectedItem);
        }

        private void textBox_Date_TextChanged_1(object sender, EventArgs e)
        {
            textBox_recap_date.Text = textBox_Date.Text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            justificatif = Convert.ToInt32(textBox_NbJustificatif.Text);
            justificatif = int.Parse(textBox_NbJustificatif.Text);

            montantValide = Convert.ToInt32(textBox_MontantValide.Text);
            montantValide = int.Parse(textBox_MontantValide.Text);

            uneNewFicheFrais = new fichefrais();

            uneNewFicheFrais.idVisiteur = levisiteurConnecte.idVisiteur;
            uneNewFicheFrais.mois = cbMois.Text;
            uneNewFicheFrais.nbJustificatifs = justificatif;
            uneNewFicheFrais.montantValide = montantValide;
            uneNewFicheFrais.dateModif = Convert.ToDateTime(textBox_Date.Text);
            uneNewFicheFrais.idEtat = cbEtat.Text;

            try
            {
                this.maConnexion.AddTofichefrais(uneNewFicheFrais);
                //sauvegarde
                this.maConnexion.SaveChanges();
                MessageBox.Show("Frais Ajouté");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
       

    }
}
