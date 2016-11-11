using System;

namespace Model
{
    /// <summary>
    /// Summary description for Post
    /// </summary>
    public class Post
    {
        private string _Naslov;
        private string _LinkKaPostu;

        public string Naslov
        {
            get { return _Naslov; }
            set { _Naslov = value; }
        }

        public string LinkKaPostu
        {
            get { return _LinkKaPostu; }
            set { _LinkKaPostu = value; }
        }
    }
}