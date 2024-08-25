using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkApp.Rooms
{
    public class Livingroom : RoomTemplate
    {
        public Livingroom(string roomName, int length, int width, int height, int sockets)
       : base(roomName, length, width, height, sockets)
        {
        }
    }
}
