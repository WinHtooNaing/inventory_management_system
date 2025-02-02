namespace inventory_management_system.View.Item
{
    partial class Edit
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
            button1 = new Button();
            sellingTxt = new TextBox();
            label5 = new Label();
            purchaseTxt = new TextBox();
            label4 = new Label();
            qtyTxt = new TextBox();
            label3 = new Label();
            typeTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(117, 579);
            button1.Name = "button1";
            button1.Size = new Size(307, 56);
            button1.TabIndex = 19;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // sellingTxt
            // 
            sellingTxt.Location = new Point(119, 492);
            sellingTxt.Multiline = true;
            sellingTxt.Name = "sellingTxt";
            sellingTxt.Size = new Size(305, 51);
            sellingTxt.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(119, 463);
            label5.Name = "label5";
            label5.Size = new Size(129, 26);
            label5.TabIndex = 17;
            label5.Text = "Selling Price";
            // 
            // purchaseTxt
            // 
            purchaseTxt.Location = new Point(119, 395);
            purchaseTxt.Multiline = true;
            purchaseTxt.Name = "purchaseTxt";
            purchaseTxt.Size = new Size(305, 51);
            purchaseTxt.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(119, 366);
            label4.Name = "label4";
            label4.Size = new Size(149, 26);
            label4.TabIndex = 15;
            label4.Text = "Purchase Price";
            // 
            // qtyTxt
            // 
            qtyTxt.Location = new Point(119, 298);
            qtyTxt.Multiline = true;
            qtyTxt.Name = "qtyTxt";
            qtyTxt.Size = new Size(305, 51);
            qtyTxt.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 269);
            label3.Name = "label3";
            label3.Size = new Size(92, 26);
            label3.TabIndex = 13;
            label3.Text = "Quantity";
            // 
            // typeTxt
            // 
            typeTxt.Location = new Point(119, 195);
            typeTxt.Multiline = true;
            typeTxt.Name = "typeTxt";
            typeTxt.Size = new Size(305, 51);
            typeTxt.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 166);
            label2.Name = "label2";
            label2.Size = new Size(57, 26);
            label2.TabIndex = 11;
            label2.Text = "Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(193, 58);
            label1.Name = "label1";
            label1.Size = new Size(156, 38);
            label1.TabIndex = 10;
            label1.Text = "Edit Item";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 692);
            Controls.Add(button1);
            Controls.Add(sellingTxt);
            Controls.Add(label5);
            Controls.Add(purchaseTxt);
            Controls.Add(label4);
            Controls.Add(qtyTxt);
            Controls.Add(label3);
            Controls.Add(typeTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            Load += Edit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox sellingTxt;
        private Label label5;
        private TextBox purchaseTxt;
        private Label label4;
        private TextBox qtyTxt;
        private Label label3;
        private TextBox typeTxt;
        private Label label2;
        private Label label1;
    }
}