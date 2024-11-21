namespace PhoneWarehouse.Views
{
    partial class XuatKho
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
            ID = new DataGridViewTextBoxColumn();
            textBox8 = new TextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            Day = new DataGridViewTextBoxColumn();
            Quantity = new DataGridViewTextBoxColumn();
            Tong = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            label7 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            Name = new DataGridViewTextBoxColumn();
            label8 = new Label();
            label3 = new Label();
            label2 = new Label();
            button5 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            button2 = new Button();
            groupBox1 = new GroupBox();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ID
            // 
            ID.HeaderText = "Số phiếu";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(1498, 21);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(86, 27);
            textBox8.TabIndex = 45;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(398, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(187, 27);
            textBox3.TabIndex = 35;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(696, 25);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(143, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(87, 27);
            textBox1.TabIndex = 33;
            // 
            // Day
            // 
            Day.HeaderText = "Ngày nhập";
            Day.MinimumWidth = 6;
            Day.Name = "Day";
            // 
            // Quantity
            // 
            Quantity.HeaderText = "Số lượng";
            Quantity.MinimumWidth = 6;
            Quantity.Name = "Quantity";
            // 
            // Tong
            // 
            Tong.HeaderText = "Nhà cung cấp";
            Tong.MinimumWidth = 6;
            Tong.Name = "Tong";
            // 
            // Amount
            // 
            Amount.HeaderText = "Giá";
            Amount.MinimumWidth = 6;
            Amount.Name = "Amount";
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 15F);
            label7.Location = new Point(1617, 9);
            label7.Name = "label7";
            label7.Size = new Size(139, 47);
            label7.TabIndex = 42;
            label7.Text = "Ngày xuất";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(1248, 22);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(121, 27);
            textBox6.TabIndex = 41;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(1142, 11);
            label6.Name = "label6";
            label6.Size = new Size(108, 44);
            label6.TabIndex = 40;
            label6.Text = "Đơn giá";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1032, 24);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(86, 27);
            textBox5.TabIndex = 38;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(923, 10);
            label5.Name = "label5";
            label5.Size = new Size(115, 47);
            label5.TabIndex = 37;
            label5.Text = "Số lượng";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Name
            // 
            Name.HeaderText = "Tổng giá";
            Name.MinimumWidth = 6;
            Name.Name = "Name";
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 15F);
            label8.Location = new Point(1387, 9);
            label8.Name = "label8";
            label8.Size = new Size(115, 47);
            label8.TabIndex = 44;
            label8.Text = "Tổng giá";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(258, 10);
            label3.Name = "label3";
            label3.Size = new Size(148, 44);
            label3.TabIndex = 32;
            label3.Text = "Người xuất";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(639, 12);
            label2.Name = "label2";
            label2.Size = new Size(60, 44);
            label2.TabIndex = 31;
            label2.Text = "Đến";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // button5
            // 
            button5.Location = new Point(1719, 62);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 25;
            button5.Text = "Tìm";
            button5.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(1569, 62);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(144, 27);
            textBox4.TabIndex = 21;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(1455, 42);
            label4.Name = "label4";
            label4.Size = new Size(123, 57);
            label4.TabIndex = 20;
            label4.Text = "Tìm kiếm";
            label4.TextAlign = ContentAlignment.MiddleCenter;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(-4, 894);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1910, 136);
            groupBox1.TabIndex = 39;
            groupBox1.TabStop = false;
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
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(37, 5);
            label1.Name = "label1";
            label1.Size = new Size(114, 57);
            label1.TabIndex = 30;
            label1.Text = "Số phiếu";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Tong, Day, Quantity, Amount, Name });
            dataGridView1.Location = new Point(-4, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1910, 838);
            dataGridView1.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1756, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(123, 27);
            dateTimePicker1.TabIndex = 46;
            dateTimePicker1.Value = new DateTime(2024, 10, 13, 23, 59, 27, 0);
            // 
            // XuatKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox8);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StockOut";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn ID;
        private TextBox textBox8;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn Day;
        private DataGridViewTextBoxColumn Quantity;
        private DataGridViewTextBoxColumn Tong;
        private DataGridViewTextBoxColumn Amount;
        private Label label7;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox5;
        private Label label5;
        private DataGridViewTextBoxColumn Name;
        private Label label8;
        private Label label3;
        private Label label2;
        private Button button5;
        private TextBox textBox4;
        private Label label4;
        private Button button2;
        private GroupBox groupBox1;
        private Button button4;
        private Button button3;
        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
    }
}