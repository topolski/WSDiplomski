using System;

namespace Model
{
    /// <summary>
    /// Summary description for Kategorija
    /// </summary>
    public class Kategorija
    {
        private string _idKategorije;
        private string _nazivKategorije;

        public string idKategorije
        {
            get { return _idKategorije; }
            set { _idKategorije = value; }
        }

        public string nazivKategorije
        {
            get { return _nazivKategorije; }
            set { _nazivKategorije = value; }
        }
    }
}