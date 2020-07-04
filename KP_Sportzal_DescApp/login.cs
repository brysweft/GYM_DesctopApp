using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP_Sportzal_DescApp
{

    public partial class login : Form
    {


        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //вход
            string user_name = comboBox1.Text;
            string passwd = textBox2.Text;
            
            var SelectUser = dataSet1.SPORTUSERS.Where(p => p.NAME == user_name);

            if (SelectUser.Count() == 0)
            {// вход неудачный
                label3.Text = "Неверный логин";
            }
            else // вход успешный
            {
                foreach (var x in SelectUser)
                {
                    if (x.PASSWORD == passwd) {
                        SessionData.Avtorization = true;
                        SessionData.user = user_name;
                        SessionData.role = x.ROLE;

                        sPORTSESSIONSTableAdapter.Connection.Open();

                        //записывается сессия
                        OracleCommand addSession = new OracleCommand("INSERT INTO SYSTEM.SPORTSESSIONS (USERID,ACTIV,DATELOGIN, ID, TYPE, IP) VALUES (:userId,:активность,:датавхода, null, :типподключения, :IP)", sPORTSESSIONSTableAdapter.Connection);

                        addSession.Parameters.Add("@userId", x.ID);
                        addSession.Parameters.Add("@активность", 1);
                        addSession.Parameters.Add(":датавхода", DateTime.Now);
                        addSession.Parameters.Add(":типподключения", "desctop");
                        addSession.Parameters.Add(":IP", System.Net.Dns.GetHostName());

                        addSession.ExecuteNonQuery();

                        sPORTSESSIONSTableAdapter.Connection.Close();

                        Close();
                    }
                }
            }
            label3.Text = "Неверный пароль!";
        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SPORTSESSIONS". При необходимости она может быть перемещена или удалена.
            this.sPORTSESSIONSTableAdapter.Fill(this.dataSet1.SPORTSESSIONS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SPORTUSERS". При необходимости она может быть перемещена или удалена.
            this.sPORTUSERSTableAdapter.Fill(this.dataSet1.SPORTUSERS);

        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!SessionData.Avtorization)
            {
                Application.Exit();
            }
        }


        
    }
}
