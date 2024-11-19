using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Gestion_de_Vente
{
    class Article
    {
        public string code_Art { get; set; }
        public string Designation { get; set; }
        public float PU { get; set; }
        public int Qte { get; set; }

       clsDataAccess data = new clsDataAccess();


        public int Ajouter(Article article)

        {
            
            int resultat = 0;

            string strQuery = "insert into tArticle (code_Art,Designation,PU, Qte)" +
            " values (@code_Art,@Designation,@PU,@Qte)";

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.conn);
                cmd.Parameters.AddWithValue("@code_Art", article.code_Art);
                cmd.Parameters.AddWithValue("@Designation", article.Designation);
                cmd.Parameters.AddWithValue("@PU", article.PU);
                cmd.Parameters.AddWithValue("@Qte", article.Qte);
                resultat = cmd.ExecuteNonQuery();
         
                cmd.Dispose();
                data.CloseConnection();
            }
        


            return resultat;
        }

        public  List<Article> GetArticle()
        {
            List<Article> list = new List<Article>();
            string strQuery = "SELECT *FROM tArticle";
            if(data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.conn);
                SqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    Article art = new Article();
                    art.code_Art = rd["code_Art"].ToString();
                    art.Designation = rd["Designation"].ToString();
                    art.PU = Convert.ToInt32(rd["PU"]);
                    art.Qte = Convert.ToInt32(rd["Qte"]);
                    list.Add(art);
                }
                rd.Close();
                cmd.Dispose();
                data.CloseConnection();
              
               
            }
            return list;
        }
        public int Modifier(Article article)

        {

            int resultat = 0;

            string strQuery = "update tArticle set  " + "@code_Art = code_Art, @Designation = Designation, @PU = PU, @Qte= Qte where @code_Art = code_Art";
           

            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.conn);
                cmd.Parameters.AddWithValue("@code_Art", article.code_Art);
                cmd.Parameters.AddWithValue("@Designation", article.Designation);
                cmd.Parameters.AddWithValue("@PU", article.PU);
                cmd.Parameters.AddWithValue("@Qte", article.Qte);
                resultat = cmd.ExecuteNonQuery();

                cmd.Dispose();
                data.CloseConnection();
            }



            return resultat;
        }
        public int Supprimer(Article article)

        {

            int resultat = 0;

            string strQuery = "delete article where id_Art = @id_Art";


            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(strQuery, data.conn);
                cmd.Parameters.AddWithValue("@id_art", article.code_Art);
               
                resultat = cmd.ExecuteNonQuery();

                cmd.Dispose();
                data.CloseConnection();
            }



            return resultat;
        }
    }
}
