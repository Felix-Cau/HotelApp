using HotelApp.HelperClasses;
using HotelApp.Repository.Entities;
using HotelApp.Repository.Repos;

namespace HotelApp.Views
{
    public partial class FormBookings : Form
    {
        Booking? selectedBooking = new();
        public FormBookings()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            BookingRepo bookingRepo = new();
            var bookingList = bookingRepo.GetBookingsByCustomerName(textBoxSearchForUser.Text);

            listBoxSearchBookingResult.DataSource = bookingList;
            listBoxSearchBookingResult.DisplayMember = "BookingId";
            listBoxSearchBookingResult.ValueMember = "BookingId";
        }

        private void listBoxSearchBookingResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBooking = (Booking)listBoxSearchBookingResult.SelectedItem;

            ComboBoxHelper.ChangeNumberOfGuests((RoomType)selectedBooking.Room.RoomType, comboBoxAmountOfGuests, (int)selectedBooking.Guests);
            textBoxRoom.Text = selectedBooking.Room.RoomName.ToString();
            textBoxCustomer.Text = selectedBooking.Customer.FullName.ToString();
            textBoxTotalPrice.Text = selectedBooking.TotalPrice.ToString();
            textBoxPaymentStatus.Text = selectedBooking.PaymentStatus.ToString();
        }

        private void buttonMarkedAsPaid_Click(object sender, EventArgs e)
        {
            selectedBooking.PaymentStatus = "paid";
            textBoxPaymentStatus.Text = selectedBooking.PaymentStatus;

            BookingRepo bookingRepo = new();
            bookingRepo.UpdateBooking(selectedBooking);

            MessageBox.Show("Booking is updated and marked as paid.");
        }

        private void buttonClearUnpaidBookings_Click(object sender, EventArgs e)
        {
            BookingRepo bookingRepo = new();
            bookingRepo.RemoveOverDueBookings();

            MessageBox.Show("Overdue bookings removed.");
        }

        private void buttonUpdateBooking_Click(object sender, EventArgs e)
        {
            int newNumberOfGuests = (int)comboBoxAmountOfGuests.SelectedValue;

            if (newNumberOfGuests == 0)
            {
                MessageBox.Show("You can not have a booked room with zero guests. Try agian or cancel the booking.");
            }
            else if (selectedBooking.Guests == newNumberOfGuests)
            {
                MessageBox.Show("You need to select a new amount of guests. Try again.");
            }
            else
            {
                selectedBooking.Guests = newNumberOfGuests;

                BookingRepo bookingRepo = new();
                bookingRepo.UpdateBooking(selectedBooking);

                MessageBox.Show("Booking updated.");
                ClearAllFields();
            }
        }

        private void ClearAllFields()
        {
            listBoxSearchBookingResult.DataSource = new List<string>();
            textBoxRoom.Text = string.Empty;
            textBoxCustomer.Text = string.Empty;
            textBoxTotalPrice.Text = string.Empty;
            textBoxPaymentStatus.Text = string.Empty;
        }

        private void buttonCancelBooking_Click(object sender, EventArgs e)
        {
            BookingRepo booking = new();
            booking.DeleteBooking(selectedBooking);

            MessageBox.Show("Booking was cancelled.");

            ClearAllFields();
            selectedBooking = null;
        }

        private void buttonCloseWindow_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
