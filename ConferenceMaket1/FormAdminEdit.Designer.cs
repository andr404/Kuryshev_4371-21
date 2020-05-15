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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdminEdit));
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
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.countGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countSpeakers)).BeginInit();
            this.SuspendLayout();
            // 
            // confTime
            // 
            this.confTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confTime.Location = new System.Drawing.Point(274, 178);
            this.confTime.Mask = "00:00";
            this.confTime.Name = "confTime";
            this.confTime.Size = new System.Drawing.Size(45, 26);
            this.confTime.TabIndex = 32;
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose.Location = new System.Drawing.Point(148, 286);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(141, 32);
            this.buttonClose.TabIndex = 31;
            this.buttonClose.Text = "Отмена";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(403, 286);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(141, 32);
            this.buttonSave.TabIndex = 30;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // countGuests
            // 
            this.countGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countGuests.Location = new System.Drawing.Point(254, 244);
            this.countGuests.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.countGuests.Name = "countGuests";
            this.countGuests.Size = new System.Drawing.Size(76, 26);
            this.countGuests.TabIndex = 29;
            // 
            // countSpeakers
            // 
            this.countSpeakers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countSpeakers.Location = new System.Drawing.Point(254, 212);
            this.countSpeakers.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.countSpeakers.Name = "countSpeakers";
            this.countSpeakers.Size = new System.Drawing.Size(76, 26);
            this.countSpeakers.TabIndex = 28;
            // 
            // confDate
            // 
            this.confDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confDate.Location = new System.Drawing.Point(168, 178);
            this.confDate.Mask = "00.00.0000";
            this.confDate.Name = "confDate";
            this.confDate.Size = new System.Drawing.Size(100, 26);
            this.confDate.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(50, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Места для гостей";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(50, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Мест для выступающих";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(50, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Место";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(50, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Дата и время";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(50, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Тема";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Название";
            // 
            // confPlace
            // 
            this.confPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confPlace.Location = new System.Drawing.Point(168, 143);
            this.confPlace.Name = "confPlace";
            this.confPlace.Size = new System.Drawing.Size(472, 26);
            this.confPlace.TabIndex = 20;
            // 
            // confSubject
            // 
            this.confSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confSubject.Location = new System.Drawing.Point(168, 108);
            this.confSubject.Name = "confSubject";
            this.confSubject.Size = new System.Drawing.Size(472, 26);
            this.confSubject.TabIndex = 19;
            // 
            // confName
            // 
            this.confName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confName.Location = new System.Drawing.Point(168, 73);
            this.confName.Name = "confName";
            this.confName.Size = new System.Drawing.Size(472, 26);
            this.confName.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(142, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(402, 31);
            this.label7.TabIndex = 34;
            this.label7.Text = "Редактирование конференции";
            // 
            // FormAdminEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(656, 337);
            this.Controls.Add(this.label7);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormAdminEdit";
            this.Text = "Редактирование конференции";
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
        private System.Windows.Forms.Label label7;
    }
}