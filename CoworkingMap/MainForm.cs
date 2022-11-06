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
        List<Control> UserProfileList = new List<Control>();
        List<Control> StatisticList = new List<Control>();
        // создать массив мест
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
            pictureBoxUserPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxUserPic.Image = Image.FromFile("C:\\Users\\kjgug\\source\\repos\\CoworkingMap\\CoworkingMap\\images\\profilepic.jpg");
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

            // сделать массив элементов и их показывать и прятать
            UserProfileList.Add(pictureBoxUserPic);
            UserProfileList.Add(label1);
            UserProfileList.Add(label2);
            UserProfileList.Add(label3);
            UserProfileList.Add(label4);
            UserProfileList.Add(textBoxFIO);
            UserProfileList.Add(textBoxUserPhoneNumber);
            UserProfileList.Add(textBoxUserCurrentWorkPlace);
            UserProfileList.Add(textBoxUserEmail);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            baseform.Close();
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            if (pictureBoxMap.Visible)
                pictureBoxMap.Hide();
            ShowList(UserProfileList);
        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            if (UserProfileList[0].Visible)
                HideList(UserProfileList);
            else if (pictureBoxMap.Visible)
                pictureBoxMap.Hide();
        }

        private void pictureBoxMap_Click(object sender, EventArgs e)
        {
            //если попал на место(по координатам), то выводим его
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            if (UserProfileList[0].Visible) // если хотя бы одни элемент видел, значит все видимы, соответственно скрываем все элементы
                HideList(UserProfileList);

            pictureBoxMap.Show();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            if (UserProfileList[0].Visible)
                HideList(UserProfileList);
            else if (pictureBoxMap.Visible)
                pictureBoxMap.Hide();
        }

        private void HideList(List<Control> list)
        {
            foreach (Control item in list)
            {
                item.Hide();
            }
        }

        private void ShowList(List<Control> list)
        {
            foreach (Control item in list)
            {
                item.Show();
            }
        }
    }

    
}
