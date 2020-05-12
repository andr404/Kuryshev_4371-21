namespace Conference
{
    partial class FormAdminEdit
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
            this.confTime = new System.Windows.Forms.MaskedTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.countGuests = new System.Windows.Forms.NumericUpDown();
            this.countSpeakers = new System.Windows.Forms.NumericUpDown();
            this.confDate = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confPlace = new System.Windows.Forms.TextBox();
            this.confSubject = new System.Windows.Forms.TextBox();
            this.confName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.countGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countSpeakers)).BeginInit();
            this.SuspendLayout();
            // 
            // confTime
            // 
            this.confTime.Location = new System.Drawing.Point(291, 124);
            this.confTime.Mask = "00:00";
            this.confTime.Name = "confTime";
            this.confTime.Size = new System.Drawing.Size(45, 20);
            this.confTime.TabIndex = 32;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(261, 357);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(522, 357);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 30;
            this.buttonSave.Text = "Сохр";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // countGuests
            // 
            this.countGuests.Location = new System.Drawing.Point(196, 258);
            this.countGuests.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.countGuests.Name = "countGuests";
            this.countGuests.Size = new System.Drawing.Size(120, 20);
            this.countGuests.TabIndex = 29;
            // 
            // countSpeakers
            // 
            this.countSpeakers.Location = new System.Drawing.Point(196, 212);
            this.countSpeakers.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.countSpeakers.Name = "countSpeakers";
            this.countSpeakers.Size = new System.Drawing.Size(120, 20);
            this.countSpeakers.TabIndex = 28;
            // 
            // confDate
            // 
            this.confDate.Location = new System.Drawing.Point(185, 124);
            this.confDate.Mask = "00.00.0000";
            this.confDate.Name = "confDate";
            this.confDate.Size = new System.Drawing.Size(100, 20);
            this.confDate.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Места для гостей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Мест для выступающих";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Место";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Дата и время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Тема";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Название";
            // 
            // confPlace
            // 
            this.confPlace.Location = new System.Drawing.Point(185, 168);
            this.confPlace.Name = "confPlace";
            this.confPlace.Size = new System.Drawing.Size(100, 20);
            this.confPlace.TabIndex = 20;
            // 
            // confSubject
            // 
            this.confSubject.Location = new System.Drawing.Point(185, 80);
            this.confSubject.Name = "confSubject";
            this.confSubject.Size = new System.Drawing.Size(100, 20);
            this.confSubject.TabIndex = 19;
            // 
            // confName
            // 
            this.confName.Location = new System.Drawing.Point(185, 35);
            this.confName.Name = "confName";
            this.confName.Size = new System.Drawing.Size(100, 20);
            this.confName.TabIndex = 18;
            // 
            // FormAdminEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.confTime);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonSave);
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
            this.Name = "FormAdminEdit";
            this.Text = "FormAdminEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdminEdit_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.countGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countSpeakers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox confTime;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.NumericUpDown countGuests;
        private System.Windows.Forms.NumericUpDown countSpeakers;
        private System.Windows.Forms.MaskedTextBox confDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confPlace;
        private System.Windows.Forms.TextBox confSubject;
        private System.Windows.Forms.TextBox confName;
    }
}