namespace Conference
{
    partial class FormAdminAddConf
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
            this.confName = new System.Windows.Forms.TextBox();
            this.confSubject = new System.Windows.Forms.TextBox();
            this.confPlace = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.confDate = new System.Windows.Forms.MaskedTextBox();
            this.countSpeakers = new System.Windows.Forms.NumericUpDown();
            this.countGuests = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.confTime = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.countSpeakers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // confName
            // 
            this.confName.Location = new System.Drawing.Point(173, 51);
            this.confName.Name = "confName";
            this.confName.Size = new System.Drawing.Size(100, 20);
            this.confName.TabIndex = 0;
            // 
            // confSubject
            // 
            this.confSubject.Location = new System.Drawing.Point(173, 96);
            this.confSubject.Name = "confSubject";
            this.confSubject.Size = new System.Drawing.Size(100, 20);
            this.confSubject.TabIndex = 1;
            // 
            // confPlace
            // 
            this.confPlace.Location = new System.Drawing.Point(173, 184);
            this.confPlace.Name = "confPlace";
            this.confPlace.Size = new System.Drawing.Size(100, 20);
            this.confPlace.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Тема";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Дата и время";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Место";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Мест для выступающих";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Места для гостей";
            // 
            // confDate
            // 
            this.confDate.Location = new System.Drawing.Point(173, 140);
            this.confDate.Mask = "00.00.0000";
            this.confDate.Name = "confDate";
            this.confDate.Size = new System.Drawing.Size(100, 20);
            this.confDate.TabIndex = 12;
            // 
            // countSpeakers
            // 
            this.countSpeakers.Location = new System.Drawing.Point(184, 228);
            this.countSpeakers.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.countSpeakers.Name = "countSpeakers";
            this.countSpeakers.Size = new System.Drawing.Size(120, 20);
            this.countSpeakers.TabIndex = 13;
            // 
            // countGuests
            // 
            this.countGuests.Location = new System.Drawing.Point(184, 274);
            this.countGuests.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.countGuests.Name = "countGuests";
            this.countGuests.Size = new System.Drawing.Size(120, 20);
            this.countGuests.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(510, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Сохр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // confTime
            // 
            this.confTime.Location = new System.Drawing.Point(279, 140);
            this.confTime.Mask = "00:00";
            this.confTime.Name = "confTime";
            this.confTime.Size = new System.Drawing.Size(45, 20);
            this.confTime.TabIndex = 17;
            // 
            // FormAdminAddConf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confTime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.countGuests);
            this.Controls.Add(this.countSpeakers);
            this.Controls.Add(this.confDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confPlace);
            this.Controls.Add(this.confSubject);
            this.Controls.Add(this.confName);
            this.Name = "FormAdminAddConf";
            this.Text = "FormAdminAddConf";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdminAddConf_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.countSpeakers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox confName;
        private System.Windows.Forms.TextBox confSubject;
        private System.Windows.Forms.TextBox confPlace;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox confDate;
        private System.Windows.Forms.NumericUpDown countSpeakers;
        private System.Windows.Forms.NumericUpDown countGuests;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox confTime;
    }
}