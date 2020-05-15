namespace Conference
{
    partial class FormRegistration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistration));
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.maskedPhone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPassAgain = new System.Windows.Forms.TextBox();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.radioButtonGuest = new System.Windows.Forms.RadioButton();
            this.radioButtonSpeaker = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAbout = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAttention = new System.Windows.Forms.Label();
            this.panelPass = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panelPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPass.Location = new System.Drawing.Point(1, 1);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(403, 26);
            this.textBoxPass.TabIndex = 24;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail.Location = new System.Drawing.Point(1, 1);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(403, 26);
            this.textBoxEmail.TabIndex = 23;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // maskedPhone
            // 
            this.maskedPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedPhone.Location = new System.Drawing.Point(213, 173);
            this.maskedPhone.Mask = "+7(000)000-00-00";
            this.maskedPhone.Name = "maskedPhone";
            this.maskedPhone.Size = new System.Drawing.Size(138, 26);
            this.maskedPhone.TabIndex = 22;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLastName.Location = new System.Drawing.Point(213, 141);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(403, 26);
            this.textBoxLastName.TabIndex = 21;
            this.textBoxLastName.TextChanged += new System.EventHandler(this.textBoxLastName_TextChanged);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(213, 109);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(403, 26);
            this.textBoxName.TabIndex = 20;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurname.Location = new System.Drawing.Point(213, 77);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(403, 26);
            this.textBoxSurname.TabIndex = 19;
            this.textBoxSurname.TextChanged += new System.EventHandler(this.textBoxSurname_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(55, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Пароль";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(55, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Почта";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(55, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Телефон";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(55, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(55, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(55, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Фамилия";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(55, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Повторите пароль";
            // 
            // textBoxPassAgain
            // 
            this.textBoxPassAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassAgain.Location = new System.Drawing.Point(213, 274);
            this.textBoxPassAgain.Name = "textBoxPassAgain";
            this.textBoxPassAgain.PasswordChar = '*';
            this.textBoxPassAgain.Size = new System.Drawing.Size(403, 26);
            this.textBoxPassAgain.TabIndex = 26;
            // 
            // buttonReg
            // 
            this.buttonReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.Location = new System.Drawing.Point(435, 435);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(181, 36);
            this.buttonReg.TabIndex = 27;
            this.buttonReg.Text = "Зарегистрироваться";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(304, 435);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 36);
            this.buttonCancel.TabIndex = 28;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // radioButtonGuest
            // 
            this.radioButtonGuest.AutoSize = true;
            this.radioButtonGuest.Checked = true;
            this.radioButtonGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonGuest.Location = new System.Drawing.Point(280, 317);
            this.radioButtonGuest.Name = "radioButtonGuest";
            this.radioButtonGuest.Size = new System.Drawing.Size(71, 24);
            this.radioButtonGuest.TabIndex = 29;
            this.radioButtonGuest.TabStop = true;
            this.radioButtonGuest.Text = "Гость";
            this.radioButtonGuest.UseVisualStyleBackColor = true;
            // 
            // radioButtonSpeaker
            // 
            this.radioButtonSpeaker.AutoSize = true;
            this.radioButtonSpeaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonSpeaker.Location = new System.Drawing.Point(380, 317);
            this.radioButtonSpeaker.Name = "radioButtonSpeaker";
            this.radioButtonSpeaker.Size = new System.Drawing.Size(134, 24);
            this.radioButtonSpeaker.TabIndex = 30;
            this.radioButtonSpeaker.Text = "Выступающий";
            this.radioButtonSpeaker.UseVisualStyleBackColor = true;
            this.radioButtonSpeaker.CheckedChanged += new System.EventHandler(this.radioButtonSpeaker_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(55, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "О себе:";
            this.label8.Visible = false;
            // 
            // textBoxAbout
            // 
            this.textBoxAbout.Location = new System.Drawing.Point(135, 357);
            this.textBoxAbout.Name = "textBoxAbout";
            this.textBoxAbout.Size = new System.Drawing.Size(481, 20);
            this.textBoxAbout.TabIndex = 33;
            this.textBoxAbout.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(255, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(174, 31);
            this.label9.TabIndex = 34;
            this.label9.Text = "Регистрация";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(55, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(202, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Зарегистрироваться как:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Location = new System.Drawing.Point(213, 203);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 28);
            this.panel1.TabIndex = 36;
            // 
            // labelAttention
            // 
            this.labelAttention.AutoSize = true;
            this.labelAttention.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAttention.ForeColor = System.Drawing.Color.Brown;
            this.labelAttention.Location = new System.Drawing.Point(56, 389);
            this.labelAttention.Name = "labelAttention";
            this.labelAttention.Size = new System.Drawing.Size(446, 34);
            this.labelAttention.TabIndex = 37;
            this.labelAttention.Text = "* Пароль должел быть больше 7 символов и содержать заглавные\r\n буквы и цифры";
            this.labelAttention.Visible = false;
            // 
            // panelPass
            // 
            this.panelPass.Controls.Add(this.textBoxPass);
            this.panelPass.Location = new System.Drawing.Point(213, 237);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(405, 28);
            this.panelPass.TabIndex = 38;
            // 
            // FormRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(677, 483);
            this.Controls.Add(this.panelPass);
            this.Controls.Add(this.labelAttention);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxAbout);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.radioButtonSpeaker);
            this.Controls.Add(this.radioButtonGuest);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.textBoxPassAgain);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormRegistration";
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRegistration_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelPass.ResumeLayout(false);
            this.panelPass.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.MaskedTextBox maskedPhone;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPassAgain;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioButtonGuest;
        private System.Windows.Forms.RadioButton radioButtonSpeaker;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxAbout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAttention;
        private System.Windows.Forms.Panel panelPass;
    }
}