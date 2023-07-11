namespace test_practice
{
    partial class Rating
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
            dtGV = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtGV).BeginInit();
            SuspendLayout();
            // 
            // dtGV
            // 
            dtGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGV.Location = new Point(12, 12);
            dtGV.Name = "dtGV";
            dtGV.RowTemplate.Height = 25;
            dtGV.Size = new Size(776, 350);
            dtGV.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(256, 377);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(347, 377);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(443, 377);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "menu";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Rating
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 416);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtGV);
            Name = "Rating";
            Text = "Rating";
            Load += Rating_Load;
            ((System.ComponentModel.ISupportInitialize)dtGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtGV;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}