﻿namespace inventory_management_system.View.Item
{
    partial class Create
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
            label2 = new Label();
            typeTxt = new TextBox();
            qtyTxt = new TextBox();
            label3 = new Label();
            purchaseTxt = new TextBox();
            label4 = new Label();
            sellingTxt = new TextBox();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(193, 42);
            label1.Name = "label1";
            label1.Size = new Size(156, 38);
            label1.TabIndex = 0;
            label1.Text = "Add Item";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 150);
            label2.Name = "label2";
            label2.Size = new Size(57, 26);
            label2.TabIndex = 1;
            label2.Text = "Type";
            label2.Click += label2_Click;
            // 
            // typeTxt
            // 
            typeTxt.Location = new Point(119, 179);
            typeTxt.Multiline = true;
            typeTxt.Name = "typeTxt";
            typeTxt.Size = new Size(305, 51);
            typeTxt.TabIndex = 2;
            // 
            // qtyTxt
            // 
            qtyTxt.Location = new Point(119, 282);
            qtyTxt.Multiline = true;
            qtyTxt.Name = "qtyTxt";
            qtyTxt.Size = new Size(305, 51);
            qtyTxt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 253);
            label3.Name = "label3";
            label3.Size = new Size(92, 26);
            label3.TabIndex = 3;
            label3.Text = "Quantity";
            // 
            // purchaseTxt
            // 
            purchaseTxt.Location = new Point(119, 379);
            purchaseTxt.Multiline = true;
            purchaseTxt.Name = "purchaseTxt";
            purchaseTxt.Size = new Size(305, 51);
            purchaseTxt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(119, 350);
            label4.Name = "label4";
            label4.Size = new Size(149, 26);
            label4.TabIndex = 5;
            label4.Text = "Purchase Price";
            // 
            // sellingTxt
            // 
            sellingTxt.Location = new Point(119, 476);
            sellingTxt.Multiline = true;
            sellingTxt.Name = "sellingTxt";
            sellingTxt.Size = new Size(305, 51);
            sellingTxt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(119, 447);
            label5.Name = "label5";
            label5.Size = new Size(129, 26);
            label5.TabIndex = 7;
            label5.Text = "Selling Price";
            // 
            // button1
            // 
            button1.BackColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(117, 563);
            button1.Name = "button1";
            button1.Size = new Size(307, 56);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Create
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
            Name = "Create";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox typeTxt;
        private TextBox qtyTxt;
        private Label label3;
        private TextBox purchaseTxt;
        private Label label4;
        private TextBox sellingTxt;
        private Label label5;
        private Button button1;
    }
}