using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Ajouts de références systèmes pour la gestion des données, entre autre ObjectQuery
using System.Data.Objects;
using System.Data.Objects.DataClasses;

namespace RapportVisite
{
    public partial class frmLigneFraisForfais : Form
    {

        private GSB_EQ3Entities maConnexion;
        private Visiteur levisiteurConnecte;
        private FraisForfait ceFrais;
        private LigneFraisForfait unNewLigneFraisForfait;
        private string ceIdFrais;

        public frmLigneFraisForfais(GSB_EQ3Entities MaConnexion, Visiteur Levisiteur)
        {

            InitializeComponent();
            maConnexion = MaConnexion;
            levisiteurConnecte = Levisiteur;
        }
        #region chargement des infos à l'ouverture du formulaire
        private void frmLigneFraisForfais_Load_1(object sender, EventArgs e)
        {

            // chargement de l'utilisateur courant 
            affichenom.Text = levisiteurConnecte.nom;
            afficheprenom.Text = levisiteurConnecte.prenom;
            textBox_idVisiteur.Text = levisiteurConnecte.idVisiteur;


            // chargement de cbo frais 
            var reqFrais = from f in maConnexion.FraisForfait
                           orderby f.libelle
                           select f;
            try
            {
                this.cbFrais.DisplayMember = "id";
                this.cbFrais.DataSource = ((ObjectQuery)(reqFrais)).Execute(MergeOption.AppendOnly);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            //affichage dgv recapitulatif

            /* string ceIdVisiteur = this.levisiteurConnecte.idVisiteur;
             var reqFraisRecap = from l in maConnexion.LigneFraisForfait                
                                 select new { l.idVisiteur, l.mois, l.idFraisForfait, l.quantite};


             this.dgvRecapitulatif.DataSource = ((ObjectQuery)(reqFraisRecap));

             dgvRecapitulatif.DefaultCellStyle.BackColor = Color.Bisque;
             dgvRecapitulatif.DefaultCellStyle.Font = new Font("Calibri", 9);
             dgvRecapitulatif.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

             // les ajouts et suppressions sont interdits
             dgvRecapitulatif.AllowUserToAddRows = false;
             dgvRecapitulatif.AllowUserToDeleteRows = false;

             // On formate le contenu du datGriedview dgvRecapitulatif pour un affichage correct                
             // L'entête de colonne des autres champs sont modifiés
             dgvRecapitulatif.Columns[0].HeaderText = "IdVisiteur";
             dgvRecapitulatif.Columns[1].HeaderText = "Mois";
             dgvRecapitulatif.Columns[2].HeaderText = "idFraisForfait";
             dgvRecapitulatif.Columns[3].HeaderText = "MontantValide";
             //dgvRecapitulatif.Columns[4].HeaderText = "quantite";
          

             // les colonnes sont redimensionnées automatiquement, le nom est mis en gras
             dgvRecapitulatif.AutoResizeColumns();
             dgvRecapitulatif.Columns[1].Width = 100;
             dgvRecapitulatif.Columns[1].DefaultCellStyle.Font = new Font("Calibri", 9, FontStyle.Bold);
             dgvRecapitulatif.Columns[2].Width = 100;*/





        }
        #endregion

        // affichage valeur au choix de type
        private void cbFrais_SelectedIndexChanged(object sender, EventArgs e)
        {
            //affectation à l'objet ce frais de l'enregistrement selectionner dans la zone de liste cbFrais
            ceFrais = (FraisForfait)this.cbFrais.SelectedItem;
            ceIdFrais = ceFrais.id;
            //afficher le type  selectionner dans cbo
            textBox_libelle.Text = ceFrais.libelle;

            //afficher le montant du type courant 
            textBox_montant.Text = Convert.ToString(ceFrais.montant);
        }



        //calcul de total
        private void quantiteTextBox_TextChanged(object sender, EventArgs e)
        {

            //calcul du total
            textbox_total.Text = Convert.ToString(0);
            if (textbox_total.Text == Convert.ToString(0))
            {
                textbox_total.Text = Convert.ToString(Convert.ToDecimal(textBox_montant.Text) * Convert.ToDecimal(textBox_quantite.Text));
            }

        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {






        }



        private void btn_valider_Click(object sender, EventArgs e)
        {
            unNewLigneFraisForfait = new LigneFraisForfait();
            //affectation a chaque champ fraiforfait la valeur saisie
            unNewLigneFraisForfait.idVisiteur = levisiteurConnecte.idVisiteur;
            unNewLigneFraisForfait.mois = textBox_mois.Text;
            unNewLigneFraisForfait.idFraisForfait = ceIdFrais;
            unNewLigneFraisForfait.quantite = Convert.ToInt16(textBox_quantite.Text);
            
                try
                {
                   
                    this.maConnexion.AddToLigneFraisForfait(unNewLigneFraisForfait);
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
        /**********************************************************************************/

       















    }
}

