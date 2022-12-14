using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace закупка
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void магазиныBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.магазиныBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.закупкаDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "закупкаDataSet.Магазины". При необходимости она может быть перемещена или удалена.
            this.магазиныTableAdapter.Fill(this.закупкаDataSet.Магазины);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ГЛАВНАЯ_СТРАНИЦА frm = new ГЛАВНАЯ_СТРАНИЦА();
            frm.Show();
            Hide();
        }
    }
}
