using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Gestion_de_Vente
{
    public partial class FrmArticle : Form
    {
        public FrmArticle()
        {
            InitializeComponent();
        }
        Article article = new Article();

        private void bindingClass()
        {
            article.code_Art = txtid.Text; 
            article.Designation = txtdes.Text;
            article.PU = Convert.ToInt32 (txtpu.Text);
            article.Qte =Convert.ToInt32( txtqt.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bindingClass();
                int resultat= article.Ajouter(article);

                if( resultat > 0)
                {
                    MessageBox.Show("Operation effectuer avec succes", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Operation a echouer", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) {
                MessageBox.Show("Un problemme se produit! veiller contact", "message", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }

        }

        private void FrmArticle_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = article.GetArticle(); 
        }
    }
}
