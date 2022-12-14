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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void адреса_магазиновBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.адреса_магазиновBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.закупкаDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "закупкаDataSet.Адреса_магазинов". При необходимости она может быть перемещена или удалена.
            this.адреса_магазиновTableAdapter.Fill(this.закупкаDataSet.Адреса_магазинов);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ГЛАВНАЯ_СТРАНИЦА frm = new ГЛАВНАЯ_СТРАНИЦА();
            frm.Show();
            Hide();
        }
    }
}
