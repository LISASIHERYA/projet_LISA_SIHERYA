using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_Vente
{
    public partial class FrmPrincipale : Form
    {
        public FrmPrincipale()
        {
            InitializeComponent();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClient fc = new FrmClient();
            fc.MdiParent = this;
            fc.Show();
            
        }

        private void articleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmArticle fa = new FrmArticle();
            fa.MdiParent = this;
            fa.Show();
        }

        private void achatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAchat fma = new FrmAchat();
            fma.MdiParent = this;
            fma.Show();
        }

        private void FrmPrincipale_Load(object sender, EventArgs e)
        {
            clsDataAccess data = new clsDataAccess();
            bool isOpen= data.OpenConnection();

            if (isOpen)
            {
                MessageBox.Show(" Connexion a la Base de donnee a Reussi", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Connexion a la Base de donnee a echouee", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
