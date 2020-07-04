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
    public partial class FormSelTrener : Form
    {
        public FormSelTrener()
        {
            InitializeComponent();
        }

        private void FormSelTrener_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.TRAINERS". При необходимости она может быть перемещена или удалена.
            this.tRAINERSTableAdapter.Fill(this.dataSet1.TRAINERS);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            long id = 0;

            try
            {
                id = long.Parse(tRAINERSDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
            }
            SessionData.select_id = id;
            Close();
        }

        private void sPORTTRAINERSListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tRAINERSDataGridView_DoubleClick(object sender, EventArgs e)
        {
            long id = 0;

            try
            {
                id = long.Parse(tRAINERSDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
            }
            SessionData.select_id = id;
            Close();
        }
    }
}
