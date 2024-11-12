using HotelApp.HelperClasses;
using HotelApp.Repository.Entities;
using HotelApp.Repository.Repos;
using System.Diagnostics;

namespace HotelApp.Views
{
    public partial class FormHotel : Form
    {
        Customer selectedCustomer = new();
        Room selectedRoom = new();
        DateTime checkInDate = new();
        DateTime checkOutDate = new();

        public FormHotel()
        {
            InitializeComponent();
            LoadAmountOfGuestsComboBoxOnStartUp();
        }

        private void buttonSearchForCustomer_Click(object sender, EventArgs e)
        {
            var searchCondition = textBoxSearchForGuest.Text.Trim();

            if (string.IsNullOrEmpty(searchCondition))
            {
                MessageBox.Show("The search field can not be empty.");
            }
            else
            {
                CustomerRepo customerRepo = new();
                var searchResult = customerRepo.Search(searchCondition);

                if (searchResult.Count == 0)
                {
                    MessageBox.Show("No customer found. Try again");
                    ResetBookingProcedure();
                }
                else
                {
                    listBoxSearchCustomerResult.DataSource = searchResult;
                    listBoxSearchCustomerResult.DisplayMember = "FullName";
                    listBoxSearchCustomerResult.ValueMember = "CustomerId";
                }
            }
        }

        private void listBoxSearchCustomerResult_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedCustomer = (Customer)listBoxSearchCustomerResult.SelectedItem;

            textBoxBookingCustomer.Text = selectedCustomer.FullName;
        }

        private void buttonAddNewCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.ShowDialog();
        }

        private void buttonEditCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer(selectedCustomer);
            formCustomer.ShowDialog();
        }

        private void buttonSearchForRooms_Click_1(object sender, EventArgs e)
        {
            checkInDate = dateTimePickerCheckInDate.Value.Date;
            checkOutDate = dateTimePickerCheckOutDate.Value.Date;
            int guests = (int)comboBoxNoOfGuests.SelectedValue;

            if (checkInDate > checkOutDate)
            {
                MessageBox.Show("The check out date must be after the check in date.");
            }
            else
            {
                RoomRepo roomRepo = new();
                var availableRooms = roomRepo.SearchAvailableRooms(checkInDate, checkOutDate, guests);

                listBoxAvailableRooms.DataSource = availableRooms;
                listBoxAvailableRooms.DisplayMember = "RoomName";
                listBoxAvailableRooms.ValueMember = "RoomId";
            }
        }

        private void listBoxAvailableRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRoom = (Room)listBoxAvailableRooms.SelectedItem;
            (int totalPrice, int amountOfNights) = CalculateHelper.CalculateTotalPriceAndAmountOfNights(checkInDate, checkOutDate, selectedRoom);

            LoadAmountOfExtraBetsOnRoomSelect(selectedRoom);
            textBoxDisplaySelectedRoomType.Text = selectedRoom.RoomType.RoomTypeName.ToString();
            textBoxDisplayMaxNoOfGuests.Text = selectedRoom.RoomType.RoomSize.ToString();
            textBoxDisplayPricePerNight.Text = selectedRoom.RoomType.RoomPrice.ToString();
            richTextBoxRoomDescription.Text = selectedRoom.RoomType.RoomDescription;
            textBoxBookingRoom.Text = selectedRoom.RoomName;
            textBoxBookingNoOfGuests.Text = comboBoxNoOfGuests.SelectedValue.ToString();
            textBoxBookingCheckInDate.Text = dateTimePickerCheckInDate.Value.ToString();
            textBoxBookingCheckOutDate.Text = dateTimePickerCheckOutDate.Value.ToString();
            textBoxAmountOfNights.Text = amountOfNights.ToString();
            textBoxBookingTotalPrice.Text = totalPrice.ToString();


        }

        private void buttonCreateBooking_Click_1(object sender, EventArgs e)
        {
            (int totalPrice, _) = CalculateHelper.CalculateTotalPriceAndAmountOfNights(checkInDate, checkOutDate, selectedRoom);
            int amountOfGuestsOnBooking = (int)comboBoxNoOfGuests.SelectedValue + (int)comboBoxExtraBeds.SelectedValue;

            BookingRepo bookingRepo = new();
            bookingRepo.CreateBooking(selectedCustomer, selectedRoom, checkInDate, checkOutDate, amountOfGuestsOnBooking, totalPrice);

            MessageBox.Show("Booking created! Make sure to inform the Customer of the 10 days expiration date on the Invoice.");

            ResetBookingProcedure();
        }

        private void buttonContactSupport_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/watch?v=5pUgjOBIdN8";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void buttonCheckBookings_Click(object sender, EventArgs e)
        {
            FormBookings formBookings = new FormBookings();
            formBookings.ShowDialog();
        }

        private void LoadAmountOfGuestsComboBoxOnStartUp()
        {
            ComboBoxHelper.NumberOfGuestComboBoxHelper(comboBoxNoOfGuests);
        }

        private void LoadAmountOfExtraBetsOnRoomSelect(Room selectedRoom)
        {
            ComboBoxHelper.NumberOfExtraBeds(comboBoxExtraBeds, selectedRoom);
        }

        private void ResetBookingProcedure()
        {
            textBoxSearchForGuest.Text = string.Empty;
            textBoxDisplaySelectedRoomType.Text = string.Empty;
            textBoxDisplayMaxNoOfGuests.Text = string.Empty;
            textBoxDisplayPricePerNight.Text = string.Empty;
            richTextBoxRoomDescription.Text = string.Empty;
            textBoxBookingRoom.Text = string.Empty;
            textBoxBookingNoOfGuests.Text = string.Empty;
            textBoxBookingCheckInDate.Text = string.Empty;
            textBoxBookingCheckOutDate.Text = string.Empty;
            textBoxAmountOfNights.Text = string.Empty;
            textBoxBookingTotalPrice.Text = string.Empty;

            listBoxAvailableRooms.DataSource = new List<string>();
            listBoxSearchCustomerResult.DataSource = new List<string>();
        }

        
    }
}
