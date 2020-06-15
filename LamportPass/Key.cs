using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamportPass
{
    class Key
    {
        public int i { get; set; }
        public string Hash { get; set; }
        public Key(int i, string hash)
        {
            this.i = i;
            Hash = hash;
        }
    }
}
