namespace SendToPath
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.notifyInfo = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerClose = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.radioMe = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length of time to display tooltips in the taskbar";
            // 
            // notifyInfo
            // 
            this.notifyInfo.BalloonTipText = "Add to Path Info";
            this.notifyInfo.BalloonTipTitle = "Add to Path";
            this.notifyInfo.Icon = global::SendToPath.Properties.Resources.Send_To_Path_Icon;
            this.notifyInfo.Text = "Add to Path";
            this.notifyInfo.Visible = true;
            // 
            // timerClose
            // 
            this.timerClose.Interval = 5000;
            this.timerClose.Tick += new System.EventHandler(this.timerClose_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(430, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Display popup notifications when an action is performed?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(445, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autoclose the application once it adds an item to %PATH%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(268, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "* This will not prevent the application from working at all";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(394, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Keep the program open and idle in the system tray?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(347, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "* Not neccessary, the only benefit is being able to see this options dialog";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14F);
            this.label7.Location = new System.Drawing.Point(92, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "One time application setup";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(297, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Add this program to the SendTo menu.";
            // 
            // radioAll
            // 
            this.radioAll.AutoSize = true;
            this.radioAll.Location = new System.Drawing.Point(96, 72);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(81, 17);
            this.radioAll.TabIndex = 8;
            this.radioAll.TabStop = true;
            this.radioAll.Text = "For all users";
            this.radioAll.UseVisualStyleBackColor = true;
            // 
            // radioMe
            // 
            this.radioMe.AutoSize = true;
            this.radioMe.Checked = true;
            this.radioMe.Location = new System.Drawing.Point(196, 72);
            this.radioMe.Name = "radioMe";
            this.radioMe.Size = new System.Drawing.Size(133, 17);
            this.radioMe.TabIndex = 9;
            this.radioMe.TabStop = true;
            this.radioMe.Text = "Only for me (username)";
            this.radioMe.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 335);
            this.Controls.Add(this.radioMe);
            this.Controls.Add(this.radioAll);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = global::SendToPath.Properties.Resources.Send_To_Path_Icon;
            this.Name = "Form1";
            this.Text = "Simple SendTo Path .5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NotifyIcon notifyInfo;
        private System.Windows.Forms.Timer timerClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.RadioButton radioMe;
    }
}

