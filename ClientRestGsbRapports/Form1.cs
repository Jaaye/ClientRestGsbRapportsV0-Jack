using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net; // pour WbClient
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mdlGsbRapports;
using Newtonsoft.Json;          // pour la gestion du format Json
using System.Security.Cryptography;     // pour SHA1

namespace ClientRestGsbRapports
{
    public partial class Form1 : Form
    {
        private string site;
        private WebClient wb;
        private string ticket;
        private Secretaire laSecretaire;
        private object txtMdp;

        public Form1()
        {
            InitializeComponent();
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
           this.menuStrip1.Visible = false;
            this.laSecretaire = new Secretaire();
           
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string mdp = this.txtMdp.Text;
            string login = this.txtLogin.Text;
            string reponse; // la réponse retournée  par le serveur
            /* Création de la requête*/
            string url = this.site + "login?login=" + login;
            /*Appel à l'objet wb pour récupérer le résultat de la requête*/
            reponse = this.wb.DownloadString(url);
            /* récupération, après désérialisation et conversion*/
             this.ticket = (string)JsonConvert.DeserializeObject(reponse);
             if (this.ticket == null)
                MessageBox.Show("erreur de Login");
            else
            {
                this.laSecretaire.ticket = this.ticket;
                this.laSecretaire.mdp = mdp;
                /* on appelle la fonction de la classe secrétaire qui va hashe ticket+mdp */
                string hash = this.laSecretaire.getHashTicketMdp();
                /*On crée la requête*/
                url = this.site + "connexion?login=" + login + "&mdp=" + hash;
                /* On récupère la réponse du serveur de type json */
                reponse = this.wb.DownloadString(url);
                /*On transforme la réponse json en objet Secrétaire!!*/
                Secretaire s  = JsonConvert.DeserializeObject<Secretaire>(reponse);
                if (s == null)
                    MessageBox.Show("erreur de mot de passe!!");
                else
                {
                    /* On renseigne le champ de la secrétaire pour la passer aux formulaires*/
                    this.laSecretaire.nom = s.nom;
                    this.laSecretaire.prenom = s.prenom;
                    this.laSecretaire.mdp = this.txtMdp.Text;
                    this.laSecretaire.ticket = s.ticket;
                    this.lblNom.Text = "Bonjour " + this.laSecretaire.prenom + " " + this.laSecretaire.nom;
                    this.menuStrip1.Visible = true;
                }
            }
          
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void voirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmVoirFamilles f = new FrmVoirFamilles(this.laSecretaire);
            f.Show();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMajFamille f = new FrmMajFamille(this.laSecretaire);
            f.Show();
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNewFamille f = new FrmNewFamille(this.laSecretaire);
            f.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
