namespace inventory_management_system.View.General
{
    partial class Index
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
            panel1 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button6 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            addBtn = new Button();
            GeneralGridView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GeneralGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 685);
            panel1.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.CornflowerBlue;
            button5.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(-1, 390);
            button5.Name = "button5";
            button5.Size = new Size(250, 75);
            button5.TabIndex = 10;
            button5.Text = "General";
            button5.UseVisualStyleBackColor = false;
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
            button3.Text = "Employee";
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
            button6.BackColor = Color.Red;
            button6.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button6.ForeColor = Color.White;
            button6.Location = new Point(-5, 609);
            button6.Name = "button6";
            button6.Size = new Size(255, 75);
            button6.TabIndex = 6;
            button6.Text = "Logout";
            button6.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(-1, 104);
            button1.Name = "button1";
            button1.Size = new Size(250, 75);
            button1.TabIndex = 1;
            button1.Text = "Dashboard";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 105);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(0, 101);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 125);
            panel3.TabIndex = 1;
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.CornflowerBlue;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(280, 107);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(135, 49);
            addBtn.TabIndex = 10;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // GeneralGridView
            // 
            GeneralGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GeneralGridView.Location = new Point(280, 175);
            GeneralGridView.Name = "GeneralGridView";
            GeneralGridView.RowHeadersWidth = 51;
            GeneralGridView.Size = new Size(1070, 512);
            GeneralGridView.TabIndex = 9;
            GeneralGridView.CellContentClick += GeneralGridView_CellContentClick;
            // 
            // Index
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 686);
            Controls.Add(addBtn);
            Controls.Add(GeneralGridView);
            Controls.Add(panel1);
            Name = "Index";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Index";
            Load += Index_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GeneralGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button6;
        private Button button1;
        private Panel panel2;
        private Panel panel3;
        private Button addBtn;
        private DataGridView GeneralGridView;
    }
}