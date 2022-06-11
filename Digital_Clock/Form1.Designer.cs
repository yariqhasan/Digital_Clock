namespace Digital_Clock
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
            this.IblTime = new System.Windows.Forms.Label();
            this.IblSecond = new System.Windows.Forms.Label();
            this.IblDate = new System.Windows.Forms.Label();
            this.IblDay = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // IblTime
            // 
            this.IblTime.AutoSize = true;
            this.IblTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IblTime.Font = new System.Drawing.Font("Quicksand Medium", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblTime.Location = new System.Drawing.Point(429, 83);
            this.IblTime.Name = "IblTime";
            this.IblTime.Size = new System.Drawing.Size(669, 323);
            this.IblTime.TabIndex = 0;
            this.IblTime.Text = "22:22";
            // 
            // IblSecond
            // 
            this.IblSecond.AutoSize = true;
            this.IblSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IblSecond.Font = new System.Drawing.Font("Quicksand Medium", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblSecond.Location = new System.Drawing.Point(1122, 214);
            this.IblSecond.Name = "IblSecond";
            this.IblSecond.Size = new System.Drawing.Size(148, 126);
            this.IblSecond.TabIndex = 1;
            this.IblSecond.Text = "22";
            // 
            // IblDate
            // 
            this.IblDate.AutoSize = true;
            this.IblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IblDate.Font = new System.Drawing.Font("Quicksand Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblDate.Location = new System.Drawing.Point(131, 438);
            this.IblDate.Name = "IblDate";
            this.IblDate.Size = new System.Drawing.Size(737, 163);
            this.IblDate.TabIndex = 2;
            this.IblDate.Text = "JUNE 11 2022";
            // 
            // IblDay
            // 
            this.IblDay.AutoSize = true;
            this.IblDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IblDay.Font = new System.Drawing.Font("Quicksand Medium", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IblDay.Location = new System.Drawing.Point(1048, 438);
            this.IblDay.Name = "IblDay";
            this.IblDay.Size = new System.Drawing.Size(624, 163);
            this.IblDay.TabIndex = 3;
            this.IblDay.Text = "SATURDAY";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1739, 732);
            this.Controls.Add(this.IblDay);
            this.Controls.Add(this.IblDate);
            this.Controls.Add(this.IblSecond);
            this.Controls.Add(this.IblTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IblTime;
        private System.Windows.Forms.Label IblSecond;
        private System.Windows.Forms.Label IblDate;
        private System.Windows.Forms.Label IblDay;
        private System.Windows.Forms.Timer timer;
    }
}

