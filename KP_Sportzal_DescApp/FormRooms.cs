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
    public partial class FormRooms : Form
    {
        public FormRooms()
        {
            InitializeComponent();
        }

        private void rOOMSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
                this.rOOMSBindingSource.EndEdit();
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

        private void FormRooms_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.ROOMS". При необходимости она может быть перемещена или удалена.
            this.rOOMSTableAdapter.Fill(this.dataSet1.ROOMS);

        }
    }
}
