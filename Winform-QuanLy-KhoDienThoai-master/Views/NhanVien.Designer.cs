namespace PhoneWarehouse.Views
{
    partial class NhanVien
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
            button5 = new Button();
            textBox6 = new TextBox();
            label6 = new Label();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            textBox5 = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Day = new DataGridViewTextBoxColumn();
            Name = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            textBox4 = new TextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(1723, 61);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 24;
            button5.Text = "Tìm";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1573, 62);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(144, 27);
            textBox6.TabIndex = 23;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(1455, 42);
            label6.Name = "label6";
            label6.Size = new Size(123, 57);
            label6.TabIndex = 22;
            label6.Text = "Tìm kiếm";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 20F);
            button4.Location = new Point(1160, 35);
            button4.Name = "button4";
            button4.Size = new Size(154, 65);
            button4.TabIndex = 15;
            button4.Text = "Clear All";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 20F);
            button3.Location = new Point(964, 35);
            button3.Name = "button3";
            button3.Size = new Size(154, 65);
            button3.TabIndex = 14;
            button3.Text = "Xoá";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(551, 35);
            button1.Name = "button1";
            button1.Size = new Size(154, 65);
            button1.TabIndex = 12;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1354, 23);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(94, 27);
            textBox5.TabIndex = 20;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(1251, 15);
            label5.Name = "label5";
            label5.Size = new Size(109, 32);
            label5.TabIndex = 19;
            label5.Text = "Giới tính";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox6);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(-4, 896);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1910, 134);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(758, 35);
            button2.Name = "button2";
            button2.Size = new Size(154, 65);
            button2.TabIndex = 13;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(1038, 20);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 27);
            textBox3.TabIndex = 17;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(692, 20);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 18);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 15;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(912, 9);
            label3.Name = "label3";
            label3.Size = new Size(130, 44);
            label3.TabIndex = 14;
            label3.Text = "Ngày sinh";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(516, 6);
            label2.Name = "label2";
            label2.Size = new Size(170, 44);
            label2.TabIndex = 13;
            label2.Text = "Tên nhân viên";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(131, 8);
            label1.Name = "label1";
            label1.Size = new Size(180, 44);
            label1.TabIndex = 12;
            label1.Text = "Mã nhân viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Day, Name, Quantity, Amount });
            dataGridView1.Location = new Point(-4, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1910, 838);
            dataGridView1.TabIndex = 18;
            // 
            // ID
            // 
            ID.HeaderText = "Mã nhân viên";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // Day
            // 
            Day.HeaderText = "Tên nhân viên";
            Day.MinimumWidth = 6;
            Day.Name = "Day";
            // 
            // Name
            // 
            Name.HeaderText = "Ngày sinh";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Giới tính";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // Amount
            // 
            Amount.HeaderText = "Địa chỉ";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1569, 23);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(263, 27);
            textBox4.TabIndex = 23;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(1469, 18);
            label4.Name = "label4";
            label4.Size = new Size(109, 32);
            label4.TabIndex = 22;
            label4.Text = "Địa chỉ";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Employee";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private TextBox textBox6;
        private Label label6;
        private Button button4;
        private Button button3;
        private Button button1;
        private TextBox textBox5;
        private Label label5;
        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textBox4;
        private Label label4;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Amount;
    }
}