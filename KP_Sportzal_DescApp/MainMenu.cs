using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KP_Sportzal_DescApp
{
    public partial class MainMenu : Form
    {
        Boolean avtorization = false;
        public Boolean Avtorization { get => avtorization; set => avtorization = value; }

        public MainMenu()
        {
            InitializeComponent();
        }

        private void списокКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClients Form = (FormClients)Application.OpenForms["FormClients"];
            if (Form == null)
            {
                FormClients newForm = new FormClients(); 
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
                
        }
         

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            login formlogin = new login();
            formlogin.ShowDialog();

            Text = "Спортивный зал / Пользователь: " + SessionData.user;

            if (SessionData.role != "Administrator")
            {
                администрированиеToolStripMenuItem.Visible = false;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void абонементыКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbonements Form = (FormAbonements)Application.OpenForms["FormAbonements"];
            if (Form == null)
            {
                FormAbonements newForm = new FormAbonements();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }

        private void записиКлиентовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRecords Form = (FormRecords)Application.OpenForms["FormRecords"];
            if (Form == null)
            {
                FormRecords newForm = new FormRecords();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }

        private void расписаниеЗанятийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTimeTable Form = (FormTimeTable)Application.OpenForms["FormTimeTable"];
            if (Form == null)
            {
                FormTimeTable newForm = new FormTimeTable();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }

        private void секцииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSection Form = (FormSection)Application.OpenForms["FormSection"];
            if (Form == null)
            {
                FormSection newForm = new FormSection();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }

        private void помещенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRooms Form = (FormRooms)Application.OpenForms["FormRooms"];
            if (Form == null)
            {
                FormRooms newForm = new FormRooms();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }

        private void тренерыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormTreiners Form = (FormTreiners)Application.OpenForms["FormTreiners"];
            if (Form == null)
            {
                FormTreiners newForm = new FormTreiners();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }

        private void клиентыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormClients Form = (FormClients)Application.OpenForms["FormClients"];
            if (Form == null)
            {
                FormClients newForm = new FormClients();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }

        private void тренерыToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormTreiners Form = (FormTreiners)Application.OpenForms["FormTreiners"];
            if (Form == null)
            {
                FormTreiners newForm = new FormTreiners();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }

        private void секцииToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormSection Form = (FormSection)Application.OpenForms["FormSection"];
            if (Form == null)
            {
                FormSection newForm = new FormSection();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }

        private void помещенияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormRooms Form = (FormRooms)Application.OpenForms["FormRooms"];
            if (Form == null)
            {
                FormRooms newForm = new FormRooms();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers Form = (FormUsers)Application.OpenForms["FormUsers"];
            if (Form == null)
            {
                FormUsers newForm = new FormUsers();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }

        private void выписатьАбонементКлиентуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddAbonement Form = (FormAddAbonement)Application.OpenForms["FormAddAbonement"];
            if (Form == null)
            {
                FormAddAbonement newForm = new FormAddAbonement();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }

        private void добавитьКлиентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddClient Form = (FormAddClient)Application.OpenForms["FormAddClient"];
            if (Form == null)
            {
                FormAddClient newForm = new FormAddClient();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }

        private void добавитьЗанятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddTraning Form = (FormAddTraning)Application.OpenForms["FormAddTraning"];
            if (Form == null)
            {
                FormAddTraning newForm = new FormAddTraning();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }

        private void записатьКлиентаНаЗанятиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddRecord Form = (FormAddRecord)Application.OpenForms["FormAddRecord"];
            if (Form == null)
            {
                FormAddRecord newForm = new FormAddRecord();
                newForm.MdiParent = this;
                newForm.Show();
            }
            else
            {
                Form.Activate();
            }
        }
    }
}
