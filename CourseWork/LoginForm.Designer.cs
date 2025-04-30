namespace CourseWork
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            KillButton = new Label();
            SignLink = new Label();
            ButtonLogin = new Button();
            PassField = new TextBox();
            LoginField = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(KillButton);
            panel1.Controls.Add(SignLink);
            panel1.Controls.Add(ButtonLogin);
            panel1.Controls.Add(PassField);
            panel1.Controls.Add(LoginField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(435, 545);
            panel1.TabIndex = 0;
            // 
            // KillButton
            // 
            KillButton.AutoSize = true;
            KillButton.Cursor = Cursors.Hand;
            KillButton.Font = new Font("Franklin Gothic Medium Cond", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            KillButton.Location = new Point(405, -10);
            KillButton.Name = "KillButton";
            KillButton.Size = new Size(40, 43);
            KillButton.TabIndex = 1;
            KillButton.Text = "⨯";
            KillButton.Click += KillButton_Click;
            // 
            // SignLink
            // 
            SignLink.AutoSize = true;
            SignLink.Cursor = Cursors.Hand;
            SignLink.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SignLink.ForeColor = SystemColors.ButtonHighlight;
            SignLink.Location = new Point(128, 467);
            SignLink.Name = "SignLink";
            SignLink.Size = new Size(190, 20);
            SignLink.TabIndex = 6;
            SignLink.Text = "Еще нет учетной записи?";
            SignLink.Click += SignLink_Click_1;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Dock = DockStyle.Bottom;
            ButtonLogin.Font = new Font("Franklin Gothic Medium Cond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonLogin.Location = new Point(0, 490);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(435, 55);
            ButtonLogin.TabIndex = 5;
            ButtonLogin.Text = "Войти";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // PassField
            // 
            PassField.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PassField.Location = new Point(118, 291);
            PassField.Name = "PassField";
            PassField.Size = new Size(279, 43);
            PassField.TabIndex = 4;
            PassField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            LoginField.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginField.Location = new Point(118, 199);
            LoginField.Multiline = true;
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(279, 45);
            LoginField.TabIndex = 3;
            LoginField.TextChanged += LoginField_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(31, 269);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Franklin Gothic Medium Cond", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(435, 63);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.MouseDown += label1_MouseDown;
            label1.MouseMove += label1_MouseMove;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 545);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button ButtonLogin;
        private TextBox PassField;
        private TextBox LoginField;
        private Label SignLink;
        private Label KillButton;
    }
}
