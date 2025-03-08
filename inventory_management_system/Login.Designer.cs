namespace inventory_management_system
{
    partial class Login
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
            idTxt = new TextBox();
            pwdTxt = new TextBox();
            button1 = new Button();
            label3 = new Label();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(244, 132, 95);
            label1.Location = new Point(198, 38);
            label1.Name = "label1";
            label1.Size = new Size(424, 57);
            label1.TabIndex = 0;
            label1.Text = "Retail Rice System";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(244, 132, 95);
            label2.Location = new Point(241, 187);
            label2.Name = "label2";
            label2.Size = new Size(46, 34);
            label2.TabIndex = 1;
            label2.Text = "ID";
            label2.Click += label2_Click;
            // 
            // idTxt
            // 
            idTxt.Location = new Point(334, 157);
            idTxt.Multiline = true;
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(243, 56);
            idTxt.TabIndex = 2;
            // 
            // pwdTxt
            // 
            pwdTxt.Location = new Point(334, 246);
            pwdTxt.Multiline = true;
            pwdTxt.Name = "pwdTxt";
            pwdTxt.PasswordChar = '*';
            pwdTxt.Size = new Size(243, 53);
            pwdTxt.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(244, 132, 95);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(315, 375);
            button1.Name = "button1";
            button1.Size = new Size(166, 50);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(244, 132, 95);
            label3.Location = new Point(182, 265);
            label3.Name = "label3";
            label3.Size = new Size(128, 34);
            label3.TabIndex = 6;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.FromArgb(244, 132, 95);
            checkBox1.Location = new Point(512, 305);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(65, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "show";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(pwdTxt);
            Controls.Add(idTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox idTxt;
        private TextBox pwdTxt;
        private Button button1;
        private Label label3;
        private CheckBox checkBox1;
    }
}