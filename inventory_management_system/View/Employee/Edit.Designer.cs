namespace inventory_management_system.View.Employee
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
            salaryTxt = new TextBox();
            label4 = new Label();
            numberTxt = new TextBox();
            label3 = new Label();
            roleTxt = new TextBox();
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
            button1.Location = new Point(117, 567);
            button1.Name = "button1";
            button1.Size = new Size(307, 56);
            button1.TabIndex = 28;
            button1.Text = "Update";
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
            // salaryTxt
            // 
            salaryTxt.Location = new Point(117, 452);
            salaryTxt.Multiline = true;
            salaryTxt.Name = "salaryTxt";
            salaryTxt.Size = new Size(305, 51);
            salaryTxt.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(117, 411);
            label4.Name = "label4";
            label4.Size = new Size(70, 26);
            label4.TabIndex = 25;
            label4.Text = "Salary";
            // 
            // numberTxt
            // 
            numberTxt.Location = new Point(117, 328);
            numberTxt.Multiline = true;
            numberTxt.Name = "numberTxt";
            numberTxt.Size = new Size(305, 51);
            numberTxt.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(117, 290);
            label3.Name = "label3";
            label3.Size = new Size(88, 26);
            label3.TabIndex = 23;
            label3.Text = "Number";
            // 
            // roleTxt
            // 
            roleTxt.Location = new Point(117, 209);
            roleTxt.Multiline = true;
            roleTxt.Name = "roleTxt";
            roleTxt.Size = new Size(305, 51);
            roleTxt.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(117, 180);
            label2.Name = "label2";
            label2.Size = new Size(55, 26);
            label2.TabIndex = 21;
            label2.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(166, 70);
            label1.Name = "label1";
            label1.Size = new Size(231, 38);
            label1.TabIndex = 20;
            label1.Text = "Edit Employee";
            // 
            // Edit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 692);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(salaryTxt);
            Controls.Add(label4);
            Controls.Add(numberTxt);
            Controls.Add(label3);
            Controls.Add(roleTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Edit";
            Text = "Edit";
            Load += Edit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label5;
        private TextBox salaryTxt;
        private Label label4;
        private TextBox numberTxt;
        private Label label3;
        private TextBox roleTxt;
        private Label label2;
        private Label label1;
    }
}