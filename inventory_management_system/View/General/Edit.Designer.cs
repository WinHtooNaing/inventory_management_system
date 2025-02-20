namespace inventory_management_system.View.General
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
            button1.BackColor = Color.CornflowerBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(117, 498);
            button1.Name = "button1";
            button1.Size = new Size(307, 56);
            button1.TabIndex = 35;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(119, 516);
            label5.Name = "label5";
            label5.Size = new Size(0, 26);
            label5.TabIndex = 34;
            // 
            // priceTxt
            // 
            priceTxt.Location = new Point(119, 367);
            priceTxt.Multiline = true;
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(305, 51);
            priceTxt.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 329);
            label3.Name = "label3";
            label3.Size = new Size(59, 26);
            label3.TabIndex = 32;
            label3.Text = "Price";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(119, 248);
            nameTxt.Multiline = true;
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(305, 51);
            nameTxt.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 219);
            label2.Name = "label2";
            label2.Size = new Size(66, 26);
            label2.TabIndex = 30;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(168, 109);
            label1.Name = "label1";
            label1.Size = new Size(204, 38);
            label1.TabIndex = 29;
            label1.Text = "Edit General";
            // 
            // Edit
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
            Name = "Edit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Edit";
            Load += Edit_Load;
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