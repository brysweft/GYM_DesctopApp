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
    public partial class FormAddTraning : Form
    {
        public FormAddTraning()
        {
            InitializeComponent();
        }

        private void tIMETABLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
                this.tIMETABLEBindingSource.EndEdit();
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

        private void FormAddTraning_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ROOMS". При необходимости она может быть перемещена или удалена.
            this.rOOMSTableAdapter.Fill(this.dataSet1.ROOMS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SECTIONS". При необходимости она может быть перемещена или удалена.
            this.sECTIONSTableAdapter.Fill(this.dataSet1.SECTIONS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SPORTTRAINERS". При необходимости она может быть перемещена или удалена.
            this.sPORTTRAINERSTableAdapter.Fill(this.dataSet1.SPORTTRAINERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.TIMETABLE". При необходимости она может быть перемещена или удалена.
            this.tIMETABLETableAdapter.Fill(this.dataSet1.TIMETABLE);

            updateComboText();

        }

        private void updateComboText()
        {

            // тренер
            textBox1.Text = "";
            long id = 0;

            try
            {
                id = long.Parse(tRAINERComboBox.Text);
            }
            catch
            {
            }

            var Результат = dataSet1.SPORTTRAINERS.Where(p => p.KLIENT_ID == id);

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

            // секция

            textBox2.Text = "";
            id = 0;

            try
            {
                id = long.Parse(sECTIONComboBox.Text);
            }
            catch
            {
            }

            var Результат2 = dataSet1.SECTIONS.Where(p => p.ID == id);

            if (Результат2.Count() == 0)
            {

            }
            else
            {
                foreach (var x in Результат2)
                {
                    textBox2.Text = x.NAME;
                }
            }


            // помещение

            textBox3.Text = "";
            id = 0;

            try
            {
                id = long.Parse(rOOMComboBox.Text);
            }
            catch
            {
            }

            var Результат3 = dataSet1.ROOMS.Where(p => p.ID == id);

            if (Результат3.Count() == 0)
            {

            }
            else
            {
                foreach (var x in Результат3)
                {
                    textBox3.Text = x.NAME;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSelTrener f = new FormSelTrener();
            f.ShowDialog();

            tRAINERComboBox.SelectedValue = SessionData.select_id;
            tRAINERComboBox.Text = SessionData.select_id.ToString();
        }

        private void tRAINERComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateComboText();
        }

        private void sECTIONComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateComboText();
        }

        private void rOOMComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateComboText();
        }

        private void tRAINERComboBox_TextUpdate(object sender, EventArgs e)
        {
            updateComboText();
        }

        private void sECTIONComboBox_TextUpdate(object sender, EventArgs e)
        {
            updateComboText();
        }

        private void rOOMComboBox_TextUpdate(object sender, EventArgs e)
        {
            updateComboText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSelSection f = new FormSelSection();
            f.ShowDialog();

            sECTIONComboBox.SelectedValue = SessionData.select_id;
            sECTIONComboBox.Text = SessionData.select_id.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSelRoom f = new FormSelRoom();
            f.ShowDialog();

            rOOMComboBox.SelectedValue = SessionData.select_id;
            rOOMComboBox.Text = SessionData.select_id.ToString();
        }
    }
}
