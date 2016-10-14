namespace Collections
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
            this.btnQueue = new System.Windows.Forms.Button();
            this.btnStack = new System.Windows.Forms.Button();
            this.btnGeneralPur = new System.Windows.Forms.Button();
            this.btnSorted = new System.Windows.Forms.Button();
            this.lblPlanets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQueue
            // 
            this.btnQueue.Location = new System.Drawing.Point(31, 107);
            this.btnQueue.Name = "btnQueue";
            this.btnQueue.Size = new System.Drawing.Size(96, 23);
            this.btnQueue.TabIndex = 0;
            this.btnQueue.Text = "Queue";
            this.btnQueue.UseVisualStyleBackColor = true;
            this.btnQueue.Click += new System.EventHandler(this.btnQueue_Click);
            // 
            // btnStack
            // 
            this.btnStack.Location = new System.Drawing.Point(31, 161);
            this.btnStack.Name = "btnStack";
            this.btnStack.Size = new System.Drawing.Size(96, 23);
            this.btnStack.TabIndex = 1;
            this.btnStack.Text = "Stack";
            this.btnStack.UseVisualStyleBackColor = true;
            this.btnStack.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // btnGeneralPur
            // 
            this.btnGeneralPur.Location = new System.Drawing.Point(31, 215);
            this.btnGeneralPur.Name = "btnGeneralPur";
            this.btnGeneralPur.Size = new System.Drawing.Size(96, 23);
            this.btnGeneralPur.TabIndex = 2;
            this.btnGeneralPur.Text = "General Purpose List";
            this.btnGeneralPur.UseVisualStyleBackColor = true;
            this.btnGeneralPur.Click += new System.EventHandler(this.btnGeneralPur_Click);
            // 
            // btnSorted
            // 
            this.btnSorted.Location = new System.Drawing.Point(31, 269);
            this.btnSorted.Name = "btnSorted";
            this.btnSorted.Size = new System.Drawing.Size(96, 23);
            this.btnSorted.TabIndex = 3;
            this.btnSorted.Text = "Sorted List";
            this.btnSorted.UseVisualStyleBackColor = true;
            this.btnSorted.Click += new System.EventHandler(this.btnSorted_Click);
            // 
            // lblPlanets
            // 
            this.lblPlanets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPlanets.Location = new System.Drawing.Point(191, 21);
            this.lblPlanets.Name = "lblPlanets";
            this.lblPlanets.Size = new System.Drawing.Size(251, 358);
            this.lblPlanets.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 408);
            this.Controls.Add(this.lblPlanets);
            this.Controls.Add(this.btnSorted);
            this.Controls.Add(this.btnGeneralPur);
            this.Controls.Add(this.btnStack);
            this.Controls.Add(this.btnQueue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnQueue;
        private System.Windows.Forms.Button btnStack;
        private System.Windows.Forms.Button btnGeneralPur;
        private System.Windows.Forms.Button btnSorted;
        private System.Windows.Forms.Label lblPlanets;
    }
}

