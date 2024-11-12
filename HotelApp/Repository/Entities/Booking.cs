using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelApp.Repository.Entities
{
    public class Booking
    {
        [Key]
        public int BookingId { get; set; }

        [Required]
        public DateTime BookedDate { get; set; }

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public int RoomId { get; set; }

        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        [Required]
        public int Guests { get; set; }

        [Required]
        public int TotalPrice { get; set; }

        [Required]
        public DateTime PaymentExpireDate { get; set; }

        [Required]
        [StringLength(15)]
        public string PaymentStatus { get; set; }
    }
}
