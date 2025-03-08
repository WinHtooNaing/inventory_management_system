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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            sellerNameLabel = new Label();
            Logout = new LinkLabel();
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
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(sellerNameLabel);
            panel1.Controls.Add(Logout);
            panel1.Location = new Point(2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1527, 75);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(244, 132, 95);
            label1.Location = new Point(38, 7);
            label1.Name = "label1";
            label1.Size = new Size(409, 57);
            label1.TabIndex = 4;
            label1.Text = "Retail Rice System";
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkLabel1.LinkColor = Color.FromArgb(244, 132, 95);
            linkLabel1.Location = new Point(1235, 28);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(152, 29);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Daily Record";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // sellerNameLabel
            // 
            sellerNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sellerNameLabel.AutoSize = true;
            sellerNameLabel.Font = new Font("Times New Roman", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            sellerNameLabel.ForeColor = Color.FromArgb(244, 132, 95);
            sellerNameLabel.Location = new Point(1108, 27);
            sellerNameLabel.Name = "sellerNameLabel";
            sellerNameLabel.Size = new Size(71, 30);
            sellerNameLabel.TabIndex = 2;
            sellerNameLabel.Text = "name";
            sellerNameLabel.Click += label1_Click;
            // 
            // Logout
            // 
            Logout.ActiveLinkColor = Color.FromArgb(255, 89, 94);
            Logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Logout.AutoSize = true;
            Logout.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logout.LinkColor = Color.FromArgb(255, 89, 94);
            Logout.Location = new Point(1403, 27);
            Logout.Name = "Logout";
            Logout.Size = new Size(89, 29);
            Logout.TabIndex = 1;
            Logout.TabStop = true;
            Logout.Text = "Logout";
            Logout.LinkClicked += Logout_LinkClicked;
            // 
            // itemGridView
            // 
            itemGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            itemGridView.BackgroundColor = Color.White;
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
            fakeDataGridView.BackgroundColor = Color.White;
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
            cancleBtn.BackColor = Color.FromArgb(255, 89, 94);
            cancleBtn.Cursor = Cursors.Hand;
            cancleBtn.FlatStyle = FlatStyle.Flat;
            cancleBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancleBtn.ForeColor = Color.White;
            cancleBtn.Location = new Point(1158, 675);
            cancleBtn.Name = "cancleBtn";
            cancleBtn.Size = new Size(163, 58);
            cancleBtn.TabIndex = 4;
            cancleBtn.Text = "Cancel";
            cancleBtn.UseVisualStyleBackColor = false;
            cancleBtn.Click += cancleBtn_Click;
            // 
            // sellBtn
            // 
            sellBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            sellBtn.BackColor = Color.FromArgb(244, 132, 95);
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
            BackColor = Color.White;
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
        private Label sellerNameLabel;
        private LinkLabel Logout;
        private DataGridView itemGridView;
        private DataGridView fakeDataGridView;
        private Label totalPriceTxt;
        private Button cancleBtn;
        private Button sellBtn;
        private LinkLabel linkLabel1;
        private Label label1;
    }
}