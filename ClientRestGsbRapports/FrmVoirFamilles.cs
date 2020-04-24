using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net; // pour WbClient
using mdlGsbRapports;
using Newtonsoft.Json;          // pour la gestion du format Json


namespace ClientRestGsbRapports
{
    public partial class FrmVoirFamilles : Form
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
        private string url;
     
        public FrmVoirFamilles(Secretaire s)
        {
            InitializeComponent();
            this.laSecretaire = s;
            string mdpHas = s.getHashTicketMdp();
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
            this.dataGridView1.DataSource = null;
            this.url = this.site + "familles?ticket=" + mdpHas;
            string data = this.wb.DownloadString(url);
            dynamic d = JsonConvert.DeserializeObject(data);
            this.laSecretaire.ticket = d.ticket;
            // this.laSecretaire
            string familles1 = "";
            string familles = d.familles.ToString();

            List<Famille> l = JsonConvert.DeserializeObject<List<Famille>>(familles);
            dataGridView1.DataSource = l;

            // code ici
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
