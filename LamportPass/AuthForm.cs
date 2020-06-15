using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace LamportPass
{

    public partial class AuthForm : Form
    {
        List<Key> Keys;
        Server server;
        string secret;
        Processing pr = new Processing();
        MD5 md5 = MD5.Create();
        public AuthForm(DataTransfer dt)
        {
            InitializeComponent();
            this.Keys = (List<Key>)dt.data[0];
            this.server = (Server)dt.data[1];
            this.secret = (string)dt.data[2];
            numSession.Maximum = Keys.Count - 1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDoAuth_Click(object sender, EventArgs e)
        {
            if(numSession.Value >= Keys.Count)
            {
                MessageBox.Show("Ключи для аутентификации закончились, требуется генерация новых.");
                return;
            }
            server.i = (int)numSession.Value;

            rtbServerLog.AppendText(String.Format("{0} - Сервер высылает клиенту число {1}. Клиент производит хеширование секрета {2} раз.\n",
                DateTime.Now.ToString("HH:mm:ss"), server.i, Keys.Count - server.i));

            string ClientKey = pr.GetMd5Hash(md5, secret);
            for (int i = 1; i < Keys.Count - server.i; i++)
            {
                ClientKey = pr.GetMd5Hash(md5, ClientKey);
            }
            rtbServerLog.AppendText(String.Format("{0} - Получен ключ клиента ({1}) и передан серверу.\n",
                DateTime.Now.ToString("HH:mm:ss"), ClientKey)); //ClientKey = H(secret)^N-i

            string ServerCheckKey = pr.GetMd5Hash(md5, ClientKey); // H(ClientKey) = H(secret)^N-i+1

            rtbServerLog.AppendText(String.Format("{0} - Сервер еще раз хеширует ключ клиента: ({1}) \nи сверяет результат с хранящимся значением {2} ключа: ({3}).\n",
                DateTime.Now.ToString("HH:mm:ss"), ServerCheckKey, Keys.Count - server.i + 1, server.Keys[Keys.Count - server.i].Hash));

            
            if (ServerCheckKey == server.Keys[Keys.Count - server.i].Hash)
            {
                server.i++;
                numSession.Minimum = server.i;

                rtbServerLog.AppendText(String.Format("{0} - Ключи совпали. Сервер увеличивает счетчик сеансов аутентификации на 1: {1}\n\n",
                DateTime.Now.ToString("HH:mm:ss"), server.i));
            }
            else
            {
                rtbServerLog.AppendText(String.Format("{0} - Ключи не совпали. Попытка аутентификации провалена.\n\n",
                DateTime.Now.ToString("HH:mm:ss")));
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {

        }
    }
}
