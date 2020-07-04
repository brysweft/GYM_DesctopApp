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
    public partial class FormSelSection : Form
    {
        public FormSelSection()
        {
            InitializeComponent();
        }

        private void FormSelSection_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SECTIONS". При необходимости она может быть перемещена или удалена.
            this.sECTIONSTableAdapter.Fill(this.dataSet1.SECTIONS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            long id = 0;

            try
            {
                id = long.Parse(sECTIONSDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
            }
            SessionData.select_id = id;
            Close();
        }

        private void sECTIONSDataGridView_DoubleClick(object sender, EventArgs e)
        {
            long id = 0;

            try
            {
                id = long.Parse(sECTIONSDataGridView.CurrentRow.Cells[0].Value.ToString());
            }
            catch
            {
            }
            SessionData.select_id = id;
            Close();
        }
    }
}
