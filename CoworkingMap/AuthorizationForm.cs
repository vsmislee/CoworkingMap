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
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "login" && textBoxPassword.Text == "password") // тут должна быть сверка данных из базы
            {
                MainForm newForm = new MainForm(this);
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверные логин или пароль!");
            }

           //this.Close();
        }

        private void AuthorizationForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
