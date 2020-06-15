using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamportPass
{
    class Server
    {
        public int i { get; set; } // счетчик для подсчета числа сеансов аутентификации
        public List<Key> Keys { get; set; }
        public Server()
        {
            Keys = new List<Key>();
        }

        
    }
}
