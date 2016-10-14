namespace IPODemo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lstInfor = new System.Windows.Forms.ListBox();
            this.tmrRandoColour = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.cboTittle = new System.Windows.Forms.ComboBox();
            this.chkIsMale = new System.Windows.Forms.CheckBox();
            this.btnShowInfor = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstInfor
            // 
            this.lstInfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstInfor.FormattingEnabled = true;
            this.lstInfor.Location = new System.Drawing.Point(12, 259);
            this.lstInfor.Name = "lstInfor";
            this.lstInfor.Size = new System.Drawing.Size(388, 95);
            this.lstInfor.TabIndex = 3;
            this.lstInfor.TabStop = false;
            // 
            // tmrRandoColour
            // 
            this.tmrRandoColour.Enabled = true;
            this.tmrRandoColour.Interval = 1000;
            this.tmrRandoColour.Tick += new System.EventHandler(this.tmrRandoColour_Tick);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(312, 360);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpDateOfBirth);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.cboTittle);
            this.panel1.Controls.Add(this.chkIsMale);
            this.panel1.Controls.Add(this.btnShowInfor);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 230);
            this.panel1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Date Of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Surname";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tittle";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(180, 156);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(172, 20);
            this.dtpDateOfBirth.TabIndex = 15;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(180, 127);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(172, 20);
            this.txtSurname.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(180, 89);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(172, 20);
            this.txtFirstName.TabIndex = 13;
            // 
            // cboTittle
            // 
            this.cboTittle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTittle.FormattingEnabled = true;
            this.cboTittle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Miss.",
            "Dr.",
            "Prof.",
            "HRH.",
            "Hon."});
            this.cboTittle.Location = new System.Drawing.Point(180, 3);
            this.cboTittle.Name = "cboTittle";
            this.cboTittle.Size = new System.Drawing.Size(172, 21);
            this.cboTittle.TabIndex = 11;
            // 
            // chkIsMale
            // 
            this.chkIsMale.AutoSize = true;
            this.chkIsMale.Location = new System.Drawing.Point(180, 46);
            this.chkIsMale.Name = "chkIsMale";
            this.chkIsMale.Size = new System.Drawing.Size(49, 17);
            this.chkIsMale.TabIndex = 12;
            this.chkIsMale.Text = "Male";
            this.chkIsMale.UseVisualStyleBackColor = true;
            // 
            // btnShowInfor
            // 
            this.btnShowInfor.BackColor = System.Drawing.Color.LightGreen;
            this.btnShowInfor.Location = new System.Drawing.Point(105, 192);
            this.btnShowInfor.Name = "btnShowInfor";
            this.btnShowInfor.Size = new System.Drawing.Size(124, 23);
            this.btnShowInfor.TabIndex = 16;
            this.btnShowInfor.Text = "Show Information";
            this.btnShowInfor.UseVisualStyleBackColor = false;
            this.btnShowInfor.Click += new System.EventHandler(this.btnShowInfor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(412, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstInfor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstInfor;
        private System.Windows.Forms.Timer tmrRandoColour;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ComboBox cboTittle;
        private System.Windows.Forms.CheckBox chkIsMale;
        private System.Windows.Forms.Button btnShowInfor;
    }
}

