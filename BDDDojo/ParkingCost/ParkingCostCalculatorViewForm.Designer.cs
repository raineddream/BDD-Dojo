namespace Rain.BDDDojo.ParkingCost
{
    partial class ParkingCostCalculatorViewForm
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
            this.lblParkingLotType = new System.Windows.Forms.Label();
            this.cbParkingLot = new System.Windows.Forms.ComboBox();
            this.lblEntryDateTime = new System.Windows.Forms.Label();
            this.lblLeavingDateTime = new System.Windows.Forms.Label();
            this.dtEntryDate = new System.Windows.Forms.DateTimePicker();
            this.txtEntryTime = new System.Windows.Forms.TextBox();
            this.rbEntryAM = new System.Windows.Forms.RadioButton();
            this.rbEntryPM = new System.Windows.Forms.RadioButton();
            this.rbLeavingPM = new System.Windows.Forms.RadioButton();
            this.rbLeavingAM = new System.Windows.Forms.RadioButton();
            this.txtLeavingTime = new System.Windows.Forms.TextBox();
            this.dtLeavingDate = new System.Windows.Forms.DateTimePicker();
            this.grpParkingInfo = new System.Windows.Forms.GroupBox();
            this.btnCalculateCharge = new System.Windows.Forms.Button();
            this.chkBestCharge = new System.Windows.Forms.CheckBox();
            this.grpParkingInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblParkingLotType
            // 
            this.lblParkingLotType.AutoSize = true;
            this.lblParkingLotType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParkingLotType.Location = new System.Drawing.Point(6, 28);
            this.lblParkingLotType.Name = "lblParkingLotType";
            this.lblParkingLotType.Size = new System.Drawing.Size(119, 15);
            this.lblParkingLotType.TabIndex = 0;
            this.lblParkingLotType.Text = "Choose a parking lot";
            // 
            // cbParkingLot
            // 
            this.cbParkingLot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbParkingLot.FormattingEnabled = true;
            this.cbParkingLot.Items.AddRange(new object[] {
            "Please choose a parking lot",
            "Valet Parking",
            "Short-Term Parking",
            "Long-Term Parking"});
            this.cbParkingLot.Location = new System.Drawing.Point(206, 22);
            this.cbParkingLot.Name = "cbParkingLot";
            this.cbParkingLot.Size = new System.Drawing.Size(220, 23);
            this.cbParkingLot.TabIndex = 1;
            // 
            // lblEntryDateTime
            // 
            this.lblEntryDateTime.AutoSize = true;
            this.lblEntryDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryDateTime.Location = new System.Drawing.Point(6, 61);
            this.lblEntryDateTime.Name = "lblEntryDateTime";
            this.lblEntryDateTime.Size = new System.Drawing.Size(182, 15);
            this.lblEntryDateTime.TabIndex = 2;
            this.lblEntryDateTime.Text = "Please input entry date and time";
            // 
            // lblLeavingDateTime
            // 
            this.lblLeavingDateTime.AutoSize = true;
            this.lblLeavingDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeavingDateTime.Location = new System.Drawing.Point(6, 95);
            this.lblLeavingDateTime.Name = "lblLeavingDateTime";
            this.lblLeavingDateTime.Size = new System.Drawing.Size(195, 15);
            this.lblLeavingDateTime.TabIndex = 3;
            this.lblLeavingDateTime.Text = "Please input leaving date and time";
            // 
            // dtEntryDate
            // 
            this.dtEntryDate.Location = new System.Drawing.Point(206, 61);
            this.dtEntryDate.Name = "dtEntryDate";
            this.dtEntryDate.Size = new System.Drawing.Size(200, 21);
            this.dtEntryDate.TabIndex = 4;
            // 
            // txtEntryTime
            // 
            this.txtEntryTime.Location = new System.Drawing.Point(413, 61);
            this.txtEntryTime.Name = "txtEntryTime";
            this.txtEntryTime.Size = new System.Drawing.Size(52, 21);
            this.txtEntryTime.TabIndex = 5;
            this.txtEntryTime.Text = "12:00";
            // 
            // rbEntryAM
            // 
            this.rbEntryAM.AutoSize = true;
            this.rbEntryAM.Location = new System.Drawing.Point(472, 63);
            this.rbEntryAM.Name = "rbEntryAM";
            this.rbEntryAM.Size = new System.Drawing.Size(43, 19);
            this.rbEntryAM.TabIndex = 6;
            this.rbEntryAM.TabStop = true;
            this.rbEntryAM.Text = "AM";
            this.rbEntryAM.UseVisualStyleBackColor = true;
            // 
            // rbEntryPM
            // 
            this.rbEntryPM.AutoSize = true;
            this.rbEntryPM.Location = new System.Drawing.Point(519, 63);
            this.rbEntryPM.Name = "rbEntryPM";
            this.rbEntryPM.Size = new System.Drawing.Size(44, 19);
            this.rbEntryPM.TabIndex = 7;
            this.rbEntryPM.TabStop = true;
            this.rbEntryPM.Text = "PM";
            this.rbEntryPM.UseVisualStyleBackColor = true;
            // 
            // rbLeavingPM
            // 
            this.rbLeavingPM.AutoSize = true;
            this.rbLeavingPM.Location = new System.Drawing.Point(520, 97);
            this.rbLeavingPM.Name = "rbLeavingPM";
            this.rbLeavingPM.Size = new System.Drawing.Size(44, 19);
            this.rbLeavingPM.TabIndex = 11;
            this.rbLeavingPM.TabStop = true;
            this.rbLeavingPM.Text = "PM";
            this.rbLeavingPM.UseVisualStyleBackColor = true;
            // 
            // rbLeavingAM
            // 
            this.rbLeavingAM.AutoSize = true;
            this.rbLeavingAM.Location = new System.Drawing.Point(473, 97);
            this.rbLeavingAM.Name = "rbLeavingAM";
            this.rbLeavingAM.Size = new System.Drawing.Size(43, 19);
            this.rbLeavingAM.TabIndex = 10;
            this.rbLeavingAM.TabStop = true;
            this.rbLeavingAM.Text = "AM";
            this.rbLeavingAM.UseVisualStyleBackColor = true;
            // 
            // txtLeavingTime
            // 
            this.txtLeavingTime.Location = new System.Drawing.Point(414, 95);
            this.txtLeavingTime.Name = "txtLeavingTime";
            this.txtLeavingTime.Size = new System.Drawing.Size(52, 21);
            this.txtLeavingTime.TabIndex = 9;
            this.txtLeavingTime.Text = "12:00";
            // 
            // dtLeavingDate
            // 
            this.dtLeavingDate.Location = new System.Drawing.Point(207, 95);
            this.dtLeavingDate.Name = "dtLeavingDate";
            this.dtLeavingDate.Size = new System.Drawing.Size(200, 21);
            this.dtLeavingDate.TabIndex = 8;
            // 
            // grpParkingInfo
            // 
            this.grpParkingInfo.Controls.Add(this.lblParkingLotType);
            this.grpParkingInfo.Controls.Add(this.rbLeavingPM);
            this.grpParkingInfo.Controls.Add(this.cbParkingLot);
            this.grpParkingInfo.Controls.Add(this.rbLeavingAM);
            this.grpParkingInfo.Controls.Add(this.lblEntryDateTime);
            this.grpParkingInfo.Controls.Add(this.txtLeavingTime);
            this.grpParkingInfo.Controls.Add(this.lblLeavingDateTime);
            this.grpParkingInfo.Controls.Add(this.dtLeavingDate);
            this.grpParkingInfo.Controls.Add(this.dtEntryDate);
            this.grpParkingInfo.Controls.Add(this.rbEntryPM);
            this.grpParkingInfo.Controls.Add(this.txtEntryTime);
            this.grpParkingInfo.Controls.Add(this.rbEntryAM);
            this.grpParkingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpParkingInfo.Location = new System.Drawing.Point(12, 12);
            this.grpParkingInfo.Name = "grpParkingInfo";
            this.grpParkingInfo.Size = new System.Drawing.Size(567, 128);
            this.grpParkingInfo.TabIndex = 12;
            this.grpParkingInfo.TabStop = false;
            this.grpParkingInfo.Text = "Parking Info";
            // 
            // btnCalculateCharge
            // 
            this.btnCalculateCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculateCharge.Location = new System.Drawing.Point(484, 146);
            this.btnCalculateCharge.Name = "btnCalculateCharge";
            this.btnCalculateCharge.Size = new System.Drawing.Size(91, 23);
            this.btnCalculateCharge.TabIndex = 13;
            this.btnCalculateCharge.Text = "Calculate";
            this.btnCalculateCharge.UseVisualStyleBackColor = true;
            this.btnCalculateCharge.Click += new System.EventHandler(this.btnCalculateCharge_Click);
            // 
            // chkBestCharge
            // 
            this.chkBestCharge.AutoSize = true;
            this.chkBestCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBestCharge.Location = new System.Drawing.Point(21, 146);
            this.chkBestCharge.Name = "chkBestCharge";
            this.chkBestCharge.Size = new System.Drawing.Size(93, 19);
            this.chkBestCharge.TabIndex = 14;
            this.chkBestCharge.Text = "Best Charge";
            this.chkBestCharge.UseVisualStyleBackColor = true;
            // 
            // ParkingCostCalculatorViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 181);
            this.Controls.Add(this.chkBestCharge);
            this.Controls.Add(this.btnCalculateCharge);
            this.Controls.Add(this.grpParkingInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ParkingCostCalculatorViewForm";
            this.Text = "Parking Cost Calculator";
            this.Load += new System.EventHandler(this.ParkingCostCalculator_Load);
            this.grpParkingInfo.ResumeLayout(false);
            this.grpParkingInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParkingLotType;
        private System.Windows.Forms.ComboBox cbParkingLot;
        private System.Windows.Forms.Label lblEntryDateTime;
        private System.Windows.Forms.Label lblLeavingDateTime;
        private System.Windows.Forms.DateTimePicker dtEntryDate;
        private System.Windows.Forms.TextBox txtEntryTime;
        private System.Windows.Forms.RadioButton rbEntryAM;
        private System.Windows.Forms.RadioButton rbEntryPM;
        private System.Windows.Forms.RadioButton rbLeavingPM;
        private System.Windows.Forms.RadioButton rbLeavingAM;
        private System.Windows.Forms.TextBox txtLeavingTime;
        private System.Windows.Forms.DateTimePicker dtLeavingDate;
        private System.Windows.Forms.GroupBox grpParkingInfo;
        private System.Windows.Forms.Button btnCalculateCharge;
        private System.Windows.Forms.CheckBox chkBestCharge;

    }
}

