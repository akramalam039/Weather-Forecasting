namespace Wheather
{
    partial class ForeCastUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.labMainWeather = new System.Windows.Forms.Label();
            this.labWeatherDesc = new System.Windows.Forms.Label();
            this.picWeatherIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sunday";
            // 
            // labMainWeather
            // 
            this.labMainWeather.AutoSize = true;
            this.labMainWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMainWeather.ForeColor = System.Drawing.Color.White;
            this.labMainWeather.Location = new System.Drawing.Point(90, 24);
            this.labMainWeather.Name = "labMainWeather";
            this.labMainWeather.Size = new System.Drawing.Size(45, 16);
            this.labMainWeather.TabIndex = 1;
            this.labMainWeather.Text = "Clear";
            // 
            // labWeatherDesc
            // 
            this.labWeatherDesc.AutoSize = true;
            this.labWeatherDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWeatherDesc.ForeColor = System.Drawing.Color.White;
            this.labWeatherDesc.Location = new System.Drawing.Point(90, 43);
            this.labWeatherDesc.Name = "labWeatherDesc";
            this.labWeatherDesc.Size = new System.Drawing.Size(87, 16);
            this.labWeatherDesc.TabIndex = 1;
            this.labWeatherDesc.Text = "Description";
            // 
            // picWeatherIcon
            // 
            this.picWeatherIcon.Location = new System.Drawing.Point(13, 3);
            this.picWeatherIcon.Name = "picWeatherIcon";
            this.picWeatherIcon.Size = new System.Drawing.Size(70, 63);
            this.picWeatherIcon.TabIndex = 0;
            this.picWeatherIcon.TabStop = false;
            // 
            // ForeCastUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.labWeatherDesc);
            this.Controls.Add(this.labMainWeather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picWeatherIcon);
            this.Name = "ForeCastUC";
            this.Size = new System.Drawing.Size(303, 71);
            ((System.ComponentModel.ISupportInitialize)(this.picWeatherIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox picWeatherIcon;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label labMainWeather;
        public System.Windows.Forms.Label labWeatherDesc;
    }
}
