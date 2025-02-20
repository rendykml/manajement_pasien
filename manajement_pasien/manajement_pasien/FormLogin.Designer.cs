namespace manajement_pasien
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            registerLink = new Label();
            label5 = new Label();
            clearLogin = new Button();
            buttonLogin = new Button();
            checkBoxShowPass = new CheckBox();
            textPassword = new TextBox();
            label3 = new Label();
            textUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // registerLink
            // 
            registerLink.AutoSize = true;
            registerLink.Cursor = Cursors.Hand;
            registerLink.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLink.ForeColor = Color.FromArgb(116, 86, 174);
            registerLink.Location = new Point(159, 501);
            registerLink.Name = "registerLink";
            registerLink.Size = new Size(83, 20);
            registerLink.TabIndex = 20;
            registerLink.Text = "Buat Akun";
            registerLink.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(130, 474);
            label5.Name = "label5";
            label5.Size = new Size(142, 20);
            label5.TabIndex = 21;
            label5.Text = "Tidak Punya Akun?";
            // 
            // clearLogin
            // 
            clearLogin.BackColor = Color.White;
            clearLogin.Cursor = Cursors.Hand;
            clearLogin.FlatStyle = FlatStyle.Flat;
            clearLogin.ForeColor = Color.FromArgb(116, 86, 174);
            clearLogin.Location = new Point(70, 412);
            clearLogin.Name = "clearLogin";
            clearLogin.Size = new Size(255, 45);
            clearLogin.TabIndex = 18;
            clearLogin.Text = "CLEAR";
            clearLogin.UseVisualStyleBackColor = false;
            clearLogin.Click += clearLogin_Click;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(116, 86, 174);
            buttonLogin.Cursor = Cursors.Hand;
            buttonLogin.FlatAppearance.BorderSize = 0;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(70, 356);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(255, 45);
            buttonLogin.TabIndex = 19;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // checkBoxShowPass
            // 
            checkBoxShowPass.AutoSize = true;
            checkBoxShowPass.Cursor = Cursors.Hand;
            checkBoxShowPass.FlatStyle = FlatStyle.Flat;
            checkBoxShowPass.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxShowPass.Location = new Point(204, 317);
            checkBoxShowPass.Name = "checkBoxShowPass";
            checkBoxShowPass.Size = new Size(121, 21);
            checkBoxShowPass.TabIndex = 17;
            checkBoxShowPass.Text = "Show Password";
            checkBoxShowPass.UseVisualStyleBackColor = true;
            checkBoxShowPass.CheckedChanged += checkBoxShowPass_CheckedChanged;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(230, 231, 232);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("MS UI Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(70, 277);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(255, 34);
            textPassword.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 251);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 13;
            label3.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(230, 231, 232);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("MS UI Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.ForeColor = Color.FromArgb(64, 64, 64);
            textUsername.Location = new Point(70, 199);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(255, 34);
            textUsername.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 173);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 11;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(70, 112);
            label1.Name = "label1";
            label1.Size = new Size(241, 34);
            label1.TabIndex = 10;
            label1.Text = "Silahkan Login ";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 586);
            Controls.Add(registerLink);
            Controls.Add(label5);
            Controls.Add(clearLogin);
            Controls.Add(buttonLogin);
            Controls.Add(checkBoxShowPass);
            Controls.Add(textPassword);
            Controls.Add(label3);
            Controls.Add(textUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registerLink;
        private Label label5;
        private Button clearLogin;
        private Button buttonLogin;
        private CheckBox checkBoxShowPass;
        private TextBox textPassword;
        private Label label3;
        private TextBox textUsername;
        private Label label2;
        private Label label1;
    }
}