namespace EventArguments
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
            this.txtKeyLogger = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKeyLogger
            // 
            this.txtKeyLogger.Location = new System.Drawing.Point(22, 83);
            this.txtKeyLogger.Name = "txtKeyLogger";
            this.txtKeyLogger.Size = new System.Drawing.Size(255, 20);
            this.txtKeyLogger.TabIndex = 0;
            this.txtKeyLogger.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKeyLogger_KeyDown);
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResults.Location = new System.Drawing.Point(62, 238);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(179, 23);
            this.lblResults.TabIndex = 1;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 350);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.txtKeyLogger);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKeyLogger;
        private System.Windows.Forms.Label lblResults;
    }
}

