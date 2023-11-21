namespace SleepinManager.Views
{
    partial class BookingDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelAnnulled = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelPaid = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelExtraBeds = new System.Windows.Forms.Label();
            this.labelRoomSize = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(50, 27);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(35, 13);
            this.labelCustomerName.TabIndex = 0;
            this.labelCustomerName.Text = "label1";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(50, 59);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(35, 13);
            this.labelStartDate.TabIndex = 1;
            this.labelStartDate.Text = "label2";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(50, 93);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(35, 13);
            this.labelCost.TabIndex = 2;
            this.labelCost.Text = "label3";
            // 
            // labelAnnulled
            // 
            this.labelAnnulled.AutoSize = true;
            this.labelAnnulled.Location = new System.Drawing.Point(50, 129);
            this.labelAnnulled.Name = "labelAnnulled";
            this.labelAnnulled.Size = new System.Drawing.Size(35, 13);
            this.labelAnnulled.TabIndex = 3;
            this.labelAnnulled.Text = "label4";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(50, 165);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(35, 13);
            this.labelPhone.TabIndex = 4;
            this.labelPhone.Text = "label5";
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Location = new System.Drawing.Point(50, 202);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(35, 13);
            this.labelRoomType.TabIndex = 5;
            this.labelRoomType.Text = "label6";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(214, 59);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(35, 13);
            this.labelEndDate.TabIndex = 6;
            this.labelEndDate.Text = "label7";
            // 
            // labelPaid
            // 
            this.labelPaid.AutoSize = true;
            this.labelPaid.Location = new System.Drawing.Point(214, 93);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(35, 13);
            this.labelPaid.TabIndex = 7;
            this.labelPaid.Text = "label8";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(214, 129);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "label9";
            // 
            // labelExtraBeds
            // 
            this.labelExtraBeds.AutoSize = true;
            this.labelExtraBeds.Location = new System.Drawing.Point(214, 202);
            this.labelExtraBeds.Name = "labelExtraBeds";
            this.labelExtraBeds.Size = new System.Drawing.Size(41, 13);
            this.labelExtraBeds.TabIndex = 9;
            this.labelExtraBeds.Text = "label10";
            // 
            // labelRoomSize
            // 
            this.labelRoomSize.AutoSize = true;
            this.labelRoomSize.Location = new System.Drawing.Point(214, 165);
            this.labelRoomSize.Name = "labelRoomSize";
            this.labelRoomSize.Size = new System.Drawing.Size(41, 13);
            this.labelRoomSize.TabIndex = 10;
            this.labelRoomSize.Text = "label11";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(180, 236);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 11;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // BookingDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 285);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelRoomSize);
            this.Controls.Add(this.labelExtraBeds);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelPaid);
            this.Controls.Add(this.labelEndDate);
            this.Controls.Add(this.labelRoomType);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelAnnulled);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.labelStartDate);
            this.Controls.Add(this.labelCustomerName);
            this.Name = "BookingDetailsForm";
            this.Text = "BookingDetailsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelAnnulled;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelPaid;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelExtraBeds;
        private System.Windows.Forms.Label labelRoomSize;
        private System.Windows.Forms.Button buttonClose;
    }
}