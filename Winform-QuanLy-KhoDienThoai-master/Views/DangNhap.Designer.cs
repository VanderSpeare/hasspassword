namespace PhoneWarehouse.Views
{
    partial class DangNhap
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
            ShowPass = new CheckBox();
            Account = new TextBox();
            Password = new TextBox();
            buttonSignIn = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(1350, 434);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(322, 78);
            label1.TabIndex = 0;
            label1.Text = "Đăng Nhập";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ShowPass
            // 
            ShowPass.AutoSize = true;
            ShowPass.Font = new Font("Segoe UI", 13F);
            ShowPass.Location = new Point(1682, 704);
            ShowPass.Margin = new Padding(5, 5, 5, 5);
            ShowPass.Name = "ShowPass";
            ShowPass.Size = new Size(278, 51);
            ShowPass.TabIndex = 3;
            ShowPass.Text = "Hiện mật khẩu";
            ShowPass.UseVisualStyleBackColor = true;
            // 
            // Account
            // 
            Account.Location = new Point(1357, 571);
            Account.Margin = new Padding(5, 5, 5, 5);
            Account.Name = "Account";
            Account.Size = new Size(313, 39);
            Account.TabIndex = 4;
            // 
            // Password
            // 
            Password.Location = new Point(1357, 704);
            Password.Margin = new Padding(5, 5, 5, 5);
            Password.Name = "Password";
            Password.Size = new Size(313, 39);
            Password.TabIndex = 5;
            // 
            // buttonSignIn
            // 
            buttonSignIn.Font = new Font("Segoe UI", 15F);
            buttonSignIn.Location = new Point(1357, 790);
            buttonSignIn.Margin = new Padding(5, 5, 5, 5);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(315, 88);
            buttonSignIn.TabIndex = 6;
            buttonSignIn.Text = "Đăng Nhập";
            buttonSignIn.UseVisualStyleBackColor = true;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(1079, 571);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(229, 78);
            label2.TabIndex = 7;
            label2.Text = "Tài khoản";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(1079, 678);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(229, 78);
            label3.TabIndex = 8;
            label3.Text = "Mật khẩu";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2564, 1559);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonSignIn);
            Controls.Add(Password);
            Controls.Add(Account);
            Controls.Add(ShowPass);
            Controls.Add(label1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignIn";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox ShowPass;
        private TextBox Account;
        private TextBox Password;
        private Button buttonSignIn;
        private Label label2;
        private Label label3;
    }
}