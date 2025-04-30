namespace CourseWork
{
    partial class CreateReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateReview));
            panel1 = new Panel();
            star5 = new PictureBox();
            star4 = new PictureBox();
            star3 = new PictureBox();
            star2 = new PictureBox();
            star1 = new PictureBox();
            KillButton = new Label();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            SendReview = new Button();
            ReviewField = new TextBox();
            LogOutLink = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)star5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(star5);
            panel1.Controls.Add(star4);
            panel1.Controls.Add(star3);
            panel1.Controls.Add(star2);
            panel1.Controls.Add(star1);
            panel1.Controls.Add(KillButton);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(SendReview);
            panel1.Controls.Add(ReviewField);
            panel1.Controls.Add(LogOutLink);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 3;
            // 
            // star5
            // 
            star5.Cursor = Cursors.Hand;
            star5.Image = (Image)resources.GetObject("star5.Image");
            star5.Location = new Point(296, 328);
            star5.Name = "star5";
            star5.Size = new Size(54, 50);
            star5.SizeMode = PictureBoxSizeMode.Zoom;
            star5.TabIndex = 22;
            star5.TabStop = false;
            star5.Click += star5_Click;
            // 
            // star4
            // 
            star4.Cursor = Cursors.Hand;
            star4.Image = (Image)resources.GetObject("star4.Image");
            star4.Location = new Point(236, 328);
            star4.Name = "star4";
            star4.Size = new Size(54, 50);
            star4.SizeMode = PictureBoxSizeMode.Zoom;
            star4.TabIndex = 21;
            star4.TabStop = false;
            star4.Click += star4_Click;
            // 
            // star3
            // 
            star3.Cursor = Cursors.Hand;
            star3.Image = (Image)resources.GetObject("star3.Image");
            star3.Location = new Point(176, 328);
            star3.Name = "star3";
            star3.Size = new Size(54, 50);
            star3.SizeMode = PictureBoxSizeMode.Zoom;
            star3.TabIndex = 20;
            star3.TabStop = false;
            star3.Click += star3_Click;
            // 
            // star2
            // 
            star2.Cursor = Cursors.Hand;
            star2.Image = (Image)resources.GetObject("star2.Image");
            star2.Location = new Point(116, 328);
            star2.Name = "star2";
            star2.Size = new Size(54, 50);
            star2.SizeMode = PictureBoxSizeMode.Zoom;
            star2.TabIndex = 19;
            star2.TabStop = false;
            star2.Click += star2_Click;
            // 
            // star1
            // 
            star1.Cursor = Cursors.Hand;
            star1.Image = (Image)resources.GetObject("star1.Image");
            star1.Location = new Point(56, 328);
            star1.Name = "star1";
            star1.Size = new Size(54, 50);
            star1.SizeMode = PictureBoxSizeMode.Zoom;
            star1.TabIndex = 18;
            star1.TabStop = false;
            star1.Click += star1_Click;
            // 
            // KillButton
            // 
            KillButton.AutoSize = true;
            KillButton.Cursor = Cursors.Hand;
            KillButton.Font = new Font("Franklin Gothic Medium Cond", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KillButton.Location = new Point(771, -11);
            KillButton.Name = "KillButton";
            KillButton.Size = new Size(40, 43);
            KillButton.TabIndex = 17;
            KillButton.Text = "⨯";
            KillButton.Click += KillButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(43, 12);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 16;
            label2.Text = "Назад";
            label2.Click += label2_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(3, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 29);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // SendReview
            // 
            SendReview.Cursor = Cursors.Hand;
            SendReview.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SendReview.Location = new Point(614, 328);
            SendReview.Name = "SendReview";
            SendReview.Size = new Size(145, 40);
            SendReview.TabIndex = 14;
            SendReview.Text = "Отправить";
            SendReview.UseVisualStyleBackColor = true;
            SendReview.Click += SendReview_Click;
            // 
            // ReviewField
            // 
            ReviewField.Location = new Point(43, 101);
            ReviewField.Multiline = true;
            ReviewField.Name = "ReviewField";
            ReviewField.Size = new Size(716, 211);
            ReviewField.TabIndex = 7;
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
            label1.Text = "Создание нового отзыва";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            // 
            // CreateReview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateReview";
            Text = "CreateReview";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)star5).EndInit();
            ((System.ComponentModel.ISupportInitialize)star4).EndInit();
            ((System.ComponentModel.ISupportInitialize)star3).EndInit();
            ((System.ComponentModel.ISupportInitialize)star2).EndInit();
            ((System.ComponentModel.ISupportInitialize)star1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LogOutLink;
        private Label label1;
        private TextBox ReviewField;
        private PictureBox pictureBox6;
        private Button SendReview;
        private Label label2;
        private Label KillButton;
        private PictureBox star5;
        private PictureBox star4;
        private PictureBox star3;
        private PictureBox star2;
        private PictureBox star1;
    }
}