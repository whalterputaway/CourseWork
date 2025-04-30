namespace CourseWork
{
    partial class AllReviews
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllReviews));
            panel1 = new Panel();
            TimeField = new Label();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            NextReviewButton = new PictureBox();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            GradField = new Label();
            ReviewField = new TextBox();
            NickField = new TextBox();
            KillButton = new Label();
            LogOutLink = new Label();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NextReviewButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(TimeField);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(NextReviewButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(GradField);
            panel1.Controls.Add(ReviewField);
            panel1.Controls.Add(NickField);
            panel1.Controls.Add(KillButton);
            panel1.Controls.Add(LogOutLink);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 2;
            // 
            // TimeField
            // 
            TimeField.AutoSize = true;
            TimeField.Location = new Point(308, 123);
            TimeField.Name = "TimeField";
            TimeField.Size = new Size(38, 15);
            TimeField.TabIndex = 30;
            TimeField.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(278, 292);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 29;
            label4.Text = "Пред. отзыв";
            // 
            // pictureBox3
            // 
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(238, 283);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(530, 135);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(447, 292);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 26;
            label3.Text = "След. отзыв";
            // 
            // NextReviewButton
            // 
            NextReviewButton.Cursor = Cursors.Hand;
            NextReviewButton.Image = (Image)resources.GetObject("NextReviewButton.Image");
            NextReviewButton.Location = new Point(530, 283);
            NextReviewButton.Name = "NextReviewButton";
            NextReviewButton.Size = new Size(34, 29);
            NextReviewButton.SizeMode = PictureBoxSizeMode.Zoom;
            NextReviewButton.TabIndex = 25;
            NextReviewButton.TabStop = false;
            NextReviewButton.Click += NextReviewButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(40, 9);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 24;
            label2.Text = "Назад";
            label2.Click += label2_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, -1);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 23;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(238, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // GradField
            // 
            GradField.AutoSize = true;
            GradField.Font = new Font("Franklin Gothic Medium Cond", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            GradField.Location = new Point(509, 135);
            GradField.Name = "GradField";
            GradField.Size = new Size(25, 30);
            GradField.TabIndex = 21;
            GradField.Text = "5";
            // 
            // ReviewField
            // 
            ReviewField.Location = new Point(238, 170);
            ReviewField.Multiline = true;
            ReviewField.Name = "ReviewField";
            ReviewField.ReadOnly = true;
            ReviewField.Size = new Size(326, 110);
            ReviewField.TabIndex = 20;
            ReviewField.TextChanged += ReviewField_TextChanged;
            // 
            // NickField
            // 
            NickField.Location = new Point(308, 141);
            NickField.Name = "NickField";
            NickField.ReadOnly = true;
            NickField.Size = new Size(127, 23);
            NickField.TabIndex = 19;
            // 
            // KillButton
            // 
            KillButton.AutoSize = true;
            KillButton.Cursor = Cursors.Hand;
            KillButton.Font = new Font("Franklin Gothic Medium Cond", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KillButton.Location = new Point(772, -15);
            KillButton.Name = "KillButton";
            KillButton.Size = new Size(40, 43);
            KillButton.TabIndex = 18;
            KillButton.Text = "⨯";
            KillButton.Click += KillButton_Click;
            // 
            // LogOutLink
            // 
            LogOutLink.AutoSize = true;
            LogOutLink.Cursor = Cursors.Hand;
            LogOutLink.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogOutLink.Location = new Point(755, 430);
            LogOutLink.Name = "LogOutLink";
            LogOutLink.Size = new Size(45, 20);
            LogOutLink.TabIndex = 6;
            LogOutLink.Text = "Выйти";
            LogOutLink.Click += LogOutLink_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Franklin Gothic Medium Cond", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 63);
            label1.TabIndex = 0;
            label1.Text = "Отзывы";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            // 
            // AllReviews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AllReviews";
            Text = "AllReviews";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)NextReviewButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LogOutLink;
        private Label label1;
        private Label KillButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Label GradField;
        private TextBox ReviewField;
        private TextBox NickField;
        private PictureBox pictureBox6;
        private Label label2;
        private Label label3;
        private PictureBox NextReviewButton;
        private PictureBox pictureBox2;
        private Label label4;
        private PictureBox pictureBox3;
        private Label TimeField;
    }
}