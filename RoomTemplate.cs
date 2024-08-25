using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkApp
{
    public class RoomTemplate
    {
        private string? roomName;
        private int length;
        private int width;
        private int height;
        private double surface;
        private int sockets;

        public string? RoomName 
        {
            get 
            {
                return this.roomName;
            }
            set 
            {
                this.roomName = value;
            } 
        }
        public int Length 
        {
            get
            {
                return this.length;
            }
            set
            {
                if (this.length > 0)
                {
                    this.length = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, length should always be greater than 0.");
                }
            }
        }
        public int Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (this.width > 0)
                {
                    this.width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, width should always be greater than 0.");
                }
            }
        }
        public int Height 
        {
            get
            {
                return this.height;
            }
            set
            {
                if (this.height > 0)
                {
                    this.height = value;
                }
                else 
                { 
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, height should always be greater than 0."); 
                }
            }
        }
        public int Sockets
        {
            get
            {
                return this.Sockets;
            }
            set
            {
                this.Sockets = value;
            }
        }

        public double Surface(int length, int width) 
        { 
            surface = length * width;
            return surface;
        }

        public RoomTemplate(string roomName, int length,int width, int height, int sockets)
        {
            this.RoomName = roomName;
            this.Length = length;
            this.Width = width;
            this.Height = height;
            this.Sockets = sockets;
        }
    }
}
