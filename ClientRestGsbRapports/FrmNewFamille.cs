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
using Newtonsoft.Json;
using System.Collections.Specialized;


namespace ClientRestGsbRapports
{
    public partial class FrmNewFamille : Form
    {
        private string site;
        private WebClient wb;
        private Secretaire laSecretaire;
       
        public FrmNewFamille(Secretaire s)
        {
            InitializeComponent();
            this.laSecretaire = s;
            this.wb = new WebClient();
            this.site = "http://localhost/restGSB/";
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            try
            {
                // code pour l'ajout d'une famille
            }
            catch (WebException ex)
            {
                if (ex.Response is HttpWebResponse)
                    MessageBox.Show(((HttpWebResponse)ex.Response).StatusCode.ToString());

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
