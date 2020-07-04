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
    public partial class FormAddRecord : Form
    {
        public FormAddRecord()
        {
            InitializeComponent();
        }

        private void rECORDSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка заполнения" + ex.Message);
            }
            try
            {
                this.rECORDSBindingSource.EndEdit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка редактирования" + ex.Message);
            }
            try
            {
                this.tableAdapterManager.UpdateAll(this.dataSet1);
                MessageBox.Show("Успешно сохранено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка изменения в БД: " + ex.Message);
            }

        }

        private void FormAddRecord_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SPORTTIMETABLE". При необходимости она может быть перемещена или удалена.
            this.sPORTTIMETABLETableAdapter.Fill(this.dataSet1.SPORTTIMETABLE);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SPORTRECORDS". При необходимости она может быть перемещена или удалена.
            this.sPORTRECORDSTableAdapter.Fill(this.dataSet1.SPORTRECORDS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SPORTCUSTUMERS". При необходимости она может быть перемещена или удалена.
            this.sPORTCUSTUMERSTableAdapter.Fill(this.dataSet1.SPORTCUSTUMERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.RECORDS". При необходимости она может быть перемещена или удалена.
            this.rECORDSTableAdapter.Fill(this.dataSet1.RECORDS);

            updatecCustimerText();
        }

        private void updatecCustimerText()
        {

            //клиент
            textBox1.Text = "";
            long id = 0;

            try
            {
                id = long.Parse(kLIENTComboBox.Text);
            }
            catch
            {
            }

            var Результат = dataSet1.SPORTCUSTUMERS.Where(p => p.KLIENT_ID == id);

            if (Результат.Count() == 0)
            {

            }
            else
            {
                foreach (var x in Результат)
                {
                    textBox1.Text = x.KLIENT;
                }
            }

            //занятия
            textBox2.Text = "";
            id = 0;

            try
            {
                id = long.Parse(tRAININGComboBox.Text);
            }
            catch
            {
            }

            var Результат2 = dataSet1.SPORTTIMETABLE.Where(p => p.TRAINING_ID == id);

            if (Результат2.Count() == 0)
            {

            }
            else
            {
                foreach (var x in Результат2)
                {
                    textBox2.Text = x.TEXT;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSelClient f = new FormSelClient();
            f.ShowDialog();

            kLIENTComboBox.SelectedValue = SessionData.select_id;
            kLIENTComboBox.Text = SessionData.select_id.ToString();
        }

        private void kLIENTComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatecCustimerText();
        }

        private void kLIENTComboBox_TextUpdate(object sender, EventArgs e)
        {
            updatecCustimerText();
        }

        private void tRAININGComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatecCustimerText();
        }

        private void tRAININGComboBox_TextUpdate(object sender, EventArgs e)
        {
            updatecCustimerText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSelTrainig f = new FormSelTrainig();
            f.ShowDialog();

            tRAININGComboBox.SelectedValue = SessionData.select_id;
            tRAININGComboBox.Text = SessionData.select_id.ToString();
        }
    }
}
