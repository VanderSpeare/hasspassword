namespace PhoneWarehouse.Views
{
    partial class TrangChu
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
            menuStrip1 = new MenuStrip();
            aToolStripMenuItem = new ToolStripMenuItem();
            logOuTToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            phoneToolStripMenuItem = new ToolStripMenuItem();
            exportSlipToolStripMenuItem = new ToolStripMenuItem();
            stockOutToolStripMenuItem = new ToolStripMenuItem();
            employeeToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem = new ToolStripMenuItem();
            accountToolStripMenuItem1 = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aToolStripMenuItem, manageToolStripMenuItem, helpToolStripMenuItem, reportToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            aToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { logOuTToolStripMenuItem, exitToolStripMenuItem });
            aToolStripMenuItem.Name = "aToolStripMenuItem";
            aToolStripMenuItem.Size = new Size(85, 24);
            aToolStripMenuItem.Text = "Hệ thống";
            // 
            // logOuTToolStripMenuItem
            // 
            logOuTToolStripMenuItem.Name = "logOuTToolStripMenuItem";
            logOuTToolStripMenuItem.Size = new Size(165, 26);
            logOuTToolStripMenuItem.Text = "Đăng nhập";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(165, 26);
            exitToolStripMenuItem.Text = "Đăng xuất";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { phoneToolStripMenuItem, exportSlipToolStripMenuItem, stockOutToolStripMenuItem, employeeToolStripMenuItem, accountToolStripMenuItem, accountToolStripMenuItem1 });
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(73, 24);
            manageToolStripMenuItem.Text = "Quản lý";
            // 
            // phoneToolStripMenuItem
            // 
            phoneToolStripMenuItem.Name = "phoneToolStripMenuItem";
            phoneToolStripMenuItem.Size = new Size(224, 26);
            phoneToolStripMenuItem.Text = "Điện thoại";
            phoneToolStripMenuItem.Click += phoneToolStripMenuItem_Click;
            // 
            // exportSlipToolStripMenuItem
            // 
            exportSlipToolStripMenuItem.Name = "exportSlipToolStripMenuItem";
            exportSlipToolStripMenuItem.Size = new Size(224, 26);
            exportSlipToolStripMenuItem.Text = "Nhập kho";
            exportSlipToolStripMenuItem.Click += exportSlipToolStripMenuItem_Click;
            // 
            // stockOutToolStripMenuItem
            // 
            stockOutToolStripMenuItem.Name = "stockOutToolStripMenuItem";
            stockOutToolStripMenuItem.Size = new Size(224, 26);
            stockOutToolStripMenuItem.Text = "Xuất kho";
            stockOutToolStripMenuItem.Click += stockOutToolStripMenuItem_Click;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new Size(224, 26);
            employeeToolStripMenuItem.Text = "Nhân viên";
            employeeToolStripMenuItem.Click += employeeToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem
            // 
            accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            accountToolStripMenuItem.Size = new Size(224, 26);
            accountToolStripMenuItem.Text = "Nhà cung cấp";
            accountToolStripMenuItem.Click += accountToolStripMenuItem_Click;
            // 
            // accountToolStripMenuItem1
            // 
            accountToolStripMenuItem1.Name = "accountToolStripMenuItem1";
            accountToolStripMenuItem1.Size = new Size(224, 26);
            accountToolStripMenuItem1.Text = "Tài khoản";
            accountToolStripMenuItem1.Click += accountToolStripMenuItem1_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(78, 24);
            helpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(224, 26);
            aboutToolStripMenuItem.Text = "Về chúng tôi";
            // 
            // reportToolStripMenuItem1
            // 
            reportToolStripMenuItem1.Name = "reportToolStripMenuItem1";
            reportToolStripMenuItem1.Size = new Size(77, 24);
            reportToolStripMenuItem1.Text = "Báo cáo";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem aToolStripMenuItem;
        private ToolStripMenuItem logOuTToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem phoneToolStripMenuItem;
        private ToolStripMenuItem exportSlipToolStripMenuItem;
        private ToolStripMenuItem stockOutToolStripMenuItem;
        private ToolStripMenuItem employeeToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem accountToolStripMenuItem1;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem1;
    }
}