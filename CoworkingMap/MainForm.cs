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
    public partial class MainForm : Form
    {
        Form baseform;
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(Form baseform)
        {
            InitializeComponent();
            this.baseform = baseform;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBoxMap.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMap.Image = Image.FromFile("C:\\Users\\kjgug\\source\\repos\\CoworkingMap\\CoworkingMap\\images\\ofmap1.jpg");
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            baseform.Close();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            UserProfile userProfileform = new UserProfile(baseform, this);
            userProfileform.Show();
            this.Hide();
        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm(baseform, this);
            statisticsForm.Show();
            this.Hide();
        }

        private void pictureBoxMap_Click(object sender, EventArgs e)
        {
            //если попал на место(по координатам), то выводим его
        }
    }

    
}
