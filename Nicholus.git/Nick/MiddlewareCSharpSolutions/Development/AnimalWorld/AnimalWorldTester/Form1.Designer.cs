namespace AnimalWorldTester
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
            this.cboAnimals = new System.Windows.Forms.ComboBox();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cboAnimals
            // 
            this.cboAnimals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAnimals.FormattingEnabled = true;
            this.cboAnimals.Items.AddRange(new object[] {
            "[Please select a type of animal ...]",
            "Any Animal",
            "Wild Animal",
            "Farm Animal",
            "Horse",
            "Cow"});
            this.cboAnimals.Location = new System.Drawing.Point(67, 79);
            this.cboAnimals.Name = "cboAnimals";
            this.cboAnimals.Size = new System.Drawing.Size(427, 21);
            this.cboAnimals.TabIndex = 0;
            this.cboAnimals.SelectedIndexChanged += new System.EventHandler(this.cboAnimals_SelectedIndexChanged);
            // 
            // lstInfo
            // 
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.Location = new System.Drawing.Point(67, 164);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(427, 238);
            this.lstInfo.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 461);
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.cboAnimals);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAnimals;
        private System.Windows.Forms.ListBox lstInfo;
    }
}

