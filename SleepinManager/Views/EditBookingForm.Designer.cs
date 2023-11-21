namespace SleepinManager.Views
{
    partial class EditBookingForm
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
            this.listBoxUnAvBookings = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dateTimePickerCheckIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCheckOut = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxBookDouble = new System.Windows.Forms.CheckBox();
            this.checkBoxBookSingle = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBoxUnAvBookings
            // 
            this.listBoxUnAvBookings.FormattingEnabled = true;
            this.listBoxUnAvBookings.Location = new System.Drawing.Point(43, 47);
            this.listBoxUnAvBookings.Name = "listBoxUnAvBookings";
            this.listBoxUnAvBookings.Size = new System.Drawing.Size(200, 277);
            this.listBoxUnAvBookings.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unavailable dates";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(354, 352);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(436, 351);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 3;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dateTimePickerCheckIn
            // 
            this.dateTimePickerCheckIn.Location = new System.Drawing.Point(330, 63);
            this.dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            this.dateTimePickerCheckIn.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerCheckIn.TabIndex = 4;
            // 
            // dateTimePickerCheckOut
            // 
            this.dateTimePickerCheckOut.Location = new System.Drawing.Point(330, 110);
            this.dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            this.dateTimePickerCheckOut.Size = new System.Drawing.Size(153, 20);
            this.dateTimePickerCheckOut.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Checkin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "New Checkout";
            // 
            // checkBoxBookDouble
            // 
            this.checkBoxBookDouble.AutoSize = true;
            this.checkBoxBookDouble.Location = new System.Drawing.Point(330, 179);
            this.checkBoxBookDouble.Name = "checkBoxBookDouble";
            this.checkBoxBookDouble.Size = new System.Drawing.Size(99, 17);
            this.checkBoxBookDouble.TabIndex = 42;
            this.checkBoxBookDouble.Text = "Two extra beds";
            this.checkBoxBookDouble.UseVisualStyleBackColor = true;
            this.checkBoxBookDouble.CheckedChanged += new System.EventHandler(this.checkBoxBookDouble_CheckedChanged);
            // 
            // checkBoxBookSingle
            // 
            this.checkBoxBookSingle.AutoSize = true;
            this.checkBoxBookSingle.Location = new System.Drawing.Point(330, 156);
            this.checkBoxBookSingle.Name = "checkBoxBookSingle";
            this.checkBoxBookSingle.Size = new System.Drawing.Size(93, 17);
            this.checkBoxBookSingle.TabIndex = 41;
            this.checkBoxBookSingle.Text = "One extra bed";
            this.checkBoxBookSingle.UseVisualStyleBackColor = true;
            this.checkBoxBookSingle.CheckedChanged += new System.EventHandler(this.checkBoxBookSingle_CheckedChanged);
            // 
            // EditBookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 400);
            this.Controls.Add(this.checkBoxBookDouble);
            this.Controls.Add(this.checkBoxBookSingle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerCheckOut);
            this.Controls.Add(this.dateTimePickerCheckIn);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxUnAvBookings);
            this.Name = "EditBookingForm";
            this.Text = "EditBookingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxUnAvBookings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerCheckOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxBookDouble;
        private System.Windows.Forms.CheckBox checkBoxBookSingle;
    }
}