namespace inventory_management_system.View.UserManagement
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
            passwordTxt = new TextBox();
            label4 = new Label();
            userIdTxt = new TextBox();
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
            button1.Location = new Point(117, 546);
            button1.Name = "button1";
            button1.Size = new Size(307, 56);
            button1.TabIndex = 27;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // passwordTxt
            // 
            passwordTxt.Location = new Point(119, 428);
            passwordTxt.Multiline = true;
            passwordTxt.Name = "passwordTxt";
            passwordTxt.Size = new Size(305, 51);
            passwordTxt.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(119, 399);
            label4.Name = "label4";
            label4.Size = new Size(102, 26);
            label4.TabIndex = 25;
            label4.Text = "Password";
            // 
            // userIdTxt
            // 
            userIdTxt.Location = new Point(119, 331);
            userIdTxt.Multiline = true;
            userIdTxt.Name = "userIdTxt";
            userIdTxt.Size = new Size(305, 51);
            userIdTxt.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(119, 302);
            label3.Name = "label3";
            label3.Size = new Size(32, 26);
            label3.TabIndex = 23;
            label3.Text = "Id";
            // 
            // nameTxt
            // 
            nameTxt.Location = new Point(119, 228);
            nameTxt.Multiline = true;
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(305, 51);
            nameTxt.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(119, 199);
            label2.Name = "label2";
            label2.Size = new Size(66, 26);
            label2.TabIndex = 21;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.CornflowerBlue;
            label1.Location = new Point(193, 91);
            label1.Name = "label1";
            label1.Size = new Size(156, 38);
            label1.TabIndex = 20;
            label1.Text = "Add User";
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(541, 692);
            Controls.Add(button1);
            Controls.Add(passwordTxt);
            Controls.Add(label4);
            Controls.Add(userIdTxt);
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
        private TextBox passwordTxt;
        private Label label4;
        private TextBox userIdTxt;
        private Label label3;
        private TextBox nameTxt;
        private Label label2;
        private Label label1;
    }
}