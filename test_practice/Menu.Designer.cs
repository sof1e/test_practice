namespace test_practice
{
    partial class Menu
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            history = new PictureBox();
            chemistry = new PictureBox();
            geography = new PictureBox();
            math = new PictureBox();
            toolTip1 = new ToolTip(components);
            physics = new PictureBox();
            biology = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)history).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chemistry).BeginInit();
            ((System.ComponentModel.ISupportInitialize)geography).BeginInit();
            ((System.ComponentModel.ISupportInitialize)math).BeginInit();
            ((System.ComponentModel.ISupportInitialize)physics).BeginInit();
            ((System.ComponentModel.ISupportInitialize)biology).BeginInit();
            SuspendLayout();
            // 
            // history
            // 
            history.BackColor = SystemColors.Control;
            history.ErrorImage = Properties.Resources.icons8_ukraine_100;
            history.Image = Properties.Resources.icons8_ukraine_100;
            history.Location = new Point(8, 45);
            history.Name = "history";
            history.Size = new Size(100, 94);
            history.TabIndex = 4;
            history.TabStop = false;
            toolTip1.SetToolTip(history, "Історія України");
            history.Click += history_Click;
            // 
            // chemistry
            // 
            chemistry.Image = Properties.Resources.icons8_periodic_table_of_elements_100;
            chemistry.Location = new Point(114, 145);
            chemistry.Name = "chemistry";
            chemistry.Size = new Size(100, 100);
            chemistry.TabIndex = 5;
            chemistry.TabStop = false;
            toolTip1.SetToolTip(chemistry, "Хімія");
            chemistry.Click += chemistry_Click;
            // 
            // geography
            // 
            geography.ErrorImage = Properties.Resources.icons8_europe_100;
            geography.Image = Properties.Resources.icons8_europe_100;
            geography.Location = new Point(114, 45);
            geography.Name = "geography";
            geography.Size = new Size(100, 94);
            geography.TabIndex = 6;
            geography.TabStop = false;
            toolTip1.SetToolTip(geography, "Географія");
            geography.Click += geography_Click;
            // 
            // math
            // 
            math.Image = Properties.Resources.icons8_math_100;
            math.Location = new Point(8, 145);
            math.Name = "math";
            math.Size = new Size(100, 100);
            math.TabIndex = 7;
            math.TabStop = false;
            toolTip1.SetToolTip(math, "Математика");
            math.Click += math_Click;
            // 
            // physics
            // 
            physics.Image = Properties.Resources.icons8_physics_901;
            physics.InitialImage = null;
            physics.Location = new Point(222, 45);
            physics.Name = "physics";
            physics.Size = new Size(98, 94);
            physics.TabIndex = 8;
            physics.TabStop = false;
            toolTip1.SetToolTip(physics, "Фізика");
            physics.Click += physics_Click;
            // 
            // biology
            // 
            biology.Image = Properties.Resources.icons8_biotech_100;
            biology.Location = new Point(222, 145);
            biology.Name = "biology";
            biology.Size = new Size(98, 100);
            biology.TabIndex = 9;
            biology.TabStop = false;
            toolTip1.SetToolTip(biology, "Біологія");
            biology.Click += biology_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Electronic Highway Sign", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 10);
            label1.Name = "label1";
            label1.Size = new Size(308, 32);
            label1.TabIndex = 10;
            label1.Text = "Choose subject";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 254);
            Controls.Add(label1);
            Controls.Add(biology);
            Controls.Add(physics);
            Controls.Add(math);
            Controls.Add(geography);
            Controls.Add(chemistry);
            Controls.Add(history);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Menu";
            Text = "Testing";
            ((System.ComponentModel.ISupportInitialize)history).EndInit();
            ((System.ComponentModel.ISupportInitialize)chemistry).EndInit();
            ((System.ComponentModel.ISupportInitialize)geography).EndInit();
            ((System.ComponentModel.ISupportInitialize)math).EndInit();
            ((System.ComponentModel.ISupportInitialize)physics).EndInit();
            ((System.ComponentModel.ISupportInitialize)biology).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox history;
        private PictureBox chemistry;
        private PictureBox geography;
        private PictureBox math;
        private ToolTip toolTip1;
        private PictureBox physics;
        private PictureBox biology;
        private Label label1;
    }
}