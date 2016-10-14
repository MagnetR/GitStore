namespace SingleDimArray
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudMonthNumber = new System.Windows.Forms.NumericUpDown();
            this.lblMonthName = new System.Windows.Forms.Label();
            this.lstAllMonth = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAllMonth = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstSortedMonths = new System.Windows.Forms.ListBox();
            this.brnHunting = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstHuntingSeason = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a Month Number";
            // 
            // nudMonthNumber
            // 
            this.nudMonthNumber.Location = new System.Drawing.Point(12, 133);
            this.nudMonthNumber.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonthNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonthNumber.Name = "nudMonthNumber";
            this.nudMonthNumber.Size = new System.Drawing.Size(116, 20);
            this.nudMonthNumber.TabIndex = 1;
            this.nudMonthNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudMonthNumber.ValueChanged += new System.EventHandler(this.nudMonthNumber_ValueChanged);
            // 
            // lblMonthName
            // 
            this.lblMonthName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthName.Location = new System.Drawing.Point(12, 156);
            this.lblMonthName.Name = "lblMonthName";
            this.lblMonthName.Size = new System.Drawing.Size(116, 40);
            this.lblMonthName.TabIndex = 2;
            // 
            // lstAllMonth
            // 
            this.lstAllMonth.FormattingEnabled = true;
            this.lstAllMonth.Location = new System.Drawing.Point(151, 110);
            this.lstAllMonth.Name = "lstAllMonth";
            this.lstAllMonth.Size = new System.Drawing.Size(106, 212);
            this.lstAllMonth.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(151, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "All months";
            // 
            // btnAllMonth
            // 
            this.btnAllMonth.Location = new System.Drawing.Point(174, 356);
            this.btnAllMonth.Name = "btnAllMonth";
            this.btnAllMonth.Size = new System.Drawing.Size(57, 23);
            this.btnAllMonth.TabIndex = 5;
            this.btnAllMonth.Text = "Show All Months";
            this.btnAllMonth.UseVisualStyleBackColor = true;
            this.btnAllMonth.Click += new System.EventHandler(this.btnAllMonth_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show Sorted Months";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(279, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Sorted months";
            // 
            // lstSortedMonths
            // 
            this.lstSortedMonths.FormattingEnabled = true;
            this.lstSortedMonths.Location = new System.Drawing.Point(279, 110);
            this.lstSortedMonths.Name = "lstSortedMonths";
            this.lstSortedMonths.Size = new System.Drawing.Size(116, 212);
            this.lstSortedMonths.TabIndex = 6;
            // 
            // brnHunting
            // 
            this.brnHunting.Location = new System.Drawing.Point(419, 353);
            this.brnHunting.Name = "brnHunting";
            this.brnHunting.Size = new System.Drawing.Size(116, 23);
            this.brnHunting.TabIndex = 11;
            this.brnHunting.Text = "Show Hunting Season";
            this.brnHunting.UseVisualStyleBackColor = true;
            this.brnHunting.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(419, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Hunting Season";
            // 
            // lstHuntingSeason
            // 
            this.lstHuntingSeason.FormattingEnabled = true;
            this.lstHuntingSeason.Location = new System.Drawing.Point(419, 107);
            this.lstHuntingSeason.Name = "lstHuntingSeason";
            this.lstHuntingSeason.Size = new System.Drawing.Size(116, 212);
            this.lstHuntingSeason.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(547, 429);
            this.Controls.Add(this.brnHunting);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstHuntingSeason);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstSortedMonths);
            this.Controls.Add(this.btnAllMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstAllMonth);
            this.Controls.Add(this.lblMonthName);
            this.Controls.Add(this.nudMonthNumber);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMonthNumber;
        private System.Windows.Forms.Label lblMonthName;
        private System.Windows.Forms.ListBox lstAllMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAllMonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstSortedMonths;
        private System.Windows.Forms.Button brnHunting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstHuntingSeason;

    }
}

