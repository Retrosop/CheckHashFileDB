using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ShowHashFileNew
{
    internal class Hash
    {
        private string name;

        private long size;

        private string typ;

        private string md5hash;

        private string sha256hash;

   

        public string Name { 
            get { return name; }
            set { name = value; }
        }

        public long Size
        {
            get { return size; }
            set { size = value; }
        }

        public string Typ
        {
            get { return typ; }
            set { typ = value; }
        }

        public string Md5hash
        {
            get { return md5hash; }
            set { md5hash = value; }
        }

        public string Sha256hash
        {
            get { return sha256hash; }
            set { sha256hash = value; }
        }
      

        public Hash(string name, long size, string typ, string md5hash, string sha256hash)
        {
            this.Name = name;
            this.Size = size;
            this.typ = typ;
            this.md5hash = md5hash;
            this.sha256hash = sha256hash;

        }    
    }
}
