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
    public partial class FormAddAbonement : Form
    {
        public FormAddAbonement()
        {
            InitializeComponent();
        }

        private void aBONEMENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
                this.aBONEMENTSBindingSource.EndEdit();
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

        private void FormAddAbonement_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SPORTCUSTUMERS". При необходимости она может быть перемещена или удалена.
            this.sPORTCUSTUMERSTableAdapter.Fill(this.dataSet1.SPORTCUSTUMERS);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ABONEMENTS". При необходимости она может быть перемещена или удалена.
            this.aBONEMENTSTableAdapter.Fill(this.dataSet1.ABONEMENTS);

            updatecCustimerText();
        }

        private void updatecCustimerText()
        {
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
        }

            private void kLIENTComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            updatecCustimerText();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSelClient f = new FormSelClient();
            f.ShowDialog();

            kLIENTComboBox.SelectedValue = SessionData.select_id;
            kLIENTComboBox.Text = SessionData.select_id.ToString();
        }

        private void kLIENTComboBox_TextUpdate(object sender, EventArgs e)
        {
            updatecCustimerText();
        }

        private void kLIENTComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updatecCustimerText();
        }

    }
}
