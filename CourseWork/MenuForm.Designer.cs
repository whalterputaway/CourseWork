namespace CourseWork
{
    partial class MenuForm
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
            label1 = new Label();
            panel1 = new Panel();
            KillButton = new Label();
            LogOutLink = new Label();
            ProfileButton = new Button();
            ReadReviewsButton = new Button();
            WriteButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Franklin Gothic Medium Cond", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 63);
            label1.TabIndex = 0;
            label1.Text = "Главное меню";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(KillButton);
            panel1.Controls.Add(LogOutLink);
            panel1.Controls.Add(ProfileButton);
            panel1.Controls.Add(ReadReviewsButton);
            panel1.Controls.Add(WriteButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            // 
            // KillButton
            // 
            KillButton.AutoSize = true;
            KillButton.Cursor = Cursors.Hand;
            KillButton.Font = new Font("Franklin Gothic Medium Cond", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KillButton.Location = new Point(765, -11);
            KillButton.Name = "KillButton";
            KillButton.Size = new Size(40, 43);
            KillButton.TabIndex = 7;
            KillButton.Text = "⨯";
            KillButton.Click += KillButton_Click;
            // 
            // LogOutLink
            // 
            LogOutLink.Cursor = Cursors.Hand;
            LogOutLink.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LogOutLink.Location = new Point(752, 421);
            LogOutLink.Name = "LogOutLink";
            LogOutLink.Size = new Size(45, 20);
            LogOutLink.TabIndex = 6;
            LogOutLink.Text = "Выйти";
            LogOutLink.Click += LogOutLink_Click;
            // 
            // ProfileButton
            // 
            ProfileButton.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ProfileButton.Location = new Point(247, 306);
            ProfileButton.Name = "ProfileButton";
            ProfileButton.Size = new Size(306, 40);
            ProfileButton.TabIndex = 3;
            ProfileButton.Text = "Личный кабинет";
            ProfileButton.UseVisualStyleBackColor = true;
            ProfileButton.Click += ProfileButton_Click;
            // 
            // ReadReviewsButton
            // 
            ReadReviewsButton.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ReadReviewsButton.Location = new Point(247, 213);
            ReadReviewsButton.Name = "ReadReviewsButton";
            ReadReviewsButton.Size = new Size(306, 40);
            ReadReviewsButton.TabIndex = 2;
            ReadReviewsButton.Text = "Читать отзывы";
            ReadReviewsButton.UseVisualStyleBackColor = true;
            ReadReviewsButton.Click += ReadReviewsButton_Click;
            // 
            // WriteButton
            // 
            WriteButton.Font = new Font("Franklin Gothic Medium Cond", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            WriteButton.Location = new Point(247, 118);
            WriteButton.Name = "WriteButton";
            WriteButton.Size = new Size(306, 40);
            WriteButton.TabIndex = 1;
            WriteButton.Text = "Написать отзыв";
            WriteButton.UseVisualStyleBackColor = true;
            WriteButton.Click += WriteButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuForm";
            Text = "MenuForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button ProfileButton;
        private Button ReadReviewsButton;
        private Button WriteButton;
        private Label LogOutLink;
        private Label KillButton;
    }
}