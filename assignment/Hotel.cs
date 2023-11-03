using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace regular
{
    internal class Hotel : TourismDestination
    {
        public Hotel(string? name, int availableRooms) : base(name, availableRooms)
        {
            Name = name;
            AvailableRooms = availableRooms;
        }

        public string? Name { get; set; }
        public int AvailableRooms { get; set; }

        public async Task<bool> BookRoomsAsync(int numRoomsRequestted)
        {
            if(numRoomsRequestted <= AvailableRooms)
            {
                await Task.Delay(2000);
                AvailableRooms = numRoomsRequestted;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
