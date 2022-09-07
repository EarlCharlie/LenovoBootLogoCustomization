namespace LogoDiy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SelectImage = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.Recovery = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectImage
            // 
            this.SelectImage.Location = new System.Drawing.Point(12, 261);
            this.SelectImage.Margin = new System.Windows.Forms.Padding(1);
            this.SelectImage.Name = "SelectImage";
            this.SelectImage.Size = new System.Drawing.Size(99, 33);
            this.SelectImage.TabIndex = 0;
            this.SelectImage.Text = "选择图片";
            this.SelectImage.UseVisualStyleBackColor = true;
            this.SelectImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // Apply
            // 
            this.Apply.Enabled = false;
            this.Apply.Location = new System.Drawing.Point(113, 261);
            this.Apply.Margin = new System.Windows.Forms.Padding(1);
            this.Apply.Name = "Apply";
            this.Apply.Size = new System.Drawing.Size(99, 33);
            this.Apply.TabIndex = 1;
            this.Apply.Text = "应用";
            this.Apply.UseVisualStyleBackColor = true;
            this.Apply.Click += new System.EventHandler(this.button2_Click);
            // 
            // Recovery
            // 
            this.Recovery.Location = new System.Drawing.Point(406, 261);
            this.Recovery.Margin = new System.Windows.Forms.Padding(1);
            this.Recovery.Name = "Recovery";
            this.Recovery.Size = new System.Drawing.Size(99, 33);
            this.Recovery.TabIndex = 2;
            this.Recovery.Text = "恢复默认";
            this.Recovery.UseVisualStyleBackColor = true;
            this.Recovery.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(12, 243);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(1);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Show Loading Icon";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(380, 306);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "Use at your own risk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(10, 306);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Format: , Max: ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(494, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 327);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Recovery);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.SelectImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "联想开机Logo自定义";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectImage;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Button Recovery;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

