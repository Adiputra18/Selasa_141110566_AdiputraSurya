namespace Latihan1_1
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
            this.Kalender = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Hari = new System.Windows.Forms.DateTimePicker();
            this.mini = new System.Windows.Forms.VScrollBar();
            this.maks = new System.Windows.Forms.VScrollBar();
            this.min = new System.Windows.Forms.Label();
            this.max = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Kalender.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Kalender
            // 
            this.Kalender.Controls.Add(this.tabPage1);
            this.Kalender.Controls.Add(this.tabPage2);
            this.Kalender.Controls.Add(this.tabPage3);
            this.Kalender.Controls.Add(this.tabPage4);
            this.Kalender.Location = new System.Drawing.Point(2, 12);
            this.Kalender.Name = "Kalender";
            this.Kalender.SelectedIndex = 0;
            this.Kalender.Size = new System.Drawing.Size(448, 291);
            this.Kalender.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Hari);
            this.tabPage1.Controls.Add(this.mini);
            this.tabPage1.Controls.Add(this.maks);
            this.tabPage1.Controls.Add(this.min);
            this.tabPage1.Controls.Add(this.max);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(440, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Kalender";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Hari
            // 
            this.Hari.Location = new System.Drawing.Point(124, 33);
            this.Hari.Name = "Hari";
            this.Hari.Size = new System.Drawing.Size(200, 20);
            this.Hari.TabIndex = 4;
            // 
            // mini
            // 
            this.mini.LargeChange = 1;
            this.mini.Location = new System.Drawing.Point(405, 33);
            this.mini.Maximum = 20;
            this.mini.Minimum = 1;
            this.mini.Name = "mini";
            this.mini.Size = new System.Drawing.Size(17, 181);
            this.mini.TabIndex = 3;
            this.mini.Value = 1;
            this.mini.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // maks
            // 
            this.maks.LargeChange = 1;
            this.maks.Location = new System.Drawing.Point(33, 33);
            this.maks.Maximum = 20;
            this.maks.Minimum = 1;
            this.maks.Name = "maks";
            this.maks.Size = new System.Drawing.Size(17, 181);
            this.maks.TabIndex = 2;
            this.maks.Value = 1;
            this.maks.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min.Location = new System.Drawing.Point(120, 124);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(17, 24);
            this.min.TabIndex = 1;
            this.min.Text = "-";
            // 
            // max
            // 
            this.max.AutoSize = true;
            this.max.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max.Location = new System.Drawing.Point(120, 79);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(17, 24);
            this.max.TabIndex = 0;
            this.max.Text = "-";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(440, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Jam";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(440, 265);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Dan";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(440, 265);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Bersambung";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 304);
            this.Controls.Add(this.Kalender);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Kalender.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Kalender;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker Hari;
        private System.Windows.Forms.VScrollBar mini;
        private System.Windows.Forms.VScrollBar maks;
        private System.Windows.Forms.Label min;
        private System.Windows.Forms.Label max;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}

