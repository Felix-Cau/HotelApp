using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Repository.Entities
{
    public class RoomType
    {
        [Key]
        public int RoomTypeId { get; set; }

        [Required]
        [StringLength(25)]
        public string RoomTypeName { get; set; }

        [Required]
        [StringLength(500)]
        public string RoomDescription { get; set; }

        [Required]
        public int RoomSize { get; set; }

        [Required]
        public int ExtraBeds { get; set; }

        [Required]
        public int RoomPrice { get; set; }

        public virtual ICollection<Room> Rooms { get; set; }
    }
}
