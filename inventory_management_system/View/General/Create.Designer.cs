namespace inventory_management_system.View.General
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
            button1 = new Button();
            label5 = new Label();
            priceTxt = new TextBox();
            label3 = new Label();
            nameTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(244, 132, 95);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(157, 472);
            button1.Name = "button1";
            button1.Size = new Size(231, 56);
            button1.TabIndex = 28;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(117, 477);
            label5.Name = "label5";
            label5.Size = new Size(0, 26);
            label5.TabIndex = 27;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(117, 328);
            priceTxt.Multiline = true;
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(305, 51);
            priceTxt.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(117, 290);
            label3.Name = "label3";
            label3.Size = new Size(59, 26);
            label3.TabIndex = 23;
            label3.Text = "Price";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(117, 209);
            nameTxt.Multiline = true;
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(305, 51);
            nameTxt.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 180);
            label2.Name = "label2";
            label2.Size = new Size(66, 26);
            label2.TabIndex = 21;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(244, 132, 95);
            label1.Location = new Point(166, 70);
            label1.Name = "label1";
            label1.Size = new Size(204, 38);
            label1.TabIndex = 20;
            label1.Text = "Add General";
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 662);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(priceTxt);
            Controls.Add(label3);
            Controls.Add(nameTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Create";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create";
            Load += Create_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private TextBox priceTxt;
        private Label label3;
        private TextBox nameTxt;
        private Label label2;
        private Label label1;
    }
}