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
    public partial class АВТОРИЗАЦИЯ : Form
    {
        public АВТОРИЗАЦИЯ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Login = "Mariya";
            var Password = "12345";
            if ((textBox1.Text == Login) && (textBox2.Text == Password))
            {
                ГЛАВНАЯ_СТРАНИЦА newform = new ГЛАВНАЯ_СТРАНИЦА();
                newform.Show();
            }
            else
            {
                button1.Text = "Ошибка";
            }
        }
    }
}
