namespace WeatherReporter
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
            this.cboColour = new System.Windows.Forms.ComboBox();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.btnPredict = new System.Windows.Forms.Button();
            this.lblWeather = new System.Windows.Forms.Label();
            this.btnPredicSWITCH = new System.Windows.Forms.Button();
            this.tmrBlue = new System.Windows.Forms.Timer(this.components);
            this.tmrRed = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cboColour
            // 
            this.cboColour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboColour.FormattingEnabled = true;
            this.cboColour.Items.AddRange(new object[] {
            "[Select a colour...]",
            "Blue",
            "Red"});
            this.cboColour.Location = new System.Drawing.Point(78, 26);
            this.cboColour.Name = "cboColour";
            this.cboColour.Size = new System.Drawing.Size(121, 21);
            this.cboColour.TabIndex = 0;
            // 
            // cboMode
            // 
            this.cboMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Items.AddRange(new object[] {
            "[Select a mode...]",
            "Steady",
            "Flashing"});
            this.cboMode.Location = new System.Drawing.Point(78, 70);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(121, 21);
            this.cboMode.TabIndex = 1;
            // 
            // btnPredict
            // 
            this.btnPredict.Location = new System.Drawing.Point(3, 112);
            this.btnPredict.Name = "btnPredict";
            this.btnPredict.Size = new System.Drawing.Size(113, 23);
            this.btnPredict.TabIndex = 2;
            this.btnPredict.Text = "Predict Weather (IF)";
            this.btnPredict.UseVisualStyleBackColor = true;
            this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
            // 
            // lblWeather
            // 
            this.lblWeather.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeather.Location = new System.Drawing.Point(12, 165);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(260, 76);
            this.lblWeather.TabIndex = 3;
            this.lblWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPredicSWITCH
            // 
            this.btnPredicSWITCH.Location = new System.Drawing.Point(122, 112);
            this.btnPredicSWITCH.Name = "btnPredicSWITCH";
            this.btnPredicSWITCH.Size = new System.Drawing.Size(159, 23);
            this.btnPredicSWITCH.TabIndex = 4;
            this.btnPredicSWITCH.Text = "Predict Weather (SWITCH)";
            this.btnPredicSWITCH.UseVisualStyleBackColor = true;
            this.btnPredicSWITCH.Click += new System.EventHandler(this.btnPredicSWITCH_Click);
            // 
            // tmrBlue
            // 
            this.tmrBlue.Interval = 500;
            this.tmrBlue.Tick += new System.EventHandler(this.tmrBlue_Tick);
            // 
            // tmrRed
            // 
            this.tmrRed.Interval = 500;
            this.tmrRed.Tick += new System.EventHandler(this.tmrRed_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPredicSWITCH);
            this.Controls.Add(this.lblWeather);
            this.Controls.Add(this.btnPredict);
            this.Controls.Add(this.cboMode);
            this.Controls.Add(this.cboColour);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboColour;
        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Button btnPredict;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.Button btnPredicSWITCH;
        private System.Windows.Forms.Timer tmrBlue;
        private System.Windows.Forms.Timer tmrRed;

    }
}

