namespace Conference
{
    partial class FormAdminChoiceList
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGuests = new System.Windows.Forms.Button();
            this.buttonSpeakers = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(103, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Какой список вывести?";
            // 
            // buttonGuests
            // 
            this.buttonGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGuests.Location = new System.Drawing.Point(132, 79);
            this.buttonGuests.Name = "buttonGuests";
            this.buttonGuests.Size = new System.Drawing.Size(114, 30);
            this.buttonGuests.TabIndex = 1;
            this.buttonGuests.Text = "Гостей";
            this.buttonGuests.UseVisualStyleBackColor = true;
            this.buttonGuests.Click += new System.EventHandler(this.buttonGuests_Click);
            // 
            // buttonSpeakers
            // 
            this.buttonSpeakers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSpeakers.Location = new System.Drawing.Point(251, 79);
            this.buttonSpeakers.Name = "buttonSpeakers";
            this.buttonSpeakers.Size = new System.Drawing.Size(114, 30);
            this.buttonSpeakers.TabIndex = 2;
            this.buttonSpeakers.Text = "Выступающих";
            this.buttonSpeakers.UseVisualStyleBackColor = true;
            this.buttonSpeakers.Click += new System.EventHandler(this.buttonSpeakers_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(12, 79);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(114, 30);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormAdminChoiceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 130);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSpeakers);
            this.Controls.Add(this.buttonGuests);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdminChoiceList";
            this.Text = "Выбор списка";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdminChoiceList_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuests;
        private System.Windows.Forms.Button buttonSpeakers;
        private System.Windows.Forms.Button buttonCancel;
    }
}