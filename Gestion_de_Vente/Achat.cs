using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Vente
{
    class Achat
    {
        public int id_achat { get; set; }
        public int ref_client { get; set; }
        public int ref_article { get; set; }
        public DateTime date { get; set; }
        public float montant { get; set; }


   public Achat (int ref_client, int ref_article, DateTime date, float montant)
        {

        }

    public void Ajouter ( )
        {

        }
    }
}
