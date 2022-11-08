using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoworkingMap
{
    public partial class AuthorizationForm : Form
    {
        Member member = new Member("Михаил", "Кошурников", "Николаевич", "Разработчик", "mnkosh@list.ru", "+79822542551", 7); // на самом деле данные будут из базы загружаться
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "login" && textBoxPassword.Text == "password") // тут должна быть сверка данных из базы
            {
                MainForm newForm = new MainForm(this, member);
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверные логин или пароль!");
            }
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
