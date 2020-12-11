using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinApiRequest.Models
{
    public class Game
    {
        public int id { get; set; }
        public string slug { get; set; }
        public string name { get; set; }
        public int added { get; set; }
    }
}
