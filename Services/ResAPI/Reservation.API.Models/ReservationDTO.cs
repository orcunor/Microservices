using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Models
{
   public class ReservationDTO
    {
        public int Id { get; set; }
        public string ReservationId { get; set; }
        public DateTime? CheckInDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public DateTime? ReservationDate { get; set; }
        public double Amount { get; set; }
    }
}
