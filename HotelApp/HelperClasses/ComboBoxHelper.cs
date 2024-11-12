using HotelApp.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.HelperClasses
{
    public static class ComboBoxHelper
    {
        public static void NumberOfGuestComboBoxHelper(ComboBox comboBox)
        {
            comboBox.DataSource = new BindingSource { DataSource = AmountOfGuests };
            comboBox.DisplayMember = "Key";
            comboBox.ValueMember = "Value";
        }

        internal static void NumberOfExtraBeds(ComboBox comboBoxExtraBeds, Room selectedRoom)
        {
            int amountOfExtraBeds = selectedRoom.RoomType.ExtraBeds;

            switch (selectedRoom.RoomType.ExtraBeds)
            {
                case 1:
                    comboBoxExtraBeds.DataSource = new BindingSource { DataSource = AmountOfBedsOne };
                    comboBoxExtraBeds.DisplayMember = "Key";
                    comboBoxExtraBeds.ValueMember = "Value";
                    break;
                case 2:
                    comboBoxExtraBeds.DataSource = new BindingSource { DataSource = AmountOfBedsTwo };
                    comboBoxExtraBeds.DisplayMember = "Key";
                    comboBoxExtraBeds.ValueMember = "Value";
                    break;
                default:
                    break;
            }
        }

        internal static void ChangeNumberOfGuests(RoomType roomType, ComboBox comboBox, int amountOfGuests)
        {
            switch (roomType.RoomTypeName)
            {
                case "Single":
                    comboBox.DataSource = new BindingSource { DataSource = AmountOfBedsTwo };
                    comboBox.DisplayMember = "Key";
                    comboBox.ValueMember = "Value";
                    break;
                case "Double":
                    comboBox.DataSource = new BindingSource { DataSource = AmountOfExtraBedsFour };
                    comboBox.DisplayMember = "Key";
                    comboBox.ValueMember = "Value";
                    break;
                case "Family":
                    comboBox.DataSource = new BindingSource { DataSource = AmountOfGuests };
                    comboBox.DisplayMember = "Key";
                    comboBox.ValueMember = "Value";
                    break;
                default:
                    break;
            }
        }

        private static readonly Dictionary<int, int> AmountOfGuests = new()
        {
            { 1, 1 },
            { 2, 2 },
            { 3, 3 },
            { 4, 4 },
            { 5, 5 },
            { 6, 6 }
        };

        private static readonly Dictionary<int, int> AmountOfBedsTwo = new()
        {
            { 0, 0 },
            { 1, 1 },
            { 2, 2 }
        };

        private static readonly Dictionary<int, int> AmountOfBedsOne = new()
        {
            { 0, 0 },
            { 1, 1 }
        };

        private static readonly Dictionary<int, int> AmountOfExtraBedsFour = new()
        {
            { 1, 1 },
            { 2, 2 },
            { 3, 3 },
            { 4, 4 },
        };
    }
}
