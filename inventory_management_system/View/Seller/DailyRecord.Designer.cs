namespace inventory_management_system.View.Seller
{
    partial class DailyRecord
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
            dailyRecordGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dailyRecordGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(244, 132, 95);
            label1.Location = new Point(505, 37);
            label1.Name = "label1";
            label1.Size = new Size(289, 53);
            label1.TabIndex = 0;
            label1.Text = "Daily Record";
            label1.Click += label1_Click;
            // 
            // dailyRecordGridView
            // 
            dailyRecordGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dailyRecordGridView.BackgroundColor = Color.White;
            dailyRecordGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dailyRecordGridView.Location = new Point(107, 156);
            dailyRecordGridView.Name = "dailyRecordGridView";
            dailyRecordGridView.RowHeadersWidth = 51;
            dailyRecordGridView.Size = new Size(1089, 522);
            dailyRecordGridView.TabIndex = 1;
            // 
            // DailyRecord
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 719);
            Controls.Add(dailyRecordGridView);
            Controls.Add(label1);
            Name = "DailyRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DailyRecord";
            WindowState = FormWindowState.Maximized;
            Load += DailyRecord_Load;
            ((System.ComponentModel.ISupportInitialize)dailyRecordGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dailyRecordGridView;
    }
}