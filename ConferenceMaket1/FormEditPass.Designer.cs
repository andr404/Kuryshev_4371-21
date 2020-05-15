namespace Conference
{
    partial class FormEditPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditPass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOldPass = new System.Windows.Forms.TextBox();
            this.textBoxNewPass = new System.Windows.Forms.TextBox();
            this.textBoxAgainPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelAttention = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Старый пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Новый пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Повторите пароль";
            // 
            // textBoxOldPass
            // 
            this.textBoxOldPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOldPass.Location = new System.Drawing.Point(1, 1);
            this.textBoxOldPass.Name = "textBoxOldPass";
            this.textBoxOldPass.PasswordChar = '*';
            this.textBoxOldPass.Size = new System.Drawing.Size(280, 26);
            this.textBoxOldPass.TabIndex = 3;
            this.textBoxOldPass.TextChanged += new System.EventHandler(this.textBoxOldPass_TextChanged);
            // 
            // textBoxNewPass
            // 
            this.textBoxNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPass.Location = new System.Drawing.Point(1, 1);
            this.textBoxNewPass.Name = "textBoxNewPass";
            this.textBoxNewPass.PasswordChar = '*';
            this.textBoxNewPass.Size = new System.Drawing.Size(280, 26);
            this.textBoxNewPass.TabIndex = 4;
            this.textBoxNewPass.TextChanged += new System.EventHandler(this.textBoxNewPass_TextChanged);
            // 
            // textBoxAgainPass
            // 
            this.textBoxAgainPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxAgainPass.Location = new System.Drawing.Point(1, 1);
            this.textBoxAgainPass.Name = "textBoxAgainPass";
            this.textBoxAgainPass.PasswordChar = '*';
            this.textBoxAgainPass.Size = new System.Drawing.Size(280, 26);
            this.textBoxAgainPass.TabIndex = 5;
            this.textBoxAgainPass.TextChanged += new System.EventHandler(this.textBoxAgainPass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(127, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Изменение пароля";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(364, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(244, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxOldPass);
            this.panel1.Location = new System.Drawing.Point(196, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 28);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxNewPass);
            this.panel2.Location = new System.Drawing.Point(196, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 28);
            this.panel2.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxAgainPass);
            this.panel3.Location = new System.Drawing.Point(196, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 28);
            this.panel3.TabIndex = 10;
            // 
            // labelAttention
            // 
            this.labelAttention.AutoSize = true;
            this.labelAttention.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttention.ForeColor = System.Drawing.Color.Brown;
            this.labelAttention.Location = new System.Drawing.Point(39, 161);
            this.labelAttention.Name = "labelAttention";
            this.labelAttention.Size = new System.Drawing.Size(446, 34);
            this.labelAttention.TabIndex = 11;
            this.labelAttention.Text = "* Пароль должел быть больше 7 символов и содержать заглавные\r\n буквы и цифры";
            this.labelAttention.Visible = false;
            // 
            // FormEditPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(492, 241);
            this.Controls.Add(this.labelAttention);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEditPass";
            this.Text = "Изменение пароля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditPass_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOldPass;
        private System.Windows.Forms.TextBox textBoxNewPass;
        private System.Windows.Forms.TextBox textBoxAgainPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelAttention;
    }
}