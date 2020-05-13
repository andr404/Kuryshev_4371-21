namespace Conference
{
    partial class FormConferencePresentation
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.radioButtonGuest = new System.Windows.Forms.RadioButton();
            this.radioButtonSpeaker = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // buttonReg
            // 
            this.buttonReg.Location = new System.Drawing.Point(700, 397);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(75, 23);
            this.buttonReg.TabIndex = 1;
            this.buttonReg.Text = "button1";
            this.buttonReg.UseVisualStyleBackColor = true;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(445, 397);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "button2";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(537, 371);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(238, 20);
            this.textBoxTopic.TabIndex = 3;
            this.textBoxTopic.Visible = false;
            // 
            // radioButtonGuest
            // 
            this.radioButtonGuest.AutoSize = true;
            this.radioButtonGuest.Checked = true;
            this.radioButtonGuest.Location = new System.Drawing.Point(240, 371);
            this.radioButtonGuest.Name = "radioButtonGuest";
            this.radioButtonGuest.Size = new System.Drawing.Size(54, 17);
            this.radioButtonGuest.TabIndex = 4;
            this.radioButtonGuest.TabStop = true;
            this.radioButtonGuest.Text = "Гость";
            this.radioButtonGuest.UseVisualStyleBackColor = true;
            this.radioButtonGuest.Visible = false;
            this.radioButtonGuest.CheckedChanged += new System.EventHandler(this.radioButtonGuest_CheckedChanged);
            // 
            // radioButtonSpeaker
            // 
            this.radioButtonSpeaker.AutoSize = true;
            this.radioButtonSpeaker.Location = new System.Drawing.Point(359, 371);
            this.radioButtonSpeaker.Name = "radioButtonSpeaker";
            this.radioButtonSpeaker.Size = new System.Drawing.Size(85, 17);
            this.radioButtonSpeaker.TabIndex = 5;
            this.radioButtonSpeaker.Text = "radioButton2";
            this.radioButtonSpeaker.UseVisualStyleBackColor = true;
            this.radioButtonSpeaker.Visible = false;
            // 
            // FormConferencePresentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonSpeaker);
            this.Controls.Add(this.radioButtonGuest);
            this.Controls.Add(this.textBoxTopic);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormConferencePresentation";
            this.Text = "FormConferencePresentation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConferencePresentation_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.RadioButton radioButtonGuest;
        private System.Windows.Forms.RadioButton radioButtonSpeaker;
    }
}