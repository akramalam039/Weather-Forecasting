namespace Wheather
{
    partial class Weather_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weather_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.TBcity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labsunsine = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labsunset = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labWindspeed = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.labCountry = new System.Windows.Forms.Label();
            this.lbtemp = new System.Windows.Forms.Label();
            this.NetStatbtn1 = new System.Windows.Forms.Button();
            this.NetStatbtn2 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.labCity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(94, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "City:";
            // 
            // TBcity
            // 
            this.TBcity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.TBcity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TBcity.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcity.Location = new System.Drawing.Point(179, 56);
            this.TBcity.Name = "TBcity";
            this.TBcity.Size = new System.Drawing.Size(318, 31);
            this.TBcity.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnSearch.Image = global::Wheather.Properties.Resources._4092559_search_magnifier_mobile_ui_zoom_icon1;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(536, 56);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(1);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Padding = new System.Windows.Forms.Padding(1);
            this.btnSearch.Size = new System.Drawing.Size(125, 41);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.BackColor = System.Drawing.Color.Transparent;
            this.labCondition.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labCondition.Location = new System.Drawing.Point(94, 254);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(101, 26);
            this.labCondition.TabIndex = 0;
            this.labCondition.Text = "Condition:";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.BackColor = System.Drawing.Color.Transparent;
            this.labDetails.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labDetails.Location = new System.Drawing.Point(94, 295);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(77, 26);
            this.labDetails.TabIndex = 0;
            this.labDetails.Text = "Details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(94, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sunrise:";
            // 
            // labsunsine
            // 
            this.labsunsine.AutoSize = true;
            this.labsunsine.BackColor = System.Drawing.Color.Transparent;
            this.labsunsine.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsunsine.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labsunsine.Location = new System.Drawing.Point(198, 336);
            this.labsunsine.Name = "labsunsine";
            this.labsunsine.Size = new System.Drawing.Size(53, 26);
            this.labsunsine.TabIndex = 0;
            this.labsunsine.Text = "N/A:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(94, 378);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Sunset:";
            // 
            // labsunset
            // 
            this.labsunset.AutoSize = true;
            this.labsunset.BackColor = System.Drawing.Color.Transparent;
            this.labsunset.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labsunset.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labsunset.Location = new System.Drawing.Point(198, 378);
            this.labsunset.Name = "labsunset";
            this.labsunset.Size = new System.Drawing.Size(53, 26);
            this.labsunset.TabIndex = 0;
            this.labsunset.Text = "N/A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(479, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wind Speed:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(479, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pressure:";
            // 
            // labWindspeed
            // 
            this.labWindspeed.AutoSize = true;
            this.labWindspeed.BackColor = System.Drawing.Color.Transparent;
            this.labWindspeed.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindspeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labWindspeed.Location = new System.Drawing.Point(608, 253);
            this.labWindspeed.Name = "labWindspeed";
            this.labWindspeed.Size = new System.Drawing.Size(53, 26);
            this.labWindspeed.TabIndex = 0;
            this.labWindspeed.Text = "N/A:";
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.BackColor = System.Drawing.Color.Transparent;
            this.labPressure.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labPressure.Location = new System.Drawing.Point(608, 295);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(53, 26);
            this.labPressure.TabIndex = 0;
            this.labPressure.Text = "N/A:";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(99, 140);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(141, 96);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(479, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Country:";
            // 
            // labCountry
            // 
            this.labCountry.AutoSize = true;
            this.labCountry.BackColor = System.Drawing.Color.Transparent;
            this.labCountry.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCountry.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labCountry.Location = new System.Drawing.Point(608, 336);
            this.labCountry.Name = "labCountry";
            this.labCountry.Size = new System.Drawing.Size(53, 26);
            this.labCountry.TabIndex = 0;
            this.labCountry.Text = "N/A:";
            // 
            // lbtemp
            // 
            this.lbtemp.BackColor = System.Drawing.Color.Transparent;
            this.lbtemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtemp.ForeColor = System.Drawing.SystemColors.Control;
            this.lbtemp.Location = new System.Drawing.Point(281, 146);
            this.lbtemp.Name = "lbtemp";
            this.lbtemp.Size = new System.Drawing.Size(321, 89);
            this.lbtemp.TabIndex = 4;
            this.lbtemp.Text = "°C";
            this.toolTip1.SetToolTip(this.lbtemp, "Tempreture in Celcius");
            // 
            // NetStatbtn1
            // 
            this.NetStatbtn1.BackColor = System.Drawing.Color.Transparent;
            this.NetStatbtn1.BackgroundImage = global::Wheather.Properties.Resources.download;
            this.NetStatbtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NetStatbtn1.FlatAppearance.BorderSize = 0;
            this.NetStatbtn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NetStatbtn1.Location = new System.Drawing.Point(820, 12);
            this.NetStatbtn1.Name = "NetStatbtn1";
            this.NetStatbtn1.Size = new System.Drawing.Size(53, 44);
            this.NetStatbtn1.TabIndex = 5;
            this.toolTip2.SetToolTip(this.NetStatbtn1, "Connected");
            this.NetStatbtn1.UseVisualStyleBackColor = false;
            this.NetStatbtn1.Visible = false;
            this.NetStatbtn1.Click += new System.EventHandler(this.NetStatbtn1_Click);
            // 
            // NetStatbtn2
            // 
            this.NetStatbtn2.BackColor = System.Drawing.Color.Transparent;
            this.NetStatbtn2.BackgroundImage = global::Wheather.Properties.Resources.download__1_;
            this.NetStatbtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.NetStatbtn2.FlatAppearance.BorderSize = 0;
            this.NetStatbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NetStatbtn2.Location = new System.Drawing.Point(761, 12);
            this.NetStatbtn2.Name = "NetStatbtn2";
            this.NetStatbtn2.Size = new System.Drawing.Size(53, 44);
            this.NetStatbtn2.TabIndex = 6;
            this.NetStatbtn2.UseVisualStyleBackColor = false;
            this.NetStatbtn2.Visible = false;
            this.NetStatbtn2.Click += new System.EventHandler(this.NetStatbtn2_Click);
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.BackColor = System.Drawing.Color.Transparent;
            this.FLP.Location = new System.Drawing.Point(93, 429);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(750, 108);
            this.FLP.TabIndex = 7;
            this.FLP.WrapContents = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(479, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 26);
            this.label7.TabIndex = 0;
            this.label7.Text = "City:";
            // 
            // labCity
            // 
            this.labCity.AutoSize = true;
            this.labCity.BackColor = System.Drawing.Color.Transparent;
            this.labCity.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCity.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labCity.Location = new System.Drawing.Point(608, 378);
            this.labCity.Name = "labCity";
            this.labCity.Size = new System.Drawing.Size(53, 26);
            this.labCity.TabIndex = 0;
            this.labCity.Text = "N/A:";
            // 
            // Weather_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Wheather.Properties.Resources._5_Best_Free_and_Paid_Weather_APIs_2019_e15875820235011;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(885, 549);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.NetStatbtn2);
            this.Controls.Add(this.NetStatbtn1);
            this.Controls.Add(this.lbtemp);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBcity);
            this.Controls.Add(this.labCity);
            this.Controls.Add(this.labCountry);
            this.Controls.Add(this.labPressure);
            this.Controls.Add(this.labWindspeed);
            this.Controls.Add(this.labsunset);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labsunsine);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labDetails);
            this.Controls.Add(this.labCondition);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Weather_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wheather";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBcity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labsunsine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labsunset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labWindspeed;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labCountry;
        private System.Windows.Forms.Label lbtemp;
        private System.Windows.Forms.Button NetStatbtn1;
        private System.Windows.Forms.Button NetStatbtn2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labCity;
    }
}

