using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biz
{
    /// <summary>
    /// Summary description for BAL
    /// </summary>
    public class BAL
    {
        public static List<Model.Kategorija> getKategorije() 
        {
            List<Model.Kategorija> kategorije = Data.DAL.getKategorije();
            foreach (Model.Kategorija kat in kategorije)
            {
                kat.nazivKategorije = kat.nazivKategorije;
            }
            return kategorije;
        }

        public static List<Model.Post> getPosts(string nazivKategorije) 
        {
            List<Model.Post> postovi = Data.DAL.getPosts(nazivKategorije);
            foreach (Model.Post post in postovi)
            {
                post.Naslov = post.Naslov;
            }
            return postovi;
        }
    }
}