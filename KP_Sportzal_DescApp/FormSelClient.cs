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
    public partial class FormSelClient : Form
    {
        public FormSelClient()
        {
            InitializeComponent();
        }

        private void FormSelClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.CUSTOMERS". При необходимости она может быть перемещена или удалена.
            this.cUSTOMERSTableAdapter.Fill(this.dataSet1.CUSTOMERS);
        }



        private void button1_Click(object sender, EventArgs e)
        {
            long id = 0;

            try
            {
                // id = long.Parse(cUSTOMERSDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                id = long.Parse(cUSTOMERSDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
            }
            SessionData.select_id = id;
            Close();
        }

        private void cUSTOMERSDataGridView_DoubleClick(object sender, EventArgs e)
        {
            long id = 0;

            try
            {
                //id = long.Parse(cUSTOMERSDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                id = long.Parse(cUSTOMERSDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
            }
            SessionData.select_id = id;
            Close();
        }
    }
}
