namespace inventory_management_system.View.Employee
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
            button1.BackColor = Color.FromArgb(244, 132, 95);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(156, 553);
            button1.Name = "button1";
            button1.Size = new Size(231, 56);
            button1.TabIndex = 19;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(119, 463);
            label5.Name = "label5";
            label5.Size = new Size(0, 26);
            label5.TabIndex = 17;
            // 
            // salaryTxt
            // 
            salaryTxt.Location = new Point(119, 438);
            salaryTxt.Multiline = true;
            salaryTxt.Name = "salaryTxt";
            salaryTxt.Size = new Size(305, 51);
            salaryTxt.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(119, 397);
            label4.Name = "label4";
            label4.Size = new Size(70, 26);
            label4.TabIndex = 15;
            label4.Text = "Salary";
            label4.Click += label4_Click;
            // 
            // numberTxt
            // 
            numberTxt.Location = new Point(119, 314);
            numberTxt.Multiline = true;
            numberTxt.Name = "numberTxt";
            numberTxt.Size = new Size(305, 51);
            numberTxt.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 276);
            label3.Name = "label3";
            label3.Size = new Size(88, 26);
            label3.TabIndex = 13;
            label3.Text = "Number";
            // 
            // roleTxt
            // 
            roleTxt.Location = new Point(119, 195);
            roleTxt.Multiline = true;
            roleTxt.Name = "roleTxt";
            roleTxt.Size = new Size(305, 51);
            roleTxt.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 166);
            label2.Name = "label2";
            label2.Size = new Size(55, 26);
            label2.TabIndex = 11;
            label2.Text = "Role";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(244, 132, 95);
            label1.Location = new Point(168, 56);
            label1.Name = "label1";
            label1.Size = new Size(231, 38);
            label1.TabIndex = 10;
            label1.Text = "Add Employee";
            // 
            // Create
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
            Name = "Create";
            Text = "Create";
            Load += Create_Load;
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