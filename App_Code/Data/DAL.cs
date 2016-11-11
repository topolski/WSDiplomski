using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Data
{
    /// <summary>
    /// Summary description for DAL
    /// </summary>
    public class DAL
    {
        public static List<Model.Kategorija> getKategorije()
        {
            string cs = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection conn = null;
            SqlDataReader reader = null;
            try
            {
                conn = new SqlConnection(cs);
                SqlCommand com = new SqlCommand("AdminKategorijeSelect", conn);
                com.CommandType = CommandType.StoredProcedure;
                conn.Open();
                reader = com.ExecuteReader();
                List<Model.Kategorija> kategorije = new List<Model.Kategorija>();
                while (reader.Read())
                {
                    Model.Kategorija kat = new Model.Kategorija();
                    kat.idKategorije = reader["idKategorija"].ToString();
                    kat.nazivKategorije = reader["Naziv"].ToString();
                    kategorije.Add(kat);
                }
                return kategorije;
            }
            catch (Exception exp)
            {
                HttpContext.Current.Trace.Warn("Greška", "Greška getKategorije()", exp);
            }
            finally 
            {
                if (reader != null) reader.Close();
                if (conn != null && conn.State != ConnectionState.Closed) conn.Close();
            }
            return null;
        }

        public static List<Model.Post> getPosts(string nazivKategorije) 
        {
            string cs = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            SqlConnection conn = null;
            SqlDataReader reader = null;
            try
            {
                conn = new SqlConnection(cs);
                SqlCommand com = new SqlCommand("WSPost", conn);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Naziv", nazivKategorije);
                conn.Open();
                reader = com.ExecuteReader();
                List<Model.Post> postovi = new List<Model.Post>();
                while (reader.Read())
                {
                    Model.Post post = new Model.Post();
                    post.Naslov = reader["Naslov"].ToString();
                    post.LinkKaPostu = "http://localhost:51136/ProbaZaTem157/detaljnije.aspx?post="+reader["idPost"].ToString();
                    postovi.Add(post);
                }
                return postovi;
            }
            catch (Exception exp)
            {
                HttpContext.Current.Trace.Warn("Greška", "Greška getPosts(nazivKategorije)", exp);
            }
            finally 
            {
                if (reader != null) reader.Close();
                if (conn != null && conn.State != ConnectionState.Closed) conn.Close();
            }
            return null;
        }
    }
}