using DeskBooker.Core.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DeskBook.Core.DataInterface
{
    public interface IDeskBookingRepository
    {
        // void Save(DeskBooking deskBooking);
        void Save(DeskBooking deskBooking);
    }
}
