namespace CourseWork
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            panel1 = new Panel();
            DateOfRegistrationField = new Label();
            LoginField = new Label();
            NameField = new Label();
            FamilyField = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox6 = new PictureBox();
            KillButton = new Label();
            LogOutLink = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(DateOfRegistrationField);
            panel1.Controls.Add(LoginField);
            panel1.Controls.Add(NameField);
            panel1.Controls.Add(FamilyField);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(KillButton);
            panel1.Controls.Add(LogOutLink);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 2;
            // 
            // DateOfRegistrationField
            // 
            DateOfRegistrationField.AutoSize = true;
            DateOfRegistrationField.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            DateOfRegistrationField.Location = new Point(246, 176);
            DateOfRegistrationField.Name = "DateOfRegistrationField";
            DateOfRegistrationField.Size = new Size(52, 20);
            DateOfRegistrationField.TabIndex = 34;
            DateOfRegistrationField.Text = "label10";
            // 
            // LoginField
            // 
            LoginField.AutoSize = true;
            LoginField.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            LoginField.Location = new Point(182, 138);
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(44, 20);
            LoginField.TabIndex = 33;
            LoginField.Text = "label9";
            // 
            // NameField
            // 
            NameField.AutoSize = true;
            NameField.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            NameField.Location = new Point(172, 103);
            NameField.Name = "NameField";
            NameField.Size = new Size(44, 20);
            NameField.TabIndex = 32;
            NameField.Text = "label8";
            // 
            // FamilyField
            // 
            FamilyField.AutoSize = true;
            FamilyField.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            FamilyField.Location = new Point(355, 103);
            FamilyField.Name = "FamilyField";
            FamilyField.Size = new Size(44, 20);
            FamilyField.TabIndex = 31;
            FamilyField.Text = "label7";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label6.Location = new Point(132, 138);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 30;
            label6.Text = "Логин:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label5.Location = new Point(288, 103);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 29;
            label5.Text = "Фамилия:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label4.Location = new Point(132, 103);
            label4.Name = "label4";
            label4.Size = new Size(37, 20);
            label4.TabIndex = 28;
            label4.Text = "Имя:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium Cond", 11.25F);
            label3.Location = new Point(132, 176);
            label3.Name = "label3";
            label3.Size = new Size(115, 20);
            label3.TabIndex = 27;
            label3.Text = "Дата регистрации:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, 103);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
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
            label2.TabIndex = 25;
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
            pictureBox6.TabIndex = 24;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
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
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Franklin Gothic Medium Cond", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 63);
            label1.TabIndex = 0;
            label1.Text = "Личный кабинет";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.MouseDown += label1_MouseDown_1;
            label1.MouseMove += label1_MouseMove_1;
            // 
            // Profile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Profile";
            Text = "Profile";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LogOutLink;
        private Label label1;
        private Label KillButton;
        private PictureBox pictureBox6;
        private Label label2;
        private PictureBox pictureBox1;
        private Label DateOfRegistrationField;
        private Label LoginField;
        private Label NameField;
        private Label FamilyField;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}