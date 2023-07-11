namespace test_practice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            log_tb = new TextBox();
            parol_tb = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // log_tb
            // 
            log_tb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            log_tb.Location = new Point(48, 157);
            log_tb.Name = "log_tb";
            log_tb.Size = new Size(142, 29);
            log_tb.TabIndex = 0;
            // 
            // parol_tb
            // 
            parol_tb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            parol_tb.Location = new Point(49, 215);
            parol_tb.Margin = new Padding(6);
            parol_tb.Name = "parol_tb";
            parol_tb.Size = new Size(141, 29);
            parol_tb.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.icons8_password_48__1_1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(10, 209);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 40);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources._23442;
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(9, 151);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 40);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = Properties.Resources.imgonline_com_ua_BigPicture_5RWoaOkwNp;
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(40, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(135, 133);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Electronic Highway Sign", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(67, 264);
            button1.Name = "button1";
            button1.Size = new Size(75, 31);
            button1.TabIndex = 5;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 313);
            Controls.Add(button1);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(parol_tb);
            Controls.Add(log_tb);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox log_tb;
        private TextBox parol_tb;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button button1;
    }
}