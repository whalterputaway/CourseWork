namespace CourseWork
{
    partial class SignForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignForm));
            LoginField = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            KillButton = new Label();
            LoginLink = new Label();
            PassField = new TextBox();
            FamilyField = new TextBox();
            NameField = new TextBox();
            ButtonSign = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LoginField
            // 
            LoginField.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            LoginField.Location = new Point(88, 199);
            LoginField.Multiline = true;
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(279, 45);
            LoginField.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(433, 179);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(70, 65);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 179);
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
            label1.Size = new Size(800, 63);
            label1.TabIndex = 0;
            label1.Text = "Регистрация";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.MouseDown += label1_MouseDown_1;
            label1.MouseMove += label1_MouseMove_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(KillButton);
            panel1.Controls.Add(LoginLink);
            panel1.Controls.Add(PassField);
            panel1.Controls.Add(FamilyField);
            panel1.Controls.Add(NameField);
            panel1.Controls.Add(ButtonSign);
            panel1.Controls.Add(LoginField);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
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
            KillButton.Location = new Point(771, -11);
            KillButton.Name = "KillButton";
            KillButton.Size = new Size(40, 43);
            KillButton.TabIndex = 10;
            KillButton.Text = "⨯";
            KillButton.Click += KillButton_Click;
            // 
            // LoginLink
            // 
            LoginLink.AutoSize = true;
            LoginLink.Cursor = Cursors.Hand;
            LoginLink.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginLink.ForeColor = SystemColors.ButtonHighlight;
            LoginLink.Location = new Point(313, 351);
            LoginLink.Name = "LoginLink";
            LoginLink.Size = new Size(194, 20);
            LoginLink.TabIndex = 9;
            LoginLink.Text = "Уже есть учетная запись?";
            LoginLink.Click += LoginLink_Click;
            // 
            // PassField
            // 
            PassField.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PassField.Location = new Point(509, 199);
            PassField.Multiline = true;
            PassField.Name = "PassField";
            PassField.Size = new Size(279, 45);
            PassField.TabIndex = 8;
            // 
            // FamilyField
            // 
            FamilyField.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FamilyField.Location = new Point(509, 116);
            FamilyField.Multiline = true;
            FamilyField.Name = "FamilyField";
            FamilyField.Size = new Size(279, 45);
            FamilyField.TabIndex = 7;
            FamilyField.Enter += FamilyField_Enter;
            FamilyField.Leave += FamilyField_Leave;
            // 
            // NameField
            // 
            NameField.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            NameField.Location = new Point(88, 116);
            NameField.Multiline = true;
            NameField.Name = "NameField";
            NameField.Size = new Size(279, 45);
            NameField.TabIndex = 6;
            NameField.TextChanged += NameField_TextChanged;
            NameField.Enter += NameField_Enter;
            NameField.Leave += NameField_Leave;
            // 
            // ButtonSign
            // 
            ButtonSign.Dock = DockStyle.Bottom;
            ButtonSign.Font = new Font("Franklin Gothic Medium Cond", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonSign.Location = new Point(0, 395);
            ButtonSign.Name = "ButtonSign";
            ButtonSign.Size = new Size(800, 55);
            ButtonSign.TabIndex = 5;
            ButtonSign.Text = "Зарегистрироваться";
            ButtonSign.UseVisualStyleBackColor = true;
            ButtonSign.Click += ButtonSign_Click;
            // 
            // SignForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignForm";
            Text = "SignForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TextBox LoginField;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Button ButtonSign;
        private TextBox PassField;
        private TextBox FamilyField;
        private TextBox NameField;
        private Label LoginLink;
        private Label KillButton;
    }
}