using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientAjoutPrestationWCF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Inscrire_Click(object sender, EventArgs e)
        {
            if (tbNomDemande.Text =="" || tbTypeDemande.Text =="")
            {
                MessageBox.Show("Les deux champs sont obligatoires");
                return;
            }
            ServiceReferences1.AjoutPrestationEwbserviceclient client = new Servicereference1.ebServiceclient();
            ServiceReference1.prestation p = new ServiceReference1.prestation();

            p.nom = tbNomDemande.Text;
            p.type = tbTypeDemande.Text;

            if (client.inscrireDemande(p))
            {
                MessageBox.Show("Votre demande a été inscrite avec succés");
            }
            else
            {
                MessageBox.Show("votre demande a été refusée");
            }
        }
    }
}
