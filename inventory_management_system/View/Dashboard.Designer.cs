namespace inventory_management_system.View
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button6 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            dailySellingPriceTxt = new Label();
            label2 = new Label();
            panel6 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            monthlySellingPriceTxt = new Label();
            label7 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 685);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // button8
            // 
            button8.BackColor = Color.White;
            button8.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(0, 528);
            button8.Name = "button8";
            button8.Size = new Size(250, 75);
            button8.TabIndex = 13;
            button8.Text = "Report";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.White;
            button7.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(0, 461);
            button7.Name = "button7";
            button7.Size = new Size(250, 75);
            button7.TabIndex = 11;
            button7.Text = "SellItem";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(-1, 390);
            button5.Name = "button5";
            button5.Size = new Size(250, 75);
            button5.TabIndex = 10;
            button5.Text = "General Expense";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.White;
            button4.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(-3, 176);
            button4.Name = "button4";
            button4.Size = new Size(250, 75);
            button4.TabIndex = 9;
            button4.Text = "Items";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.White;
            button3.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(-1, 318);
            button3.Name = "button3";
            button3.Size = new Size(250, 75);
            button3.TabIndex = 8;
            button3.Text = "Staff";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(-3, 247);
            button2.Name = "button2";
            button2.Size = new Size(250, 75);
            button2.TabIndex = 7;
            button2.Text = "Seller";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom;
            button6.BackColor = Color.FromArgb(255, 89, 94);
            button6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(-5, 609);
            button6.Name = "button6";
            button6.Size = new Size(255, 75);
            button6.TabIndex = 6;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(244, 132, 95);
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(-1, 104);
            button1.Name = "button1";
            button1.Size = new Size(250, 75);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 105);
            panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 106);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 40F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(244, 132, 95);
            label1.Location = new Point(583, 105);
            label1.Name = "label1";
            label1.Size = new Size(568, 76);
            label1.TabIndex = 12;
            label1.Text = "Retail Rice System";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(iconButton2);
            panel4.Controls.Add(dailySellingPriceTxt);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(354, 265);
            panel4.Name = "panel4";
            panel4.Size = new Size(411, 261);
            panel4.TabIndex = 13;
            // 
            // iconButton2
            // 
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            iconButton2.IconColor = Color.FromArgb(242, 112, 89);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton2.Location = new Point(153, 1);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(94, 109);
            iconButton2.TabIndex = 16;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // dailySellingPriceTxt
            // 
            dailySellingPriceTxt.AutoSize = true;
            dailySellingPriceTxt.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dailySellingPriceTxt.ForeColor = Color.FromArgb(242, 112, 89);
            dailySellingPriceTxt.Location = new Point(107, 199);
            dailySellingPriceTxt.Name = "dailySellingPriceTxt";
            dailySellingPriceTxt.Size = new Size(178, 32);
            dailySellingPriceTxt.TabIndex = 1;
            dailySellingPriceTxt.Text = "1000000 (ကျပ်)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(242, 112, 89);
            label2.Location = new Point(92, 128);
            label2.Name = "label2";
            label2.Size = new Size(218, 34);
            label2.TabIndex = 0;
            label2.Text = "တစ်နေ့တာ ရောင်းရငွေ";
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.None;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(iconButton1);
            panel6.Controls.Add(monthlySellingPriceTxt);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(858, 265);
            panel6.Name = "panel6";
            panel6.Size = new Size(423, 261);
            panel6.TabIndex = 14;
            // 
            // iconButton1
            // 
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            iconButton1.IconColor = Color.FromArgb(242, 112, 89);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButton1.Location = new Point(167, 1);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(94, 109);
            iconButton1.TabIndex = 15;
            iconButton1.UseVisualStyleBackColor = true;
            // 
            // monthlySellingPriceTxt
            // 
            monthlySellingPriceTxt.AutoSize = true;
            monthlySellingPriceTxt.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            monthlySellingPriceTxt.ForeColor = Color.FromArgb(242, 112, 89);
            monthlySellingPriceTxt.Location = new Point(125, 199);
            monthlySellingPriceTxt.Name = "monthlySellingPriceTxt";
            monthlySellingPriceTxt.Size = new Size(136, 32);
            monthlySellingPriceTxt.TabIndex = 1;
            monthlySellingPriceTxt.Text = "1000 (ကျပ်)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(242, 112, 89);
            label7.Location = new Point(103, 128);
            label7.Name = "label7";
            label7.Size = new Size(215, 34);
            label7.TabIndex = 0;
            label7.Text = "တစ်လတာ ရောင်းရငွေ";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1374, 686);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(panel1);
            ForeColor = Color.Black;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button6;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button7;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label dailySellingPriceTxt;
        private Label label2;
        private Panel panel6;
        private Label monthlySellingPriceTxt;
        private Label label7;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Button button8;
    }
}