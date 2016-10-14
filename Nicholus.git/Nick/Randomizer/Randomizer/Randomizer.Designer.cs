namespace Randomizer
{
    partial class Randomizer
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtResults1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnResults = new System.Windows.Forms.Button();
            this.txtResults2 = new System.Windows.Forms.TextBox();
            this.txtResults3 = new System.Windows.Forms.TextBox();
            this.txtResults4 = new System.Windows.Forms.TextBox();
            this.txtResults5 = new System.Windows.Forms.TextBox();
            this.txtResults6 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 13);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // txtResults1
            // 
            this.txtResults1.Location = new System.Drawing.Point(5, 76);
            this.txtResults1.Name = "txtResults1";
            this.txtResults1.Size = new System.Drawing.Size(35, 20);
            this.txtResults1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Results";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "History";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(210, 102);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnResults
            // 
            this.btnResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResults.Location = new System.Drawing.Point(76, 299);
            this.btnResults.Name = "btnResults";
            this.btnResults.Size = new System.Drawing.Size(75, 23);
            this.btnResults.TabIndex = 5;
            this.btnResults.Text = "DRAW";
            this.btnResults.UseVisualStyleBackColor = true;
            this.btnResults.Click += new System.EventHandler(this.btnResults_Click);
            // 
            // txtResults2
            // 
            this.txtResults2.Location = new System.Drawing.Point(40, 76);
            this.txtResults2.Name = "txtResults2";
            this.txtResults2.Size = new System.Drawing.Size(35, 20);
            this.txtResults2.TabIndex = 6;
            // 
            // txtResults3
            // 
            this.txtResults3.Location = new System.Drawing.Point(75, 76);
            this.txtResults3.Name = "txtResults3";
            this.txtResults3.Size = new System.Drawing.Size(35, 20);
            this.txtResults3.TabIndex = 7;
            // 
            // txtResults4
            // 
            this.txtResults4.Location = new System.Drawing.Point(110, 76);
            this.txtResults4.Name = "txtResults4";
            this.txtResults4.Size = new System.Drawing.Size(35, 20);
            this.txtResults4.TabIndex = 8;
            // 
            // txtResults5
            // 
            this.txtResults5.Location = new System.Drawing.Point(145, 76);
            this.txtResults5.Name = "txtResults5";
            this.txtResults5.Size = new System.Drawing.Size(35, 20);
            this.txtResults5.TabIndex = 9;
            // 
            // txtResults6
            // 
            this.txtResults6.Location = new System.Drawing.Point(180, 76);
            this.txtResults6.Name = "txtResults6";
            this.txtResults6.Size = new System.Drawing.Size(35, 20);
            this.txtResults6.TabIndex = 10;
            // 
            // Randomizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(217, 376);
            this.Controls.Add(this.txtResults6);
            this.Controls.Add(this.txtResults5);
            this.Controls.Add(this.txtResults4);
            this.Controls.Add(this.txtResults3);
            this.Controls.Add(this.txtResults2);
            this.Controls.Add(this.btnResults);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResults1);
            this.Controls.Add(this.dateTimePicker1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Randomizer";
            this.Text = "Lucky Numbers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtResults1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnResults;
        private System.Windows.Forms.TextBox txtResults2;
        private System.Windows.Forms.TextBox txtResults3;
        private System.Windows.Forms.TextBox txtResults4;
        private System.Windows.Forms.TextBox txtResults5;
        private System.Windows.Forms.TextBox txtResults6;
    }
}

