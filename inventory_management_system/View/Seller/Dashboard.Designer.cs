namespace inventory_management_system.Seller
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
            panel1 = new Panel();
            sellerNameLabel = new Label();
            Logout = new LinkLabel();
            panel2 = new Panel();
            itemGridView = new DataGridView();
            fakeDataGridView = new DataGridView();
            totalPriceTxt = new Label();
            cancleBtn = new Button();
            sellBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)itemGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fakeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(sellerNameLabel);
            panel1.Controls.Add(Logout);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1527, 66);
            panel1.TabIndex = 0;
            // 
            // sellerNameLabel
            // 
            sellerNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sellerNameLabel.AutoSize = true;
            sellerNameLabel.Location = new Point(1344, 29);
            sellerNameLabel.Name = "sellerNameLabel";
            sellerNameLabel.Size = new Size(46, 20);
            sellerNameLabel.TabIndex = 2;
            sellerNameLabel.Text = "name";
            sellerNameLabel.Click += label1_Click;
            // 
            // Logout
            // 
            Logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Logout.AutoSize = true;
            Logout.Location = new Point(1451, 29);
            Logout.Name = "Logout";
            Logout.Size = new Size(56, 20);
            Logout.TabIndex = 1;
            Logout.TabStop = true;
            Logout.Text = "Logout";
            Logout.LinkClicked += Logout_LinkClicked;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(299, 64);
            panel2.TabIndex = 0;
            // 
            // itemGridView
            // 
            itemGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            itemGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            itemGridView.Location = new Point(12, 120);
            itemGridView.Name = "itemGridView";
            itemGridView.RowHeadersWidth = 51;
            itemGridView.Size = new Size(891, 497);
            itemGridView.TabIndex = 1;
            itemGridView.CellContentClick += itemGridView_CellContentClick;
            // 
            // fakeDataGridView
            // 
            fakeDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            fakeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            fakeDataGridView.Location = new Point(945, 120);
            fakeDataGridView.Name = "fakeDataGridView";
            fakeDataGridView.RowHeadersWidth = 51;
            fakeDataGridView.Size = new Size(564, 497);
            fakeDataGridView.TabIndex = 2;
            fakeDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // totalPriceTxt
            // 
            totalPriceTxt.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalPriceTxt.AutoSize = true;
            totalPriceTxt.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalPriceTxt.Location = new Point(1248, 634);
            totalPriceTxt.Name = "totalPriceTxt";
            totalPriceTxt.Size = new Size(113, 38);
            totalPriceTxt.TabIndex = 3;
            totalPriceTxt.Text = "00MMK";
            // 
            // cancleBtn
            // 
            cancleBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancleBtn.BackColor = Color.IndianRed;
            cancleBtn.Cursor = Cursors.Hand;
            cancleBtn.FlatStyle = FlatStyle.Flat;
            cancleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancleBtn.ForeColor = Color.White;
            cancleBtn.Location = new Point(1158, 675);
            cancleBtn.Name = "cancleBtn";
            cancleBtn.Size = new Size(163, 58);
            cancleBtn.TabIndex = 4;
            cancleBtn.Text = "Cancle";
            cancleBtn.UseVisualStyleBackColor = false;
            cancleBtn.Click += cancleBtn_Click;
            // 
            // sellBtn
            // 
            sellBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sellBtn.BackColor = Color.DarkOrange;
            sellBtn.Cursor = Cursors.Hand;
            sellBtn.FlatStyle = FlatStyle.Flat;
            sellBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sellBtn.ForeColor = Color.White;
            sellBtn.Location = new Point(1346, 675);
            sellBtn.Name = "sellBtn";
            sellBtn.Size = new Size(163, 58);
            sellBtn.TabIndex = 5;
            sellBtn.Text = "Sell";
            sellBtn.UseVisualStyleBackColor = false;
            sellBtn.Click += sellBtn_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1530, 745);
            Controls.Add(sellBtn);
            Controls.Add(cancleBtn);
            Controls.Add(totalPriceTxt);
            Controls.Add(fakeDataGridView);
            Controls.Add(itemGridView);
            Controls.Add(panel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)itemGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)fakeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label sellerNameLabel;
        private LinkLabel Logout;
        private DataGridView itemGridView;
        private DataGridView fakeDataGridView;
        private Label totalPriceTxt;
        private Button cancleBtn;
        private Button sellBtn;
    }
}