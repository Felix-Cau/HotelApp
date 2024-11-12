using HotelApp.Repository.Entities;

namespace HotelApp.HelperClasses
{
    public static class CalculateHelper
    {
        public static (int totalPrice, int amountOfNights) CalculateTotalPriceAndAmountOfNights(DateTime checkInDate, DateTime checkOutDate, Room room)
        {
            int amountOfNights = (checkOutDate - checkInDate).Days;

            int totalPrice = amountOfNights * room.RoomType.RoomPrice;

            return (totalPrice, amountOfNights);
        }
    }
}
