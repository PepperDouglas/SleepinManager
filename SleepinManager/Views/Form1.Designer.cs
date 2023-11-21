namespace SleepinManager
{
    partial class SManagerForm
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
            this.dateTimePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.labelChkIn = new System.Windows.Forms.Label();
            this.labelChkOut = new System.Windows.Forms.Label();
            this.comboBoxRoomTypes = new System.Windows.Forms.ComboBox();
            this.btnSearchRooms = new System.Windows.Forms.Button();
            this.listBoxRooms = new System.Windows.Forms.ListBox();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.checkBox1Bed = new System.Windows.Forms.CheckBox();
            this.checkBox2Bed = new System.Windows.Forms.CheckBox();
            this.labelXBeds = new System.Windows.Forms.Label();
            this.textBoxCustomerSearch = new System.Windows.Forms.TextBox();
            this.buttonSearchCustomer = new System.Windows.Forms.Button();
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonShowBooking = new System.Windows.Forms.Button();
            this.listBoxBookings = new System.Windows.Forms.ListBox();
            this.dateTimePickerBookStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBookEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonSearchBooking = new System.Windows.Forms.Button();
            this.buttonUpdateBooking = new System.Windows.Forms.Button();
            this.buttonRemoveBooking = new System.Windows.Forms.Button();
            this.buttonShowInvoice = new System.Windows.Forms.Button();
            this.buttonShowDetails = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonRemoveExpired = new System.Windows.Forms.Button();
            this.buttonAnnullExpired = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonCustomerControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePickerCheckIn
            // 
            this.dateTimePickerCheckIn.Location = new System.Drawing.Point(26, 38);
            this.dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            this.dateTimePickerCheckIn.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerCheckIn.TabIndex = 0;
            // 
            // dateTimePickerCheckOut
            // 
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(183, 38);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerCheckOut.TabIndex = 1;
            // 
            // labelChkIn
            // 
            this.labelChkIn.AutoSize = true;
            this.labelChkIn.Location = new System.Drawing.Point(23, 22);
            this.labelChkIn.Name = "labelChkIn";
            this.labelChkIn.Size = new System.Drawing.Size(50, 13);
            this.labelChkIn.TabIndex = 2;
            this.labelChkIn.Text = "Check In";
            // 
            // labelChkOut
            // 
            this.labelChkOut.AutoSize = true;
            this.labelChkOut.Location = new System.Drawing.Point(180, 22);
            this.labelChkOut.Name = "labelChkOut";
            this.labelChkOut.Size = new System.Drawing.Size(58, 13);
            this.labelChkOut.TabIndex = 3;
            this.labelChkOut.Text = "Check Out";
            // 
            // comboBoxRoomTypes
            // 
            this.comboBoxRoomTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRoomTypes.FormattingEnabled = true;
            this.comboBoxRoomTypes.Items.AddRange(new object[] {
            "All Rooms",
            "Single Rooms",
            "Double Rooms"});
            this.comboBoxRoomTypes.Location = new System.Drawing.Point(213, 65);
            this.comboBoxRoomTypes.Name = "comboBoxRoomTypes";
            this.comboBoxRoomTypes.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRoomTypes.TabIndex = 4;
            // 
            // btnSearchRooms
            // 
            this.btnSearchRooms.Location = new System.Drawing.Point(238, 92);
            this.btnSearchRooms.Name = "btnSearchRooms";
            this.btnSearchRooms.Size = new System.Drawing.Size(96, 23);
            this.btnSearchRooms.TabIndex = 5;
            this.btnSearchRooms.Text = "Search Rooms";
            this.btnSearchRooms.UseVisualStyleBackColor = true;
            this.btnSearchRooms.Click += new System.EventHandler(this.btnSearchRooms_Click);
            // 
            // listBoxRooms
            // 
            this.listBoxRooms.FormattingEnabled = true;
            this.listBoxRooms.Location = new System.Drawing.Point(26, 65);
            this.listBoxRooms.Name = "listBoxRooms";
            this.listBoxRooms.Size = new System.Drawing.Size(183, 173);
            this.listBoxRooms.TabIndex = 6;
            this.listBoxRooms.SelectedIndexChanged += new System.EventHandler(this.listBoxRooms_SelectedIndexChanged);
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.Location = new System.Drawing.Point(238, 215);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(96, 23);
            this.btnBookRoom.TabIndex = 7;
            this.btnBookRoom.Text = "Book Room";
            this.btnBookRoom.UseVisualStyleBackColor = true;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // checkBox1Bed
            // 
            this.checkBox1Bed.AutoSize = true;
            this.checkBox1Bed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1Bed.Location = new System.Drawing.Point(241, 151);
            this.checkBox1Bed.Name = "checkBox1Bed";
            this.checkBox1Bed.Size = new System.Drawing.Size(93, 17);
            this.checkBox1Bed.TabIndex = 8;
            this.checkBox1Bed.Text = "One extra bed";
            this.checkBox1Bed.UseVisualStyleBackColor = true;
            this.checkBox1Bed.CheckedChanged += new System.EventHandler(this.checkBox1Bed_CheckedChanged);
            // 
            // checkBox2Bed
            // 
            this.checkBox2Bed.AutoSize = true;
            this.checkBox2Bed.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2Bed.Location = new System.Drawing.Point(235, 174);
            this.checkBox2Bed.Name = "checkBox2Bed";
            this.checkBox2Bed.Size = new System.Drawing.Size(99, 17);
            this.checkBox2Bed.TabIndex = 9;
            this.checkBox2Bed.Text = "Two extra beds";
            this.checkBox2Bed.UseVisualStyleBackColor = true;
            this.checkBox2Bed.CheckedChanged += new System.EventHandler(this.checkBox2Bed_CheckedChanged);
            // 
            // labelXBeds
            // 
            this.labelXBeds.AutoSize = true;
            this.labelXBeds.Location = new System.Drawing.Point(235, 135);
            this.labelXBeds.Name = "labelXBeds";
            this.labelXBeds.Size = new System.Drawing.Size(58, 13);
            this.labelXBeds.TabIndex = 10;
            this.labelXBeds.Text = "Extra Beds";
            // 
            // textBoxCustomerSearch
            // 
            this.textBoxCustomerSearch.Location = new System.Drawing.Point(370, 38);
            this.textBoxCustomerSearch.Name = "textBoxCustomerSearch";
            this.textBoxCustomerSearch.Size = new System.Drawing.Size(206, 20);
            this.textBoxCustomerSearch.TabIndex = 11;
            // 
            // buttonSearchCustomer
            // 
            this.buttonSearchCustomer.Location = new System.Drawing.Point(370, 63);
            this.buttonSearchCustomer.Name = "buttonSearchCustomer";
            this.buttonSearchCustomer.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchCustomer.TabIndex = 17;
            this.buttonSearchCustomer.Text = "Search";
            this.buttonSearchCustomer.UseVisualStyleBackColor = true;
            this.buttonSearchCustomer.Click += new System.EventHandler(this.buttonSearchCustomer_Click);
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.Location = new System.Drawing.Point(370, 92);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(206, 108);
            this.listBoxCustomers.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(367, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Search for customer name or ID number";
            // 
            // buttonShowBooking
            // 
            this.buttonShowBooking.Location = new System.Drawing.Point(370, 215);
            this.buttonShowBooking.Name = "buttonShowBooking";
            this.buttonShowBooking.Size = new System.Drawing.Size(90, 23);
            this.buttonShowBooking.TabIndex = 31;
            this.buttonShowBooking.Text = "Show Booking";
            this.buttonShowBooking.UseVisualStyleBackColor = true;
            this.buttonShowBooking.Click += new System.EventHandler(this.buttonShowBooking_Click);
            // 
            // listBoxBookings
            // 
            this.listBoxBookings.FormattingEnabled = true;
            this.listBoxBookings.Location = new System.Drawing.Point(26, 304);
            this.listBoxBookings.Name = "listBoxBookings";
            this.listBoxBookings.Size = new System.Drawing.Size(206, 121);
            this.listBoxBookings.TabIndex = 32;
            // 
            // dateTimePickerBookStart
            // 
            this.dateTimePickerBookStart.Location = new System.Drawing.Point(242, 304);
            this.dateTimePickerBookStart.Name = "dateTimePickerBookStart";
            this.dateTimePickerBookStart.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerBookStart.TabIndex = 33;
            // 
            // dateTimePickerBookEnd
            // 
            this.dateTimePickerBookEnd.Location = new System.Drawing.Point(242, 330);
            this.dateTimePickerBookEnd.Name = "dateTimePickerBookEnd";
            this.dateTimePickerBookEnd.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerBookEnd.TabIndex = 34;
            // 
            // buttonSearchBooking
            // 
            this.buttonSearchBooking.Location = new System.Drawing.Point(240, 373);
            this.buttonSearchBooking.Name = "buttonSearchBooking";
            this.buttonSearchBooking.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchBooking.TabIndex = 36;
            this.buttonSearchBooking.Text = "Search";
            this.buttonSearchBooking.UseVisualStyleBackColor = true;
            this.buttonSearchBooking.Click += new System.EventHandler(this.buttonSearchBooking_Click);
            // 
            // buttonUpdateBooking
            // 
            this.buttonUpdateBooking.Location = new System.Drawing.Point(321, 373);
            this.buttonUpdateBooking.Name = "buttonUpdateBooking";
            this.buttonUpdateBooking.Size = new System.Drawing.Size(72, 23);
            this.buttonUpdateBooking.TabIndex = 37;
            this.buttonUpdateBooking.Text = "Update";
            this.buttonUpdateBooking.UseVisualStyleBackColor = true;
            this.buttonUpdateBooking.Click += new System.EventHandler(this.buttonUpdateBooking_Click);
            // 
            // buttonRemoveBooking
            // 
            this.buttonRemoveBooking.Location = new System.Drawing.Point(320, 402);
            this.buttonRemoveBooking.Name = "buttonRemoveBooking";
            this.buttonRemoveBooking.Size = new System.Drawing.Size(73, 23);
            this.buttonRemoveBooking.TabIndex = 38;
            this.buttonRemoveBooking.Text = "Remove";
            this.buttonRemoveBooking.UseVisualStyleBackColor = true;
            this.buttonRemoveBooking.Click += new System.EventHandler(this.buttonRemoveBooking_Click);
            // 
            // buttonShowInvoice
            // 
            this.buttonShowInvoice.Location = new System.Drawing.Point(122, 440);
            this.buttonShowInvoice.Name = "buttonShowInvoice";
            this.buttonShowInvoice.Size = new System.Drawing.Size(88, 23);
            this.buttonShowInvoice.TabIndex = 41;
            this.buttonShowInvoice.Text = "Show Invoice";
            this.buttonShowInvoice.UseVisualStyleBackColor = true;
            this.buttonShowInvoice.Click += new System.EventHandler(this.buttonShowInvoice_Click);
            // 
            // buttonShowDetails
            // 
            this.buttonShowDetails.Location = new System.Drawing.Point(26, 440);
            this.buttonShowDetails.Name = "buttonShowDetails";
            this.buttonShowDetails.Size = new System.Drawing.Size(90, 23);
            this.buttonShowDetails.TabIndex = 42;
            this.buttonShowDetails.Text = "Show Details";
            this.buttonShowDetails.UseVisualStyleBackColor = true;
            this.buttonShowDetails.Click += new System.EventHandler(this.buttonShowDetails_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "Bookings";
            // 
            // buttonRemoveExpired
            // 
            this.buttonRemoveExpired.Location = new System.Drawing.Point(501, 440);
            this.buttonRemoveExpired.Name = "buttonRemoveExpired";
            this.buttonRemoveExpired.Size = new System.Drawing.Size(75, 23);
            this.buttonRemoveExpired.TabIndex = 44;
            this.buttonRemoveExpired.Text = "Remove";
            this.buttonRemoveExpired.UseVisualStyleBackColor = true;
            this.buttonRemoveExpired.Click += new System.EventHandler(this.buttonRemoveExpired_Click);
            // 
            // buttonAnnullExpired
            // 
            this.buttonAnnullExpired.Location = new System.Drawing.Point(501, 393);
            this.buttonAnnullExpired.Name = "buttonAnnullExpired";
            this.buttonAnnullExpired.Size = new System.Drawing.Size(75, 23);
            this.buttonAnnullExpired.TabIndex = 45;
            this.buttonAnnullExpired.Text = "Annull";
            this.buttonAnnullExpired.UseVisualStyleBackColor = true;
            this.buttonAnnullExpired.Click += new System.EventHandler(this.buttonAnnullExpired_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(440, 424);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Remove annulled bookings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(461, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Annull expired invoices";
            // 
            // buttonCustomerControl
            // 
            this.buttonCustomerControl.Location = new System.Drawing.Point(466, 215);
            this.buttonCustomerControl.Name = "buttonCustomerControl";
            this.buttonCustomerControl.Size = new System.Drawing.Size(110, 23);
            this.buttonCustomerControl.TabIndex = 48;
            this.buttonCustomerControl.Text = "Customer Controls";
            this.buttonCustomerControl.UseVisualStyleBackColor = true;
            this.buttonCustomerControl.Click += new System.EventHandler(this.buttonCustomerControl_Click);
            // 
            // SManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 488);
            this.Controls.Add(this.buttonCustomerControl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonAnnullExpired);
            this.Controls.Add(this.buttonRemoveExpired);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonShowDetails);
            this.Controls.Add(this.buttonShowInvoice);
            this.Controls.Add(this.buttonRemoveBooking);
            this.Controls.Add(this.buttonUpdateBooking);
            this.Controls.Add(this.buttonSearchBooking);
            this.Controls.Add(this.dateTimePickerBookEnd);
            this.Controls.Add(this.dateTimePickerBookStart);
            this.Controls.Add(this.listBoxBookings);
            this.Controls.Add(this.buttonShowBooking);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxCustomers);
            this.Controls.Add(this.buttonSearchCustomer);
            this.Controls.Add(this.textBoxCustomerSearch);
            this.Controls.Add(this.labelXBeds);
            this.Controls.Add(this.checkBox2Bed);
            this.Controls.Add(this.checkBox1Bed);
            this.Controls.Add(this.btnBookRoom);
            this.Controls.Add(this.listBoxRooms);
            this.Controls.Add(this.btnSearchRooms);
            this.Controls.Add(this.comboBoxRoomTypes);
            this.Controls.Add(this.labelChkOut);
            this.Controls.Add(this.labelChkIn);
            this.Controls.Add(this.dateTimePickerCheckOut);
            this.Controls.Add(this.dateTimePickerCheckIn);
            this.Name = "SManagerForm";
            this.Text = "Sleepin Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerCheckIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.Label labelChkIn;
        private System.Windows.Forms.Label labelChkOut;
        private System.Windows.Forms.ComboBox comboBoxRoomTypes;
        private System.Windows.Forms.Button btnSearchRooms;
        private System.Windows.Forms.ListBox listBoxRooms;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.CheckBox checkBox1Bed;
        private System.Windows.Forms.CheckBox checkBox2Bed;
        private System.Windows.Forms.Label labelXBeds;
        private System.Windows.Forms.TextBox textBoxCustomerSearch;
        private System.Windows.Forms.Button buttonSearchCustomer;
        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonShowBooking;
        private System.Windows.Forms.ListBox listBoxBookings;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookEnd;
        private System.Windows.Forms.Button buttonSearchBooking;
        private System.Windows.Forms.Button buttonUpdateBooking;
        private System.Windows.Forms.Button buttonRemoveBooking;
        private System.Windows.Forms.Button buttonShowInvoice;
        private System.Windows.Forms.Button buttonShowDetails;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonRemoveExpired;
        private System.Windows.Forms.Button buttonAnnullExpired;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonCustomerControl;
    }
}

