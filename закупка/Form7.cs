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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void контактное_лицоBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.контактное_лицоBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.закупкаDataSet);

        }

        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "закупкаDataSet.Контактное_лицо". При необходимости она может быть перемещена или удалена.
            this.контактное_лицоTableAdapter.Fill(this.закупкаDataSet.Контактное_лицо);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ГЛАВНАЯ_СТРАНИЦА frm = new ГЛАВНАЯ_СТРАНИЦА();
            frm.Show();
            Hide();
        }
    }
}
