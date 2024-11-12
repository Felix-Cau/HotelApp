namespace HotelApp.Views
{
    partial class FormBookings
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
            textBoxSearchForUser = new TextBox();
            textBoxRoom = new TextBox();
            textBoxCustomer = new TextBox();
            textBoxTotalPrice = new TextBox();
            textBoxPaymentStatus = new TextBox();
            buttonSearch = new Button();
            buttonMarkedAsPaid = new Button();
            buttonClearUnpaidBookings = new Button();
            buttonCloseWindow = new Button();
            listBoxSearchBookingResult = new ListBox();
            labelInformation = new Label();
            labelSearchResultAndBookingPicker = new Label();
            labelCurrentBooking = new Label();
            labelRoom = new Label();
            labelCustomer = new Label();
            labelTotalPrice = new Label();
            labelPaymentStatus = new Label();
            labelAmountOfGuests = new Label();
            label1 = new Label();
            comboBoxAmountOfGuests = new ComboBox();
            buttonCancelBooking = new Button();
            buttonUpdateBooking = new Button();
            SuspendLayout();
            // 
            // textBoxSearchForUser
            // 
            textBoxSearchForUser.Location = new Point(12, 32);
            textBoxSearchForUser.Name = "textBoxSearchForUser";
            textBoxSearchForUser.Size = new Size(267, 23);
            textBoxSearchForUser.TabIndex = 0;
            // 
            // textBoxRoom
            // 
            textBoxRoom.Location = new Point(314, 105);
            textBoxRoom.Name = "textBoxRoom";
            textBoxRoom.Size = new Size(158, 23);
            textBoxRoom.TabIndex = 1;
            // 
            // textBoxCustomer
            // 
            textBoxCustomer.Location = new Point(314, 149);
            textBoxCustomer.Name = "textBoxCustomer";
            textBoxCustomer.Size = new Size(158, 23);
            textBoxCustomer.TabIndex = 2;
            // 
            // textBoxTotalPrice
            // 
            textBoxTotalPrice.Location = new Point(313, 190);
            textBoxTotalPrice.Name = "textBoxTotalPrice";
            textBoxTotalPrice.Size = new Size(158, 23);
            textBoxTotalPrice.TabIndex = 3;
            // 
            // textBoxPaymentStatus
            // 
            textBoxPaymentStatus.Location = new Point(314, 234);
            textBoxPaymentStatus.Name = "textBoxPaymentStatus";
            textBoxPaymentStatus.Size = new Size(158, 23);
            textBoxPaymentStatus.TabIndex = 4;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(204, 61);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(75, 23);
            buttonSearch.TabIndex = 5;
            buttonSearch.Text = "Search";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonMarkedAsPaid
            // 
            buttonMarkedAsPaid.Location = new Point(383, 319);
            buttonMarkedAsPaid.Name = "buttonMarkedAsPaid";
            buttonMarkedAsPaid.Size = new Size(89, 23);
            buttonMarkedAsPaid.TabIndex = 6;
            buttonMarkedAsPaid.Text = "Mark as paid";
            buttonMarkedAsPaid.UseVisualStyleBackColor = true;
            buttonMarkedAsPaid.Click += buttonMarkedAsPaid_Click;
            // 
            // buttonClearUnpaidBookings
            // 
            buttonClearUnpaidBookings.Location = new Point(352, 6);
            buttonClearUnpaidBookings.Name = "buttonClearUnpaidBookings";
            buttonClearUnpaidBookings.Size = new Size(134, 23);
            buttonClearUnpaidBookings.TabIndex = 7;
            buttonClearUnpaidBookings.Text = "Clear unpaid bookings";
            buttonClearUnpaidBookings.UseVisualStyleBackColor = true;
            buttonClearUnpaidBookings.Click += buttonClearUnpaidBookings_Click;
            // 
            // buttonCloseWindow
            // 
            buttonCloseWindow.Location = new Point(397, 426);
            buttonCloseWindow.Name = "buttonCloseWindow";
            buttonCloseWindow.Size = new Size(89, 23);
            buttonCloseWindow.TabIndex = 8;
            buttonCloseWindow.Text = "Close window";
            buttonCloseWindow.UseVisualStyleBackColor = true;
            buttonCloseWindow.Click += buttonCloseWindow_Click;
            // 
            // listBoxSearchBookingResult
            // 
            listBoxSearchBookingResult.FormattingEnabled = true;
            listBoxSearchBookingResult.ItemHeight = 15;
            listBoxSearchBookingResult.Location = new Point(12, 110);
            listBoxSearchBookingResult.Name = "listBoxSearchBookingResult";
            listBoxSearchBookingResult.Size = new Size(268, 334);
            listBoxSearchBookingResult.TabIndex = 9;
            listBoxSearchBookingResult.SelectedIndexChanged += listBoxSearchBookingResult_SelectedIndexChanged;
            // 
            // labelInformation
            // 
            labelInformation.AutoSize = true;
            labelInformation.Font = new Font("Segoe UI", 11F);
            labelInformation.Location = new Point(12, 9);
            labelInformation.Name = "labelInformation";
            labelInformation.Size = new Size(267, 20);
            labelInformation.TabIndex = 10;
            labelInformation.Text = "Search for bookings by customer name";
            // 
            // labelSearchResultAndBookingPicker
            // 
            labelSearchResultAndBookingPicker.AutoSize = true;
            labelSearchResultAndBookingPicker.Font = new Font("Segoe UI", 11F);
            labelSearchResultAndBookingPicker.Location = new Point(12, 87);
            labelSearchResultAndBookingPicker.Name = "labelSearchResultAndBookingPicker";
            labelSearchResultAndBookingPicker.Size = new Size(225, 20);
            labelSearchResultAndBookingPicker.TabIndex = 11;
            labelSearchResultAndBookingPicker.Text = "Search result and booking picker";
            // 
            // labelCurrentBooking
            // 
            labelCurrentBooking.AutoSize = true;
            labelCurrentBooking.Font = new Font("Segoe UI", 11F);
            labelCurrentBooking.Location = new Point(314, 40);
            labelCurrentBooking.Name = "labelCurrentBooking";
            labelCurrentBooking.Size = new Size(116, 20);
            labelCurrentBooking.TabIndex = 12;
            labelCurrentBooking.Text = "Current booking";
            // 
            // labelRoom
            // 
            labelRoom.AutoSize = true;
            labelRoom.Location = new Point(314, 87);
            labelRoom.Name = "labelRoom";
            labelRoom.Size = new Size(39, 15);
            labelRoom.TabIndex = 13;
            labelRoom.Text = "Room";
            // 
            // labelCustomer
            // 
            labelCustomer.AutoSize = true;
            labelCustomer.Location = new Point(314, 131);
            labelCustomer.Name = "labelCustomer";
            labelCustomer.Size = new Size(59, 15);
            labelCustomer.TabIndex = 14;
            labelCustomer.Text = "Customer";
            // 
            // labelTotalPrice
            // 
            labelTotalPrice.AutoSize = true;
            labelTotalPrice.Location = new Point(314, 175);
            labelTotalPrice.Name = "labelTotalPrice";
            labelTotalPrice.Size = new Size(130, 15);
            labelTotalPrice.TabIndex = 15;
            labelTotalPrice.Text = "Total price in US Dollars";
            // 
            // labelPaymentStatus
            // 
            labelPaymentStatus.AutoSize = true;
            labelPaymentStatus.Location = new Point(314, 216);
            labelPaymentStatus.Name = "labelPaymentStatus";
            labelPaymentStatus.Size = new Size(88, 15);
            labelPaymentStatus.TabIndex = 16;
            labelPaymentStatus.Text = "Payment status";
            // 
            // labelAmountOfGuests
            // 
            labelAmountOfGuests.AutoSize = true;
            labelAmountOfGuests.Location = new Point(313, 260);
            labelAmountOfGuests.Name = "labelAmountOfGuests";
            labelAmountOfGuests.Size = new Size(107, 15);
            labelAmountOfGuests.TabIndex = 18;
            labelAmountOfGuests.Text = "Amount of guests*";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 7F);
            label1.Location = new Point(313, 275);
            label1.Name = "label1";
            label1.Size = new Size(82, 12);
            label1.TabIndex = 19;
            label1.Text = "*Can be changed";
            // 
            // comboBoxAmountOfGuests
            // 
            comboBoxAmountOfGuests.FormattingEnabled = true;
            comboBoxAmountOfGuests.Location = new Point(313, 290);
            comboBoxAmountOfGuests.Name = "comboBoxAmountOfGuests";
            comboBoxAmountOfGuests.Size = new Size(121, 23);
            comboBoxAmountOfGuests.TabIndex = 20;
            // 
            // buttonCancelBooking
            // 
            buttonCancelBooking.Location = new Point(373, 377);
            buttonCancelBooking.Name = "buttonCancelBooking";
            buttonCancelBooking.Size = new Size(99, 23);
            buttonCancelBooking.TabIndex = 21;
            buttonCancelBooking.Text = "Cancel booking";
            buttonCancelBooking.UseVisualStyleBackColor = true;
            buttonCancelBooking.Click += buttonCancelBooking_Click;
            // 
            // buttonUpdateBooking
            // 
            buttonUpdateBooking.Location = new Point(368, 348);
            buttonUpdateBooking.Name = "buttonUpdateBooking";
            buttonUpdateBooking.Size = new Size(104, 23);
            buttonUpdateBooking.TabIndex = 22;
            buttonUpdateBooking.Text = "Update booking";
            buttonUpdateBooking.UseVisualStyleBackColor = true;
            buttonUpdateBooking.Click += buttonUpdateBooking_Click;
            // 
            // FormBookings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 461);
            Controls.Add(buttonUpdateBooking);
            Controls.Add(buttonCancelBooking);
            Controls.Add(comboBoxAmountOfGuests);
            Controls.Add(label1);
            Controls.Add(labelAmountOfGuests);
            Controls.Add(labelPaymentStatus);
            Controls.Add(labelTotalPrice);
            Controls.Add(labelCustomer);
            Controls.Add(labelRoom);
            Controls.Add(labelCurrentBooking);
            Controls.Add(labelSearchResultAndBookingPicker);
            Controls.Add(labelInformation);
            Controls.Add(listBoxSearchBookingResult);
            Controls.Add(buttonCloseWindow);
            Controls.Add(buttonClearUnpaidBookings);
            Controls.Add(buttonMarkedAsPaid);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxPaymentStatus);
            Controls.Add(textBoxTotalPrice);
            Controls.Add(textBoxCustomer);
            Controls.Add(textBoxRoom);
            Controls.Add(textBoxSearchForUser);
            Name = "FormBookings";
            Text = "Bookings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxSearchForUser;
        private TextBox textBoxRoom;
        private TextBox textBoxCustomer;
        private TextBox textBoxTotalPrice;
        private TextBox textBoxPaymentStatus;
        private Button buttonSearch;
        private Button buttonMarkedAsPaid;
        private Button buttonClearUnpaidBookings;
        private Button buttonCloseWindow;
        private ListBox listBoxSearchBookingResult;
        private Label labelInformation;
        private Label labelSearchResultAndBookingPicker;
        private Label labelCurrentBooking;
        private Label labelRoom;
        private Label labelCustomer;
        private Label labelTotalPrice;
        private Label labelPaymentStatus;
        private Label labelAmountOfGuests;
        private Label label1;
        private ComboBox comboBoxAmountOfGuests;
        private Button buttonCancelBooking;
        private Button buttonUpdateBooking;
    }
}