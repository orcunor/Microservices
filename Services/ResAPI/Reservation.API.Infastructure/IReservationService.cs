using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Infastructure
{
   public interface IReservationService
    {
        ReservationDTO GetReservationById(string reservationId);
    }
}
