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
    public partial class FormAbonements : Form
    {
        public FormAbonements()
        {
            InitializeComponent();
        }

        private void aBONEMENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }

        private void Abonements_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SPORTABONEMENT". При необходимости она может быть перемещена или удалена.
            this.sPORTABONEMENTTableAdapter.Fill(this.dataSet1.SPORTABONEMENT);
        }
    }
}
