
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1739, 945);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMain;
        private System.Windows.Forms.Button buttonProfile;
        private System.Windows.Forms.Button buttonStatistic;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonContacts;
        private System.Windows.Forms.PictureBox pictureBoxMap;
       

    }
}