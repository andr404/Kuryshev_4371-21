namespace Conference
{
    partial class FormEnter
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
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.checkRemember = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(314, 83);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 0;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(314, 140);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '*';
            this.textBox_pass.Size = new System.Drawing.Size(100, 20);
            this.textBox_pass.TabIndex = 1;
            // 
            // EnterButton
            // 
            this.EnterButton.Location = new System.Drawing.Point(330, 209);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(75, 23);
            this.EnterButton.TabIndex = 2;
            this.EnterButton.Text = "button1";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // checkRemember
            // 
            this.checkRemember.AutoSize = true;
            this.checkRemember.Location = new System.Drawing.Point(314, 176);
            this.checkRemember.Name = "checkRemember";
            this.checkRemember.Size = new System.Drawing.Size(82, 17);
            this.checkRemember.TabIndex = 3;
            this.checkRemember.Text = "Запомнить";
            this.checkRemember.UseVisualStyleBackColor = true;
            // 
            // FormEnter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkRemember);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_login);
            this.Name = "FormEnter";
            this.Text = "FormEnter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.CheckBox checkRemember;
    }
}