using Contact.API.Infrastructure;
using Contact.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact.API.Services
{
    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int id)
        { 
             // databaseen de alabiliriz.
            return new ContactDTO
            {
                Id = id,
                FirstName = "Orçun",
                LastName = "Or"
            };

        }
    }
}
