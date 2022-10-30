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
    public partial class UserProfile : Form
    {
        Form baseform;
        MainForm mainForm;
        public UserProfile()
        {
            InitializeComponent();
        }

        public UserProfile(Form baseform, MainForm mainForm)
        {
            InitializeComponent();
            this.baseform = baseform;
            this.mainForm = mainForm;
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            this.Close();
            //mainForm.Show();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {
            pictureBoxUserPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUserPic.Image = Image.FromFile("C:\\Users\\kjgug\\source\\repos\\CoworkingMap\\CoworkingMap\\images\\profilepic.jpg");
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void UserProfile_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainForm.Show();
        }
    }
}
