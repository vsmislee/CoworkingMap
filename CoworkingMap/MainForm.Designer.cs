
namespace CoworkingMap
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMain = new System.Windows.Forms.Button();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonStatistic = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonContacts = new System.Windows.Forms.Button();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.textBoxUserCurrentWorkPlace = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxUserEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUserPhoneNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxUserPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMain
            // 
            this.buttonMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonMain.FlatAppearance.BorderSize = 0;
            this.buttonMain.Location = new System.Drawing.Point(107, 219);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(210, 30);
            this.buttonMain.TabIndex = 0;
            this.buttonMain.Text = "Главная";
            this.buttonMain.UseVisualStyleBackColor = false;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // buttonProfile
            // 
            this.buttonProfile.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonProfile.Location = new System.Drawing.Point(308, 219);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(226, 30);
            this.buttonProfile.TabIndex = 1;
            this.buttonProfile.Text = "Личный кабинет";
            this.buttonProfile.UseVisualStyleBackColor = false;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonStatistic
            // 
            this.buttonStatistic.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonStatistic.Location = new System.Drawing.Point(529, 219);
            this.buttonStatistic.Name = "buttonStatistic";
            this.buttonStatistic.Size = new System.Drawing.Size(210, 30);
            this.buttonStatistic.TabIndex = 2;
            this.buttonStatistic.Text = "Статистика";
            this.buttonStatistic.UseVisualStyleBackColor = false;
            this.buttonStatistic.Click += new System.EventHandler(this.buttonStatistic_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonHistory.Location = new System.Drawing.Point(736, 219);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(250, 30);
            this.buttonHistory.TabIndex = 3;
            this.buttonHistory.Text = "История бронирования";
            this.buttonHistory.UseVisualStyleBackColor = false;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonContacts
            // 
            this.buttonContacts.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonContacts.Location = new System.Drawing.Point(982, 219);
            this.buttonContacts.Name = "buttonContacts";
            this.buttonContacts.Size = new System.Drawing.Size(207, 30);
            this.buttonContacts.TabIndex = 4;
            this.buttonContacts.Text = "Контакты";
            this.buttonContacts.UseVisualStyleBackColor = false;
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMap.Location = new System.Drawing.Point(107, 297);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(1591, 577);
            this.pictureBoxMap.TabIndex = 5;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Click += new System.EventHandler(this.pictureBoxMap_Click);
            // 
            // textBoxUserCurrentWorkPlace
            // 
            this.textBoxUserCurrentWorkPlace.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxUserCurrentWorkPlace.Location = new System.Drawing.Point(281, 707);
            this.textBoxUserCurrentWorkPlace.Name = "textBoxUserCurrentWorkPlace";
            this.textBoxUserCurrentWorkPlace.ReadOnly = true;
            this.textBoxUserCurrentWorkPlace.Size = new System.Drawing.Size(182, 22);
            this.textBoxUserCurrentWorkPlace.TabIndex = 28;
            this.textBoxUserCurrentWorkPlace.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 710);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Текущее бронирование:";
            this.label4.Visible = false;
            // 
            // textBoxUserEmail
            // 
            this.textBoxUserEmail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxUserEmail.Location = new System.Drawing.Point(159, 672);
            this.textBoxUserEmail.Name = "textBoxUserEmail";
            this.textBoxUserEmail.ReadOnly = true;
            this.textBoxUserEmail.Size = new System.Drawing.Size(205, 22);
            this.textBoxUserEmail.TabIndex = 26;
            this.textBoxUserEmail.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 672);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Email:";
            this.label3.Visible = false;
            // 
            // textBoxUserPhoneNumber
            // 
            this.textBoxUserPhoneNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxUserPhoneNumber.Location = new System.Drawing.Point(186, 635);
            this.textBoxUserPhoneNumber.Name = "textBoxUserPhoneNumber";
            this.textBoxUserPhoneNumber.ReadOnly = true;
            this.textBoxUserPhoneNumber.Size = new System.Drawing.Size(178, 22);
            this.textBoxUserPhoneNumber.TabIndex = 24;
            this.textBoxUserPhoneNumber.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 635);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Телефон:";
            this.label2.Visible = false;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFIO.Location = new System.Drawing.Point(159, 598);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.ReadOnly = true;
            this.textBoxFIO.Size = new System.Drawing.Size(205, 22);
            this.textBoxFIO.TabIndex = 22;
            this.textBoxFIO.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 601);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "ФИО:";
            this.label1.Visible = false;
            // 
            // pictureBoxUserPic
            // 
            this.pictureBoxUserPic.Location = new System.Drawing.Point(107, 297);
            this.pictureBoxUserPic.Name = "pictureBoxUserPic";
            this.pictureBoxUserPic.Size = new System.Drawing.Size(210, 275);
            this.pictureBoxUserPic.TabIndex = 20;
            this.pictureBoxUserPic.TabStop = false;
            this.pictureBoxUserPic.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1739, 945);
            this.Controls.Add(this.textBoxUserCurrentWorkPlace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxUserEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUserPhoneNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxUserPic);
            this.Controls.Add(this.pictureBoxMap);
            this.Controls.Add(this.buttonContacts);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonStatistic);
            this.Controls.Add(this.buttonProfile);
            this.Controls.Add(this.buttonMain);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonContacts;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.TextBox textBoxUserCurrentWorkPlace;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUserEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUserPhoneNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxUserPic;
    }
}