namespace manajement_pasien
{
    partial class frmRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegister));
            label1 = new Label();
            label2 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            label3 = new Label();
            textComPassword = new TextBox();
            label4 = new Label();
            checkBoxShowPass = new CheckBox();
            buttonRegister = new Button();
            clearRegis = new Button();
            label5 = new Label();
            LoginLink = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(116, 86, 174);
            label1.Location = new Point(55, 65);
            label1.Name = "label1";
            label1.Size = new Size(308, 34);
            label1.TabIndex = 0;
            label1.Text = "Silahkan Buat Akun";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(79, 124);
            label2.Name = "label2";
            label2.Size = new Size(89, 23);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // textUsername
            // 
            textUsername.BackColor = Color.FromArgb(230, 231, 232);
            textUsername.BorderStyle = BorderStyle.None;
            textUsername.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textUsername.ForeColor = Color.FromArgb(64, 64, 64);
            textUsername.Location = new Point(79, 156);
            textUsername.Multiline = true;
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(255, 34);
            textUsername.TabIndex = 2;
            textUsername.TextChanged += textUsername_TextChanged;
            // 
            // textPassword
            // 
            textPassword.BackColor = Color.FromArgb(230, 231, 232);
            textPassword.BorderStyle = BorderStyle.None;
            textPassword.Font = new Font("MS UI Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textPassword.Location = new Point(79, 232);
            textPassword.Multiline = true;
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new Size(255, 34);
            textPassword.TabIndex = 4;
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 201);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 3;
            label3.Text = "Password";
            // 
            // textComPassword
            // 
            textComPassword.BackColor = Color.FromArgb(230, 231, 232);
            textComPassword.BorderStyle = BorderStyle.None;
            textComPassword.Font = new Font("MS UI Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textComPassword.Location = new Point(79, 307);
            textComPassword.Multiline = true;
            textComPassword.Name = "textComPassword";
            textComPassword.PasswordChar = '*';
            textComPassword.Size = new Size(255, 34);
            textComPassword.TabIndex = 6;
            textComPassword.TextChanged += textComPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(79, 276);
            label4.Name = "label4";
            label4.Size = new Size(155, 23);
            label4.TabIndex = 5;
            label4.Text = "Confirm Password";
            // 
            // checkBoxShowPass
            // 
            checkBoxShowPass.AutoSize = true;
            checkBoxShowPass.Cursor = Cursors.Hand;
            checkBoxShowPass.FlatStyle = FlatStyle.Flat;
            checkBoxShowPass.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxShowPass.Location = new Point(213, 345);
            checkBoxShowPass.Name = "checkBoxShowPass";
            checkBoxShowPass.Size = new Size(121, 21);
            checkBoxShowPass.TabIndex = 7;
            checkBoxShowPass.Text = "Show Password";
            checkBoxShowPass.UseVisualStyleBackColor = true;
            checkBoxShowPass.CheckedChanged += checkBoxShowPass_CheckedChanged;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.FromArgb(116, 86, 174);
            buttonRegister.Cursor = Cursors.Hand;
            buttonRegister.FlatAppearance.BorderSize = 0;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(79, 380);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(255, 45);
            buttonRegister.TabIndex = 8;
            buttonRegister.Text = "REGISTER";
            buttonRegister.UseVisualStyleBackColor = false;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // clearRegis
            // 
            clearRegis.BackColor = Color.White;
            clearRegis.Cursor = Cursors.Hand;
            clearRegis.FlatStyle = FlatStyle.Flat;
            clearRegis.ForeColor = Color.FromArgb(116, 86, 174);
            clearRegis.Location = new Point(79, 436);
            clearRegis.Name = "clearRegis";
            clearRegis.Size = new Size(255, 45);
            clearRegis.TabIndex = 8;
            clearRegis.Text = "CLEAR";
            clearRegis.UseVisualStyleBackColor = false;
            clearRegis.Click += clearRegis_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(133, 500);
            label5.Name = "label5";
            label5.Size = new Size(147, 20);
            label5.TabIndex = 9;
            label5.Text = "Sudah Punya Akun?";
            // 
            // LoginLink
            // 
            LoginLink.AutoSize = true;
            LoginLink.Cursor = Cursors.Hand;
            LoginLink.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginLink.ForeColor = Color.FromArgb(116, 86, 174);
            LoginLink.Location = new Point(153, 528);
            LoginLink.Name = "LoginLink";
            LoginLink.Size = new Size(109, 20);
            LoginLink.TabIndex = 9;
            LoginLink.Text = "Kembali Login";
            LoginLink.Click += LoginLink_Click;
            // 
            // frmRegister
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 586);
            Controls.Add(LoginLink);
            Controls.Add(label5);
            Controls.Add(clearRegis);
            Controls.Add(buttonRegister);
            Controls.Add(checkBoxShowPass);
            Controls.Add(textComPassword);
            Controls.Add(label4);
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
            Name = "frmRegister";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textUsername;
        private TextBox textPassword;
        private Label label3;
        private TextBox textComPassword;
        private Label label4;
        private CheckBox checkBoxShowPass;
        private Button buttonRegister;
        private Button clearRegis;
        private Label label5;
        private Label LoginLink;
    }
}
