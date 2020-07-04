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
    public partial class FormTimeTable : Form
    {
        public FormTimeTable()
        {
            InitializeComponent();
        }

        private void tIMETABLEBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void FormTimeTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SPORTTIMETABLE". При необходимости она может быть перемещена или удалена.
            this.sPORTTIMETABLETableAdapter.Fill(this.dataSet1.SPORTTIMETABLE);
        }
    }
}
