﻿using GestionDePharmacie.Entities;
using GestionDePharmacie.Formulaires_Client;
using GestionDePharmacie.Formulaires_Medecin;
using GestionDePharmacie.Formulaires_Vendeur;
using GestionDePharmacie.Formulaires_Medicaments;
using GestionDePharmacie.Formulaires_Ordonnance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDePharmacie
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        MYDBC db = new MYDBC();

        private void Form1_Load(object sender, EventArgs e)
        {
            db.Database.CreateIfNotExists();//il permet 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void nouveauClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Client nclt = new Ajouter_Client();
            nclt.Show();
            this.Hide();
        }

        private void modifierLesInformationsDunClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier_Client mdclt = new Modifier_Client();
            mdclt.Show();
            this.Hide();
        }

        private void supprimerUnClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer_Client sclt = new Supprimer_Client();
            sclt.Show();
            this.Hide();
        }

        private void nouveauMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Medecin amdc = new Ajouter_Medecin();
            amdc.Show();
            this.Hide();
        }

        private void modifierLesInformationsDunMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier_Medecin mmdc = new Modifier_Medecin();
            mmdc.Show();
            this.Hide();
        }

        private void supprimerUnMedecinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer_Medecin smdc = new Supprimer_Medecin();
            smdc.Show();
            this.Hide();
        }

        private void nouveauVendeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Vendeur avndr = new Ajouter_Vendeur();
            avndr.Show();
            this.Hide();
        }

        private void modifierLesInformationsDunVendeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier_Vendeur mvndr = new Modifier_Vendeur();
            mvndr.Show();
            this.Hide();
        }

        private void supprimerUnVendeurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer_Vendeur svndr = new Supprimer_Vendeur();
            svndr.Show();
            this.Hide();
        }

        private void nouveauMedicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Medicament amdc = new Ajouter_Medicament();
            amdc.Show();
            this.Hide();
        }

        private void modifierLesInfrmationsDunMedicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modifier_Medicament mmdc = new Modifier_Medicament();
            mmdc.Show();
            this.Hide();
        }

        private void supprimerMedicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer_Medicament smdc = new Supprimer_Medicament();
            smdc.Show();
            this.Hide();
        }

        private void listeDesMedicamentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ajouterOrdonnanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter_Ordonnance ao = new Ajouter_Ordonnance();
            ao.Show();
        }
    }
}
