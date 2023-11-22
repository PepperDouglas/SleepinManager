namespace SleepinManager.Views
{
    partial class CustomerBookingsForm
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
            this.labelRoomSize = new System.Windows.Forms.Label();
            this.labelExtraBeds = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPaid = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelRoomType = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelAnnulled = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.listBoxBookings = new System.Windows.Forms.ListBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRoomSize
            // 
            this.labelRoomSize.AutoSize = true;
            this.labelRoomSize.Location = new System.Drawing.Point(484, 167);
            this.labelRoomSize.Name = "labelRoomSize";
            this.labelRoomSize.Size = new System.Drawing.Size(56, 13);
            this.labelRoomSize.TabIndex = 21;
            this.labelRoomSize.Text = "Roomsize:";
            // 
            // labelExtraBeds
            // 
            this.labelExtraBeds.AutoSize = true;
            this.labelExtraBeds.Location = new System.Drawing.Point(484, 204);
            this.labelExtraBeds.Name = "labelExtraBeds";
            this.labelExtraBeds.Size = new System.Drawing.Size(60, 13);
            this.labelExtraBeds.TabIndex = 20;
            this.labelExtraBeds.Text = "Extra beds:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(484, 131);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "Email:";
            // 
            // labelPaid
            // 
            this.labelPaid.AutoSize = true;
            this.labelPaid.Location = new System.Drawing.Point(484, 95);
            this.labelPaid.Name = "labelPaid";
            this.labelPaid.Size = new System.Drawing.Size(78, 13);
            this.labelPaid.TabIndex = 18;
            this.labelPaid.Text = "Invoice Paid? :";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(484, 61);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(56, 13);
            this.labelEndDate.TabIndex = 17;
            this.labelEndDate.Text = "Checkout:";
            // 
            // labelRoomType
            // 
            this.labelRoomType.AutoSize = true;
            this.labelRoomType.Location = new System.Drawing.Point(320, 204);
            this.labelRoomType.Name = "labelRoomType";
            this.labelRoomType.Size = new System.Drawing.Size(61, 13);
            this.labelRoomType.TabIndex = 16;
            this.labelRoomType.Text = "Room type:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(320, 167);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(41, 13);
            this.labelPhone.TabIndex = 15;
            this.labelPhone.Text = "Phone:";
            // 
            // labelAnnulled
            // 
            this.labelAnnulled.AutoSize = true;
            this.labelAnnulled.Location = new System.Drawing.Point(320, 131);
            this.labelAnnulled.Name = "labelAnnulled";
            this.labelAnnulled.Size = new System.Drawing.Size(97, 13);
            this.labelAnnulled.TabIndex = 14;
            this.labelAnnulled.Text = "Invoice annulled? :";
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(320, 95);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(31, 13);
            this.labelCost.TabIndex = 13;
            this.labelCost.Text = "Cost:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(320, 61);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(49, 13);
            this.labelStartDate.TabIndex = 12;
            this.labelStartDate.Text = "Checkin:";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Location = new System.Drawing.Point(39, 28);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(112, 13);
            this.labelCustomerName.TabIndex = 11;
            this.labelCustomerName.Text = "No bookings available";
            // 
            // listBoxBookings
            // 
            this.listBoxBookings.FormattingEnabled = true;
            this.listBoxBookings.Location = new System.Drawing.Point(42, 58);
            this.listBoxBookings.Name = "listBoxBookings";
            this.listBoxBookings.Size = new System.Drawing.Size(230, 134);
            this.listBoxBookings.TabIndex = 22;
            this.listBoxBookings.SelectedIndexChanged += new System.EventHandler(this.ListIndexChanged);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(42, 237);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 23;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // CustomerBookingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 281);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.listBoxBookings);
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
            this.Name = "CustomerBookingsForm";
            this.Text = "CustomerBookingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRoomSize;
        private System.Windows.Forms.Label labelExtraBeds;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPaid;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelRoomType;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelAnnulled;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.ListBox listBoxBookings;
        private System.Windows.Forms.Button buttonClose;
    }
}