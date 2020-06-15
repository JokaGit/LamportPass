using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace LamportPass
{
    public partial class MainForm : Form
    {
        List<Key> Keys;
        Server server;
        string secret;
        Processing pr = new Processing();
        MD5 md5 = MD5.Create();

        public MainForm()
        {
            InitializeComponent();

            server = new Server();
            Keys = new List<Key>();

            rtbServerLog.AppendText(DateTime.Now.ToString("HH:mm:ss") + " - Инициализация сервера успешно проведена.\n");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRandomSecret_Click(object sender, EventArgs e)
        {
            secret = new Random().Next(Int32.MaxValue).ToString("x2") + (new Random().Next(Int32.MaxValue / 3) * 2).ToString("x2");
            tbSecret.Text = secret;

            rtbKeys.Clear();
            Keys.Clear();

            btnGenerateKeys.Enabled = true;
        }

        private void btnGenerateKeys_Click(object sender, EventArgs e)
        {
            if(tbSecret.Text == "")
            {
                MessageBox.Show("Введите секрет");
                return;
            }
            Keys.Add(new Key(1, pr.GetMd5Hash(md5, secret)));

            int KeysCount = Keys.Count;

            rtbKeys.AppendText(String.Format("{0} - {1}\n", KeysCount, Keys.Last().Hash));

            for (int i = KeysCount + 1; i < KeysCount + Convert.ToInt32(tbNumOfKeys.Text); i++)
            {
                Keys.Add(new Key(i, pr.GetMd5Hash(md5, Keys.Last().Hash)));
                rtbKeys.AppendText(String.Format("{0} - {1}\n", i, Keys.Last().Hash));
            }
        }

        private void btnSendToServer_Click(object sender, EventArgs e)
        {
            if (Keys.Count == 0)
            {
                MessageBox.Show("Ключи не сгенерированы, нечего отправлять на сервер");
                return;
            }

            server.i = 1;
            server.Keys = Keys;

            rtbServerLog.AppendText(String.Format("\n{0} - На сервер получено {1} ключей. Счетчик количества сеансов аутентификации установлен в {2}. \n",
                DateTime.Now.ToString("HH:mm:ss"), server.Keys.Count, server.i));

            btnAuth.Enabled = true;
            panel3.Enabled = true;
            numSession.Maximum = Keys.Count - 1;

            tbClientKey.Text = String.Format("Введите {0} ключ", Keys.Count - numSession.Value);
            tbClientKey.ForeColor = Color.Gray;
        }

        private void btnAuth_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5;

            DataTransfer dt = new DataTransfer();

            dt.data = new List<object>();
            dt.data.Add(Keys);
            dt.data.Add(server);
            dt.data.Add(secret);

            AuthForm af = new AuthForm(dt);
            af.ShowDialog();

            this.Opacity = 1;
        }

        private void btnManualAuth_Click(object sender, EventArgs e)
        {
            if (tbClientKey.Text == "")
            {
                MessageBox.Show("Введите ключ клиента");
                return;
            }

            server.i = (int)numSession.Value;


            string ClientKey = tbClientKey.Text;

            rtbServerLog.AppendText(String.Format("\n{0} - Получен ключ клиента ({1}) и передан серверу.\n",
                DateTime.Now.ToString("HH:mm:ss"), ClientKey)); //ClientKey = H(secret)^N-i

            string ServerCheckKey = pr.GetMd5Hash(md5, ClientKey); // H(ClientKey) = H(secret)^N-i+1

            rtbServerLog.AppendText(String.Format("{0} - Сервер хеширует ключ клиента: ({1}) \nи сверяет результат с хранящимся значением {2} ключа: ({3}).\n",
                DateTime.Now.ToString("HH:mm:ss"), ServerCheckKey, Keys.Count - server.i + 1, server.Keys[Keys.Count - server.i].Hash));


            if (ServerCheckKey == server.Keys[Keys.Count - server.i].Hash)
            {
                server.i++;
                numSession.Maximum++;
                numSession.Value = server.i;
                rtbServerLog.AppendText(String.Format("{0} - Ключи совпали. Сервер увеличивает счетчик сеансов аутентификации на 1: {1}\n",
                DateTime.Now.ToString("HH:mm:ss"), server.i));
            }
            else
            {
                rtbServerLog.AppendText(String.Format("{0} - Ключи не совпали. Попытка аутентификации провалена.\n",
                DateTime.Now.ToString("HH:mm:ss")));
            }
        }

        private void rtbServerLog_TextChanged(object sender, EventArgs e)
        {
            rtbServerLog.SelectionStart = rtbServerLog.Text.Length;
            rtbServerLog.ScrollToCaret();
        }

        private void numSession_ValueChanged(object sender, EventArgs e)
        {
            tbClientKey.Text = String.Format("Введите {0} ключ", Keys.Count - numSession.Value);
            tbClientKey.ForeColor = Color.Gray;
        }

        private void tbClientKey_Enter(object sender, EventArgs e)
        {
            tbClientKey.Text = null;
            tbClientKey.ForeColor = Color.Black;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.ShowDialog();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Приложение разработано Евстратовым Евгением\nevgen_jr@mail.ru\nКубГТУ, 2018г.", "О программе", MessageBoxButtons.OK ,MessageBoxIcon.Asterisk);
        }
    }
}
