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
    public partial class StatisticsForm : Form
    {
        Form baseform;
        MainForm mainform;
        public StatisticsForm()
        {
            InitializeComponent();
        }

        public StatisticsForm(Form baseform, MainForm mainform)
        {
            InitializeComponent();
            this.baseform = baseform;
            this.mainform = mainform;
        }
        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void buttonMain_Click(object sender, EventArgs e)
        {
            this.Close();
            //mainform.Show();
        }

        private void StatisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainform.Show();
        }
    }
}
