using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace regular
{
    internal class RoomReservation<T> where T : HotelRoom
    {
        public static List<T> values = new List<T>();
        public void BookRoom(T room)
        {
            values.Add(room);
        }
        public void CancelRoom(T room)
        {
            values.Remove(room);
        }
    }
}
