using Reservation.API.Infastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
   public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationById(string reservationId)
        {
            return new ReservationDTO
            {
                Id = (new Random()).Next(100),
                Amount = (new Random()).Next(1000),
                ReservationDate = DateTime.UtcNow,
                CheckInDate = DateTime.UtcNow.AddDays(30),
                CheckOutDate = DateTime.UtcNow.AddDays(37),
                ReservationId = reservationId

            };
        }
    }
}
