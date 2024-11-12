using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Repository.Entities
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        [Required]
        [StringLength(30)]
        public string RoomName { get; set; }

        public int RoomTypeId { get; set; }

        [ForeignKey("RoomTypeId")]
        public RoomType RoomType { get; set; }

        public ICollection<Room> Bookings { get; set; }
    }
}
