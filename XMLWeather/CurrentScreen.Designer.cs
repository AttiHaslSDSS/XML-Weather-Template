namespace XMLWeather
{
    partial class CurrentScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maxOutput = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.minOutput = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.currentOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.forecastLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rain = new System.Windows.Forms.Label();
            this.feelsLabel = new System.Windows.Forms.Label();
            this.Shmungus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.wSpeed = new System.Windows.Forms.Label();
            this.wind = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maxOutput
            // 
            this.maxOutput.BackColor = System.Drawing.Color.White;
            this.maxOutput.Location = new System.Drawing.Point(64, 136);
            this.maxOutput.Name = "maxOutput";
            this.maxOutput.Size = new System.Drawing.Size(113, 13);
            this.maxOutput.TabIndex = 32;
            this.maxOutput.Text = "Maximum Temperature:";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.ForeColor = System.Drawing.Color.White;
            this.maxLabel.Location = new System.Drawing.Point(12, 136);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(26, 13);
            this.maxLabel.TabIndex = 31;
            this.maxLabel.Text = "max";
            // 
            // minOutput
            // 
            this.minOutput.BackColor = System.Drawing.Color.White;
            this.minOutput.Location = new System.Drawing.Point(64, 159);
            this.minOutput.Name = "minOutput";
            this.minOutput.Size = new System.Drawing.Size(113, 13);
            this.minOutput.TabIndex = 30;
            this.minOutput.Text = "Minimum Temperature:";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.ForeColor = System.Drawing.Color.White;
            this.minLabel.Location = new System.Drawing.Point(12, 159);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(23, 13);
            this.minLabel.TabIndex = 29;
            this.minLabel.Text = "min";
            // 
            // currentOutput
            // 
            this.currentOutput.BackColor = System.Drawing.Color.Transparent;
            this.currentOutput.ForeColor = System.Drawing.Color.White;
            this.currentOutput.Location = new System.Drawing.Point(131, 136);
            this.currentOutput.Name = "currentOutput";
            this.currentOutput.Size = new System.Drawing.Size(22, 13);
            this.currentOutput.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 40;
            this.label3.Text = "Today";
            // 
            // forecastLabel
            // 
            this.forecastLabel.BackColor = System.Drawing.Color.Transparent;
            this.forecastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastLabel.ForeColor = System.Drawing.Color.White;
            this.forecastLabel.Location = new System.Drawing.Point(141, 14);
            this.forecastLabel.Name = "forecastLabel";
            this.forecastLabel.Size = new System.Drawing.Size(83, 28);
            this.forecastLabel.TabIndex = 41;
            this.forecastLabel.Text = "3 Day";
            this.forecastLabel.Click += new System.EventHandler(this.forecastLabel_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 27);
            this.label5.TabIndex = 42;
            this.label5.Text = "____________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Weather:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // rain
            // 
            this.rain.AutoSize = true;
            this.rain.ForeColor = System.Drawing.Color.White;
            this.rain.Location = new System.Drawing.Point(12, 206);
            this.rain.Name = "rain";
            this.rain.Size = new System.Drawing.Size(43, 13);
            this.rain.TabIndex = 45;
            this.rain.Text = "Rain %:";
            // 
            // feelsLabel
            // 
            this.feelsLabel.BackColor = System.Drawing.Color.White;
            this.feelsLabel.Location = new System.Drawing.Point(64, 181);
            this.feelsLabel.Name = "feelsLabel";
            this.feelsLabel.Size = new System.Drawing.Size(113, 13);
            this.feelsLabel.TabIndex = 46;
            this.feelsLabel.Text = "Weather:";
            this.feelsLabel.Click += new System.EventHandler(this.feelsLabel_Click);
            // 
            // Shmungus
            // 
            this.Shmungus.BackColor = System.Drawing.Color.White;
            this.Shmungus.Location = new System.Drawing.Point(64, 206);
            this.Shmungus.Name = "Shmungus";
            this.Shmungus.Size = new System.Drawing.Size(113, 13);
            this.Shmungus.TabIndex = 48;
            this.Shmungus.Click += new System.EventHandler(this.cityValue_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 52;
            // 
            // wSpeed
            // 
            this.wSpeed.BackColor = System.Drawing.Color.White;
            this.wSpeed.Location = new System.Drawing.Point(64, 256);
            this.wSpeed.Name = "wSpeed";
            this.wSpeed.Size = new System.Drawing.Size(113, 13);
            this.wSpeed.TabIndex = 53;
            // 
            // wind
            // 
            this.wind.AutoSize = true;
            this.wind.ForeColor = System.Drawing.Color.White;
            this.wind.Location = new System.Drawing.Point(12, 256);
            this.wind.Name = "wind";
            this.wind.Size = new System.Drawing.Size(35, 13);
            this.wind.TabIndex = 54;
            this.wind.Text = "Wind:";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(67, 227);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(110, 20);
            this.cityBox.TabIndex = 55;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(94, 287);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(59, 23);
            this.updateButton.TabIndex = 56;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // CurrentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.wind);
            this.Controls.Add(this.wSpeed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Shmungus);
            this.Controls.Add(this.feelsLabel);
            this.Controls.Add(this.rain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forecastLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maxOutput);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.minOutput);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.currentOutput);
            this.Controls.Add(this.label5);
            this.Name = "CurrentScreen";
            this.Size = new System.Drawing.Size(250, 400);
            this.Load += new System.EventHandler(this.CurrentScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label maxOutput;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label minOutput;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label currentOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label forecastLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label rain;
        private System.Windows.Forms.Label feelsLabel;
        private System.Windows.Forms.Label Shmungus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label wSpeed;
        private System.Windows.Forms.Label wind;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Button updateButton;
    }
}
