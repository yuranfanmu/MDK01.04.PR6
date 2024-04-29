namespace MDK01._04.PR6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            btnStartStop = new Button();
            txtTime = new TextBox();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 16F);
            lblTimer.Location = new Point(32, 41);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(119, 37);
            lblTimer.TabIndex = 0;
            lblTimer.Text = "00:00:00";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStartStop
            // 
            btnStartStop.Font = new Font("Segoe UI", 16F);
            btnStartStop.Location = new Point(167, 33);
            btnStartStop.Name = "btnStartStop";
            btnStartStop.Size = new Size(272, 85);
            btnStartStop.TabIndex = 1;
            btnStartStop.Text = "Старт";
            btnStartStop.UseVisualStyleBackColor = true;
            btnStartStop.Click += btnStartStop_Click;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(32, 91);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(125, 27);
            txtTime.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 130);
            Controls.Add(txtTime);
            Controls.Add(btnStartStop);
            Controls.Add(lblTimer);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Таймер";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblTimer;
        private Button btnStartStop;
        private TextBox txtTime;
    }
}
