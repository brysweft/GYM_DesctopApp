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
    public partial class FormSelTrainig : Form
    {
        public FormSelTrainig()
        {
            InitializeComponent();
        }

        private void FormSelTrainig_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SPORTTIMETABLE". При необходимости она может быть перемещена или удалена.
            this.sPORTTIMETABLETableAdapter.Fill(this.dataSet1.SPORTTIMETABLE);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long id = 0;

            try
            {
                id = long.Parse(sPORTTIMETABLEDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
            }
            SessionData.select_id = id;
            Close();
        }

        private void sPORTTIMETABLEDataGridView_DoubleClick(object sender, EventArgs e)
        {
            long id = 0;

            try
            {
                id = long.Parse(sPORTTIMETABLEDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
            }
            SessionData.select_id = id;
            Close();
        }
    }
}
